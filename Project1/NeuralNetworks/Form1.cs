using Encog.Engine.Network.Activation;
using Encog.ML;
using Encog.ML.Data;
using Encog.ML.Data.Basic;
using Encog.ML.Data.Versatile;
using Encog.ML.Data.Versatile.Columns;
using Encog.ML.Data.Versatile.Normalizers.Strategy;
using Encog.ML.Data.Versatile.Sources;
using Encog.ML.Factory;
using Encog.ML.Model;
using Encog.ML.Train;
using Encog.Neural.Data.Basic;
using Encog.Neural.Networks;
using Encog.Neural.Networks.Layers;
using Encog.Neural.Networks.Training.Propagation.Back;
using Encog.Neural.Networks.Training.Propagation.Resilient;
using Encog.Util.CSV;
using Encog.Util.Simple;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetworks
{
    public partial class Form1 : Form
    {
        private string trainingFileName;
        private string testFileName;
        private EncogModel model;
        private VersatileMLDataSet trainingSet;
        private VersatileMLDataSet testSet;
        private List<BasicLayer> networkLayers;
        public Form1()
        {
            InitializeComponent();
            networkLayers = new List<BasicLayer>();
        }

        private void loadTrainingSetButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog
            {
                Title = @"Open File",
                Filter = @"CSV files|*.csv",
                InitialDirectory = Directory.GetCurrentDirectory()
            };
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                trainingFileName = theDialog.FileName;

                try
                {
                    trainingSet = new VersatileMLDataSet(new CSVDataSource(trainingFileName, true,
                        CSVFormat.DecimalPoint));
                    trainingSet.NormHelper.Format = CSVFormat.DecimalPoint;
                    trainingSetLabel.Text = trainingFileName;
                }
                catch (FileNotFoundException exception)
                {
                    MessageBox.Show("Wrong file!" + exception.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void loadTestSetButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog
            {
                Title = @"Open File",
                Filter = @"CSV files|*.csv",
                InitialDirectory = Directory.GetCurrentDirectory()
            };
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                testFileName = theDialog.FileName;

                try
                {
                    testSet = new VersatileMLDataSet(new CSVDataSource(testFileName, true,
                        CSVFormat.DecimalPoint));
                    testSetLabel.Text = testFileName;
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void addLayerButton_Click(object sender, EventArgs e)
        {
            IActivationFunction activationFunction = null;
            layersList.Items.Add(numberOfNeurons.Value + ", " + biasCheckBox.Checked + ", " + (unipolarRadioButton.Checked ? "unipolar" : "bipolar"));

            if (unipolarRadioButton.Checked)
                activationFunction = new ActivationSigmoid();
            else if (bipolarRadioButton.Checked)
                activationFunction = new ActivationTANH();
            networkLayers.Add(new BasicLayer(activationFunction, biasCheckBox.Checked, (int)numberOfNeurons.Value));
        }

        private void deleteLayerButton_Click(object sender, EventArgs e)
        {
            int index = layersList.SelectedIndex;
            if (index >= 0)
            {
                layersList.Items.RemoveAt(index);
                networkLayers.RemoveAt(index);
            }
        }

        private BasicNetwork GetNetworkFromFields()
        {
            BasicNetwork mlp = new BasicNetwork();
            for (int i = 0; i < networkLayers.Count; i++)
            {
                mlp.AddLayer(networkLayers[i]);
            }
            mlp.Structure.FinalizeStructure();
            mlp.Reset();
            return mlp;
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            IMLDataSet trainingData = null;

            if (trainingSet != null)
            {
                trainingSet = new VersatileMLDataSet(new CSVDataSource(trainingFileName, true,
                        CSVFormat.DecimalPoint));
                trainingSet.NormHelper.Format = CSVFormat.DecimalPoint;
            }

            if (classificationRadioButton.Checked)
            {
                ColumnDefinition x = trainingSet.DefineSourceColumn("x", 0, ColumnType.Continuous);
                ColumnDefinition y = trainingSet.DefineSourceColumn("y", 1, ColumnType.Continuous);
                ColumnDefinition cls = trainingSet.DefineSourceColumn("cls", 2, ColumnType.Nominal);
                cls.DefineClass(new string[] { "1", "2", "3" });
                trainingSet.Analyze();
                trainingSet.DefineSingleOutputOthersInput(cls);

                model = new EncogModel(trainingSet);
                model.SelectMethod(trainingSet, MLMethodFactory.TypeFeedforward);
                trainingSet.Normalize();
                model.HoldBackValidation(0.3, true, 1001);
                model.SelectTrainingType(trainingSet);
                
                var data = model.Dataset;
                var datainput = data.Select(v => new double[2] { v.Input[0], v.Input[1] }).ToArray();
                var dataideal = data.Select(v => new double[3] { v.Ideal[0], v.Ideal[1], v.Ideal[2] }).ToArray();

                trainingData = new BasicNeuralDataSet(datainput, dataideal);

                BasicNetwork mlp = GetNetworkFromFields();
                TrainNetwork(mlp, trainingData);
                TestNetworkUsability(mlp);

            }
            else if (regressionRadioButton.Checked)
            {
                ColumnDefinition x = trainingSet.DefineSourceColumn("x", 0, ColumnType.Continuous);
                ColumnDefinition y = trainingSet.DefineSourceColumn("y", 1, ColumnType.Continuous);
                trainingSet.Analyze();
                trainingSet.DefineSingleOutputOthersInput(y);

                model = new EncogModel(trainingSet);
                model.SelectMethod(trainingSet, MLMethodFactory.TypeFeedforward);
                trainingSet.Normalize();
                model.HoldBackValidation(0.3, true, 1001);
                model.SelectTrainingType(trainingSet);

                var data = model.Dataset;
                var datainput = data.Select(v => new double[1] { v.Input[0] }).ToArray();
                var dataideal = data.Select(v => new double[1] { v.Ideal[0] }).ToArray();

                trainingData = new BasicMLDataSet(datainput, dataideal);

                BasicNetwork mlp = GetNetworkFromFields();
                TrainNetwork(mlp, trainingData);
                TestNetworkUsability(mlp);
            }
        }

        private void TrainNetwork(BasicNetwork mlp, IMLDataSet trainingData)
        {
            var csv = new StringBuilder();

            Backpropagation train = new Backpropagation(mlp, trainingData, (double)learnRate.Value, (double)momentum.Value);
            //ResilientPropagation train = new ResilientPropagation(mlp, trainingData, (double)learnRate.Value, (double)momentum.Value);
            train.BatchSize = 1;

            double[] errors = new double[(int)iterations.Value];
            for (int i = 0; i < iterations.Value; i++)
            {
                train.Iteration();
                errors[i] = train.Error;
                Console.WriteLine($"Error: {i + 1}:  {errors[i]}");

                var newLine = string.Format("{0},{1}", i + 1, errors[i].ToString().Replace(',', '.'));
                csv.AppendLine(newLine);
            }
            Console.WriteLine($"Training error: {errors[errors.Length - 1]}");
            train.FinishTraining();
            File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\TrainingErrors.csv", csv.ToString());
        }

        private void TestNetworkUsability(IMLRegression mlp)
        {
            var outputCsv = new StringBuilder();
            if (classificationRadioButton.Checked)
                outputCsv.AppendLine("x,y,cls");
            else if (regressionRadioButton.Checked)
                outputCsv.AppendLine("x,y");
            string newLine=null;
            ReadCSV csv = new ReadCSV(trainingFileName, true, CSVFormat.DecimalPoint);
            NormalizationHelper helper = trainingSet.NormHelper;
            IMLData input = helper.AllocateInputVector();

            int sum = 0, count = 0;
            int inputVectorLength = csv.ColumnNames.Count - 1;
            string[] line = new string[inputVectorLength];

            while (csv.Next())
            {
                for (int i = 0; i < inputVectorLength; i++)
                    line[i] = csv.Get(i);

                helper.NormalizeInputVector(line, ((BasicMLData)input).Data, true);
                IMLData output = mlp.Compute(input);
                double predictedValue = double.Parse(helper.DenormalizeOutputVectorToString(output)[0]);
                string correct = csv.Get(inputVectorLength);
                string predicted = Math.Round(predictedValue, 0).ToString();
                Console.WriteLine($"Got output: {predictedValue} while correct is {correct}");
                if (correct.Equals(predicted)) sum++;
                count++;
                if (classificationRadioButton.Checked)
                    newLine = string.Format("{0},{1},{2}", csv.Get(0).ToString().Replace(',', '.'), csv.Get(1).ToString().Replace(',', '.'), predicted);
                else if(regressionRadioButton.Checked)
                    newLine = string.Format("{0},{1}", csv.Get(0).ToString().Replace(',', '.'), predictedValue.ToString().Replace(',', '.'));

                outputCsv.AppendLine(newLine);
            }
            Console.WriteLine($"Got {sum} elements correctly classified out of {count} which is {(float)sum * 100 / count}% good");

            if (classificationRadioButton.Checked)
                File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\ResultsClassification.csv", outputCsv.ToString());
            else if (regressionRadioButton.Checked)
                File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\ResultsRegression.csv", outputCsv.ToString());


        }
    }
}
