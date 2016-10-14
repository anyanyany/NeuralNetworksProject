using Encog.Engine.Network.Activation;
using Encog.ML.Data;
using Encog.ML.Data.Basic;
using Encog.ML.Data.Versatile;
using Encog.ML.Data.Versatile.Columns;
using Encog.ML.Data.Versatile.Normalizers.Strategy;
using Encog.ML.Data.Versatile.Sources;
using Encog.ML.Factory;
using Encog.ML.Model;
using Encog.ML.Train;
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
        public Form1()
        {
            InitializeComponent();
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
                    var format = new CSVFormat('.', ',');
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
            layersList.Items.Add(numberOfNeurons.Value);
        }

        private void deleteLayerButton_Click(object sender, EventArgs e)
        {
            if (layersList.SelectedIndex >= 0)
            {
                layersList.Items.RemoveAt(layersList.SelectedIndex);
            }
        }

        private BasicNetwork GetNetworkFromFields()
        {
            IActivationFunction activationFunction = null;
            BasicNetwork mlp = new BasicNetwork();

            for (int i = 0; i < layersList.Items.Count; i++)
            {
                if (unipolarRadioButton.Checked)
                    activationFunction = new ActivationSigmoid();
                else if (bipolarRadioButton.Checked)
                    activationFunction = new ActivationTANH();

                int neurons = int.Parse(layersList.Items[i].ToString());
                mlp.AddLayer(new BasicLayer(activationFunction, biasCheckBox.Checked, neurons));
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
                ColumnDefinition cls = trainingSet.DefineSourceColumn("cls", 2, ColumnType.Ordinal); //?????
                cls.DefineClass(new string[] {"1","2","3"});
                trainingSet.Analyze();
                trainingSet.DefineSingleOutputOthersInput(cls);
                //trainingSet.DefineInput(x);
                //trainingSet.DefineInput(y);
                //trainingSet.DefineOutput(outputColumn);

                model = new EncogModel(trainingSet);
                model.SelectMethod(trainingSet, MLMethodFactory.TypeFeedforward);
                trainingSet.Normalize();
                model.HoldBackValidation(0.3, true, 1001);
                model.SelectTrainingType(trainingSet);

                var data = model.Dataset;
                var datainput = data.Select(v => new double[2] { v.Input[0], v.Input[1] }).ToArray();
                var dataideal = data.Select(v => new double[1] { v.Ideal[0] }).ToArray();

                trainingData = new BasicMLDataSet(datainput, dataideal);


            }
            else if(regressionRadioButton.Checked)
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
               // var bestMethod = (IMLRegression)model.C r o s s v ali d a t e (5 , true ) ;

                var data = model.Dataset;
                var datainput = data.Select(v => new double[2] { v.Input[0], v.Input[1] }).ToArray();
                var dataideal = data.Select(v => new double[1] { v.Ideal[0] }).ToArray();

                trainingData = new BasicMLDataSet(datainput, dataideal);
            }
            
            BasicNetwork mlp = GetNetworkFromFields();
            TrainNetwork(mlp, trainingData);
            TestNetworkUsability(mlp);
        }

        private void TrainNetwork(BasicNetwork mlp, IMLDataSet trainingData)
        {
            Backpropagation train = new Backpropagation(mlp, trainingData, (double)learnRate.Value, (double)momentum.Value);
            //ResilientPropagation train = new ResilientPropagation(mlp, model.Dataset);

            double[] errors = new double[(int)iterations.Value];
            for (int i = 0; i < iterations.Value; i++)
            {
                train.Iteration();
                errors[i] = train.Error;
                Console.WriteLine($"Error: {i + 1}:  {errors[i]}");
            }
            train.FinishTraining();
        }

        private void TestNetworkUsability(BasicNetwork mlp)
        {
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
                string correct = csv.Get(inputVectorLength);
                string predicted = helper.DenormalizeOutputVectorToString(output)[0];
                if (correct.Equals(predicted)) sum++;
                count++;
            }
            Console.WriteLine($"Got {sum} elements correctly classified out of {count} which is {(float)sum / count}% good");
        }
    }
}
