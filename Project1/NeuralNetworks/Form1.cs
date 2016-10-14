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
        BasicNetwork MLP;
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

        private void computeButton_Click(object sender, EventArgs e)
        {
            IMLDataSet trainingData = null;
            IActivationFunction af = null;

            if (classificationRadioButton.Checked)
            {
                ColumnDefinition x = trainingSet.DefineSourceColumn("x", 0, ColumnType.Continuous);
                ColumnDefinition y = trainingSet.DefineSourceColumn("y", 1, ColumnType.Continuous);
                ColumnDefinition cls = trainingSet.DefineSourceColumn("cls", 2, ColumnType.Continuous); //?????
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

                var data = model.Dataset;
                var datainput = data.Select(v => new double[2] { v.Input[0], v.Input[1] }).ToArray();
                var dataideal = data.Select(v => new double[1] { v.Ideal[0] }).ToArray();

                trainingData = new BasicMLDataSet(datainput, dataideal);
            }
            
           
            MLP = new BasicNetwork();
            
            for (int i=0;i<layersList.Items.Count;i++)
            {            
                if (unipolarRadioButton.Checked)
                    af = new ActivationSigmoid();
                else if (bipolarRadioButton.Checked)
                    af = new ActivationTANH();
                
                int neurons = int.Parse(layersList.Items[i].ToString());
                MLP.AddLayer(new BasicLayer(af, biasCheckBox.Checked, neurons));
            }
          
            MLP.Structure.FinalizeStructure();   
            MLP.Reset();

            Backpropagation train = new Backpropagation(MLP, trainingData, (double)learnRate.Value, (double)momentum.Value);
           //IMLTrain train = new ResilientPropagation(MLP, model.Dataset);

            double[] errors = new double[(int)iterations.Value];
            for(int i=0;i<iterations.Value;i++)
            {
                train.Iteration();
                errors[i] = train.Error;
                Console.WriteLine($"Error: {i+1}:  {errors[i]}");
            }
            train.FinishTraining();
        }
    }
}
