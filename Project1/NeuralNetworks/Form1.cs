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
        private IMLDataSet testSet;
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
                    // var format = new CSVFormat('.', ',');
                    // testSet = EncogUtility.LoadCSV2Memory(trainingFileName, 2, 1, true, format, false);
                    trainingSet = new VersatileMLDataSet(new CSVDataSource(trainingFileName, true,
                        CSVFormat.DecimalPoint));
                    trainingSet.NormHelper.Format = CSVFormat.DecimalPoint;
                    ColumnDefinition x = trainingSet.DefineSourceColumn("x", 0, ColumnType.Continuous);
                    ColumnDefinition y = trainingSet.DefineSourceColumn("y", 1, ColumnType.Continuous);
                    ColumnDefinition outputColumn = trainingSet.DefineSourceColumn("cls", 2, ColumnType.Continuous);
                    trainingSet.Analyze();

                    //trainingSet.DefineSingleOutputOthersInput(outputColumn);
                    trainingSet.DefineInput(x);
                    trainingSet.DefineInput(y);
                    trainingSet.DefineOutput(outputColumn);

                    model = new EncogModel(trainingSet);               
                    model.SelectMethod(trainingSet, MLMethodFactory.TypeFeedforward);
                    trainingSet.Normalize();
                    model.HoldBackValidation(0.3, true, 1001);
                    model.SelectTrainingType(trainingSet);

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
                    testSet = EncogUtility.LoadCSV2Memory(testFileName, 2, 0, true, format, false);

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

        private void computeButton_Click(object sender, EventArgs e)
        {
            if(classificationRadioButton.Checked)
            {
                //TODO
            }
            else if(regressionRadioButton.Checked)
            {
                //TODO
            }

            BasicNetwork MLP = new BasicNetwork();
            IActivationFunction af;

            for (int i=0;i<layersList.Items.Count;i++)
            {
                
                if (unipolarRadioButton.Checked)
                {
                    af = new ActivationSigmoid();
                } 
                else
                {
                    af = new ActivationTANH();
                }

                
                int neurons = int.Parse(layersList.Items[i].ToString());
                MLP.AddLayer(new BasicLayer(af, biasCheckBox.Checked, neurons));
            }
          
            MLP.Structure.FinalizeStructure();   
            MLP.Reset();

            var data = model.Dataset;
            //BasicMLDataSet dataSet = new BasicMLDataSet();
            //foreach (var d in data) dataSet.Add(d);
            var datainput = data.Select(x => new double[2] { x.Input[0], x.Input[1]}).ToArray();
            var dataideal = data.Select(x => new double[1] { x.Ideal[0] }).ToArray();

            IMLDataSet trainingData = new BasicMLDataSet(datainput, dataideal);

           Backpropagation train = new Backpropagation(MLP, trainingData, (double)learnRate.Value, (double)momentum.Value);
           //IMLTrain train = new ResilientPropagation(MLP, model.Dataset);

            double[] errors = new double[(int)iterations.Value];
            for(int i=0;i<iterations.Value;i++)
            {
                train.Iteration();
                errors[i] = train.Error;
                Console.WriteLine($"Error: {i}:  {errors[i]}");

            }
            train.FinishTraining();
        }
    }
}
