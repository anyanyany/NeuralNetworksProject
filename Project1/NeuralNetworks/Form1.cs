using Encog.Engine.Network.Activation;
using Encog.ML.Data;
using Encog.ML.Data.Versatile;
using Encog.ML.Data.Versatile.Columns;
using Encog.ML.Data.Versatile.Normalizers.Strategy;
using Encog.ML.Data.Versatile.Sources;
using Encog.Neural.Networks;
using Encog.Neural.Networks.Layers;
using Encog.Neural.Networks.Training.Propagation.Back;
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
        private IMLDataSet trainingSet;
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
                    var format = new CSVFormat('.', ',');
                    trainingSet = EncogUtility.LoadCSV2Memory(trainingFileName, 2, 1, true, format, false);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                
                int neurons = Int32.Parse(layersList.Items[i].ToString());
                MLP.AddLayer(new BasicLayer(af, biasCheckBox.Checked, neurons));
            }

            /*
            Dla sieci MLP zdefiniowanie
                liczby warstw, i neuronów ukrytych w każdej warstwie(pełne połączenia pomiędzy warstwami)
                funkcji aktywacji (unipolarnej lub bipolarnej)
                obecność biasu
                liczby iteracji
                wartości współczynnika nauki
                wartość współczynnika bezwładności
                zdefiniowanie rodzaju problemu(klasyfikacja lub regresja) - można zrealizować przez odpowiednie przygotowanie zbioru uczącego i definicję liczby i skali wyjść
            */
            MLP.Structure.FinalizeStructure();
            Backpropagation train = new Backpropagation(MLP, trainingSet, (double)learnRate.Value, (double)momentum.Value);
        }
    }
}
