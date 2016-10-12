namespace NeuralNetworks
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.computeButton = new System.Windows.Forms.Button();
            this.loadTrainingSetButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.loadTestSetButton = new System.Windows.Forms.Button();
            this.defineLayersPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteLayerButton = new System.Windows.Forms.Button();
            this.addLayerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfNeurons = new System.Windows.Forms.NumericUpDown();
            this.layersList = new System.Windows.Forms.ListBox();
            this.biasCheckBox = new System.Windows.Forms.CheckBox();
            this.activationFunctionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bipolarRadioButton = new System.Windows.Forms.RadioButton();
            this.unipolarRadioButton = new System.Windows.Forms.RadioButton();
            this.parametersPanel = new System.Windows.Forms.TableLayoutPanel();
            this.iterations = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.learnRate = new System.Windows.Forms.NumericUpDown();
            this.momentum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loadButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.trainingSetLabel = new System.Windows.Forms.Label();
            this.testSetLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.classificationRadioButton = new System.Windows.Forms.RadioButton();
            this.regressionRadioButton = new System.Windows.Forms.RadioButton();
            this.mainPanel.SuspendLayout();
            this.defineLayersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfNeurons)).BeginInit();
            this.activationFunctionPanel.SuspendLayout();
            this.parametersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.momentum)).BeginInit();
            this.loadButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // computeButton
            // 
            this.mainPanel.SetColumnSpan(this.computeButton, 3);
            this.computeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.computeButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.computeButton.Location = new System.Drawing.Point(3, 399);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(767, 66);
            this.computeButton.TabIndex = 0;
            this.computeButton.Text = "COMPUTE";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // loadTrainingSetButton
            // 
            this.loadTrainingSetButton.FlatAppearance.BorderSize = 2;
            this.loadTrainingSetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTrainingSetButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadTrainingSetButton.Location = new System.Drawing.Point(79, 3);
            this.loadTrainingSetButton.Name = "loadTrainingSetButton";
            this.loadTrainingSetButton.Size = new System.Drawing.Size(224, 37);
            this.loadTrainingSetButton.TabIndex = 1;
            this.loadTrainingSetButton.Text = "Load training set";
            this.loadTrainingSetButton.UseVisualStyleBackColor = true;
            this.loadTrainingSetButton.Click += new System.EventHandler(this.loadTrainingSetButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.ColumnCount = 3;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainPanel.Controls.Add(this.computeButton, 0, 4);
            this.mainPanel.Controls.Add(this.defineLayersPanel, 0, 2);
            this.mainPanel.Controls.Add(this.parametersPanel, 2, 2);
            this.mainPanel.Controls.Add(this.loadButtonsPanel, 0, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 5;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPanel.Size = new System.Drawing.Size(773, 468);
            this.mainPanel.TabIndex = 2;
            // 
            // loadTestSetButton
            // 
            this.loadTestSetButton.FlatAppearance.BorderSize = 2;
            this.loadTestSetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTestSetButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadTestSetButton.Location = new System.Drawing.Point(79, 46);
            this.loadTestSetButton.Name = "loadTestSetButton";
            this.loadTestSetButton.Size = new System.Drawing.Size(224, 38);
            this.loadTestSetButton.TabIndex = 2;
            this.loadTestSetButton.Text = "Load test set";
            this.loadTestSetButton.UseVisualStyleBackColor = true;
            this.loadTestSetButton.Click += new System.EventHandler(this.loadTestSetButton_Click);
            // 
            // defineLayersPanel
            // 
            this.defineLayersPanel.BackColor = System.Drawing.SystemColors.Control;
            this.defineLayersPanel.ColumnCount = 3;
            this.mainPanel.SetColumnSpan(this.defineLayersPanel, 2);
            this.defineLayersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.defineLayersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.defineLayersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.defineLayersPanel.Controls.Add(this.label3, 0, 4);
            this.defineLayersPanel.Controls.Add(this.deleteLayerButton, 3, 5);
            this.defineLayersPanel.Controls.Add(this.addLayerButton, 0, 5);
            this.defineLayersPanel.Controls.Add(this.label2, 0, 2);
            this.defineLayersPanel.Controls.Add(this.label1, 0, 0);
            this.defineLayersPanel.Controls.Add(this.numberOfNeurons, 1, 2);
            this.defineLayersPanel.Controls.Add(this.layersList, 3, 2);
            this.defineLayersPanel.Controls.Add(this.biasCheckBox, 0, 3);
            this.defineLayersPanel.Controls.Add(this.activationFunctionPanel, 1, 4);
            this.defineLayersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defineLayersPanel.Location = new System.Drawing.Point(3, 110);
            this.defineLayersPanel.Name = "defineLayersPanel";
            this.defineLayersPanel.RowCount = 6;
            this.defineLayersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.defineLayersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.defineLayersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.defineLayersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.defineLayersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.defineLayersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.defineLayersPanel.Size = new System.Drawing.Size(534, 274);
            this.defineLayersPanel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 83);
            this.label3.TabIndex = 8;
            this.label3.Text = "activation function:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteLayerButton
            // 
            this.deleteLayerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteLayerButton.FlatAppearance.BorderSize = 2;
            this.deleteLayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteLayerButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteLayerButton.Location = new System.Drawing.Point(399, 236);
            this.deleteLayerButton.Name = "deleteLayerButton";
            this.deleteLayerButton.Size = new System.Drawing.Size(258, 40);
            this.deleteLayerButton.TabIndex = 5;
            this.deleteLayerButton.Text = "Delete layer";
            this.deleteLayerButton.UseVisualStyleBackColor = true;
            this.deleteLayerButton.Click += new System.EventHandler(this.deleteLayerButton_Click);
            // 
            // addLayerButton
            // 
            this.defineLayersPanel.SetColumnSpan(this.addLayerButton, 2);
            this.addLayerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addLayerButton.FlatAppearance.BorderSize = 2;
            this.addLayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLayerButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addLayerButton.Location = new System.Drawing.Point(3, 236);
            this.addLayerButton.Name = "addLayerButton";
            this.addLayerButton.Size = new System.Drawing.Size(390, 40);
            this.addLayerButton.TabIndex = 3;
            this.addLayerButton.Text = "Add layer";
            this.addLayerButton.UseVisualStyleBackColor = true;
            this.addLayerButton.Click += new System.EventHandler(this.addLayerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "number of neurons:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.defineLayersPanel.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "define layers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // numberOfNeurons
            // 
            this.numberOfNeurons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfNeurons.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberOfNeurons.Location = new System.Drawing.Point(208, 78);
            this.numberOfNeurons.Margin = new System.Windows.Forms.Padding(10);
            this.numberOfNeurons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfNeurons.Name = "numberOfNeurons";
            this.numberOfNeurons.Size = new System.Drawing.Size(178, 26);
            this.numberOfNeurons.TabIndex = 2;
            this.numberOfNeurons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // layersList
            // 
            this.layersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layersList.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layersList.FormattingEnabled = true;
            this.layersList.ItemHeight = 19;
            this.layersList.Location = new System.Drawing.Point(399, 71);
            this.layersList.Name = "layersList";
            this.defineLayersPanel.SetRowSpan(this.layersList, 3);
            this.layersList.Size = new System.Drawing.Size(258, 159);
            this.layersList.TabIndex = 4;
            // 
            // biasCheckBox
            // 
            this.biasCheckBox.AutoSize = true;
            this.defineLayersPanel.SetColumnSpan(this.biasCheckBox, 2);
            this.biasCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.biasCheckBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.biasCheckBox.Location = new System.Drawing.Point(25, 112);
            this.biasCheckBox.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.biasCheckBox.Name = "biasCheckBox";
            this.biasCheckBox.Size = new System.Drawing.Size(368, 35);
            this.biasCheckBox.TabIndex = 7;
            this.biasCheckBox.Text = "bias";
            this.biasCheckBox.UseVisualStyleBackColor = true;
            // 
            // activationFunctionPanel
            // 
            this.activationFunctionPanel.ColumnCount = 1;
            this.activationFunctionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.activationFunctionPanel.Controls.Add(this.bipolarRadioButton, 0, 1);
            this.activationFunctionPanel.Controls.Add(this.unipolarRadioButton, 0, 0);
            this.activationFunctionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activationFunctionPanel.Location = new System.Drawing.Point(201, 153);
            this.activationFunctionPanel.Name = "activationFunctionPanel";
            this.activationFunctionPanel.RowCount = 2;
            this.activationFunctionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.activationFunctionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.activationFunctionPanel.Size = new System.Drawing.Size(192, 77);
            this.activationFunctionPanel.TabIndex = 9;
            // 
            // bipolarRadioButton
            // 
            this.bipolarRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bipolarRadioButton.AutoSize = true;
            this.bipolarRadioButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bipolarRadioButton.Location = new System.Drawing.Point(3, 41);
            this.bipolarRadioButton.Name = "bipolarRadioButton";
            this.bipolarRadioButton.Size = new System.Drawing.Size(90, 33);
            this.bipolarRadioButton.TabIndex = 1;
            this.bipolarRadioButton.TabStop = true;
            this.bipolarRadioButton.Text = "bipolar";
            this.bipolarRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bipolarRadioButton.UseVisualStyleBackColor = true;
            // 
            // unipolarRadioButton
            // 
            this.unipolarRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.unipolarRadioButton.AutoSize = true;
            this.unipolarRadioButton.Checked = true;
            this.unipolarRadioButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unipolarRadioButton.Location = new System.Drawing.Point(3, 3);
            this.unipolarRadioButton.Name = "unipolarRadioButton";
            this.unipolarRadioButton.Size = new System.Drawing.Size(99, 32);
            this.unipolarRadioButton.TabIndex = 0;
            this.unipolarRadioButton.TabStop = true;
            this.unipolarRadioButton.Text = "unipolar";
            this.unipolarRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.unipolarRadioButton.UseVisualStyleBackColor = true;
            // 
            // parametersPanel
            // 
            this.parametersPanel.ColumnCount = 2;
            this.parametersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.parametersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.parametersPanel.Controls.Add(this.regressionRadioButton, 0, 7);
            this.parametersPanel.Controls.Add(this.classificationRadioButton, 0, 6);
            this.parametersPanel.Controls.Add(this.label7, 0, 0);
            this.parametersPanel.Controls.Add(this.iterations, 1, 4);
            this.parametersPanel.Controls.Add(this.label6, 0, 4);
            this.parametersPanel.Controls.Add(this.learnRate, 1, 2);
            this.parametersPanel.Controls.Add(this.momentum, 1, 3);
            this.parametersPanel.Controls.Add(this.label5, 0, 3);
            this.parametersPanel.Controls.Add(this.label4, 0, 2);
            this.parametersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parametersPanel.Location = new System.Drawing.Point(543, 110);
            this.parametersPanel.Name = "parametersPanel";
            this.parametersPanel.RowCount = 9;
            this.parametersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.parametersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.parametersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.parametersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.parametersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.parametersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.parametersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.parametersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.parametersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.parametersPanel.Size = new System.Drawing.Size(227, 274);
            this.parametersPanel.TabIndex = 4;
            // 
            // iterations
            // 
            this.iterations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iterations.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iterations.Location = new System.Drawing.Point(123, 152);
            this.iterations.Margin = new System.Windows.Forms.Padding(10);
            this.iterations.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.iterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterations.Name = "iterations";
            this.iterations.Size = new System.Drawing.Size(94, 26);
            this.iterations.TabIndex = 7;
            this.iterations.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(3, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 41);
            this.label6.TabIndex = 6;
            this.label6.Text = "iterations:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // learnRate
            // 
            this.learnRate.DecimalPlaces = 2;
            this.learnRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learnRate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.learnRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.learnRate.Location = new System.Drawing.Point(123, 70);
            this.learnRate.Margin = new System.Windows.Forms.Padding(10);
            this.learnRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.learnRate.Name = "learnRate";
            this.learnRate.Size = new System.Drawing.Size(94, 26);
            this.learnRate.TabIndex = 5;
            this.learnRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // momentum
            // 
            this.momentum.DecimalPlaces = 2;
            this.momentum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.momentum.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.momentum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.momentum.Location = new System.Drawing.Point(123, 111);
            this.momentum.Margin = new System.Windows.Forms.Padding(10);
            this.momentum.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.momentum.Name = "momentum";
            this.momentum.Size = new System.Drawing.Size(94, 26);
            this.momentum.TabIndex = 4;
            this.momentum.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 41);
            this.label5.TabIndex = 3;
            this.label5.Text = "momentum:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 41);
            this.label4.TabIndex = 2;
            this.label4.Text = "learn rate:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loadButtonsPanel
            // 
            this.loadButtonsPanel.ColumnCount = 3;
            this.mainPanel.SetColumnSpan(this.loadButtonsPanel, 3);
            this.loadButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.loadButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.loadButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.loadButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.loadButtonsPanel.Controls.Add(this.testSetLabel, 2, 1);
            this.loadButtonsPanel.Controls.Add(this.trainingSetLabel, 2, 0);
            this.loadButtonsPanel.Controls.Add(this.loadTrainingSetButton, 1, 0);
            this.loadButtonsPanel.Controls.Add(this.loadTestSetButton, 1, 1);
            this.loadButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadButtonsPanel.Location = new System.Drawing.Point(3, 3);
            this.loadButtonsPanel.Name = "loadButtonsPanel";
            this.loadButtonsPanel.RowCount = 2;
            this.loadButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loadButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loadButtonsPanel.Size = new System.Drawing.Size(767, 87);
            this.loadButtonsPanel.TabIndex = 5;
            // 
            // trainingSetLabel
            // 
            this.trainingSetLabel.AutoSize = true;
            this.trainingSetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainingSetLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trainingSetLabel.Location = new System.Drawing.Point(309, 0);
            this.trainingSetLabel.Name = "trainingSetLabel";
            this.trainingSetLabel.Size = new System.Drawing.Size(455, 43);
            this.trainingSetLabel.TabIndex = 3;
            this.trainingSetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // testSetLabel
            // 
            this.testSetLabel.AutoSize = true;
            this.testSetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testSetLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testSetLabel.Location = new System.Drawing.Point(309, 43);
            this.testSetLabel.Name = "testSetLabel";
            this.testSetLabel.Size = new System.Drawing.Size(455, 44);
            this.testSetLabel.TabIndex = 4;
            this.testSetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.parametersPanel.SetColumnSpan(this.label7, 3);
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 41);
            this.label7.TabIndex = 8;
            this.label7.Text = "and other patameters";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // classificationRadioButton
            // 
            this.classificationRadioButton.AutoSize = true;
            this.classificationRadioButton.Checked = true;
            this.parametersPanel.SetColumnSpan(this.classificationRadioButton, 2);
            this.classificationRadioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.classificationRadioButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.classificationRadioButton.Location = new System.Drawing.Point(10, 199);
            this.classificationRadioButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.classificationRadioButton.Name = "classificationRadioButton";
            this.classificationRadioButton.Size = new System.Drawing.Size(153, 21);
            this.classificationRadioButton.TabIndex = 9;
            this.classificationRadioButton.TabStop = true;
            this.classificationRadioButton.Text = "classification";
            this.classificationRadioButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.classificationRadioButton.UseVisualStyleBackColor = true;
            // 
            // regressionRadioButton
            // 
            this.regressionRadioButton.AutoSize = true;
            this.parametersPanel.SetColumnSpan(this.regressionRadioButton, 2);
            this.regressionRadioButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.regressionRadioButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.regressionRadioButton.Location = new System.Drawing.Point(10, 226);
            this.regressionRadioButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.regressionRadioButton.Name = "regressionRadioButton";
            this.regressionRadioButton.Size = new System.Drawing.Size(117, 29);
            this.regressionRadioButton.TabIndex = 10;
            this.regressionRadioButton.TabStop = true;
            this.regressionRadioButton.Text = "regression";
            this.regressionRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regressionRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 468);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MLP";
            this.mainPanel.ResumeLayout(false);
            this.defineLayersPanel.ResumeLayout(false);
            this.defineLayersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfNeurons)).EndInit();
            this.activationFunctionPanel.ResumeLayout(false);
            this.activationFunctionPanel.PerformLayout();
            this.parametersPanel.ResumeLayout(false);
            this.parametersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.momentum)).EndInit();
            this.loadButtonsPanel.ResumeLayout(false);
            this.loadButtonsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Button loadTrainingSetButton;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Button loadTestSetButton;
        private System.Windows.Forms.TableLayoutPanel defineLayersPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberOfNeurons;
        private System.Windows.Forms.Button addLayerButton;
        private System.Windows.Forms.ListBox layersList;
        private System.Windows.Forms.Button deleteLayerButton;
        private System.Windows.Forms.CheckBox biasCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel activationFunctionPanel;
        private System.Windows.Forms.RadioButton bipolarRadioButton;
        private System.Windows.Forms.RadioButton unipolarRadioButton;
        private System.Windows.Forms.TableLayoutPanel parametersPanel;
        private System.Windows.Forms.NumericUpDown learnRate;
        private System.Windows.Forms.NumericUpDown momentum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown iterations;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel loadButtonsPanel;
        private System.Windows.Forms.Label testSetLabel;
        private System.Windows.Forms.Label trainingSetLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton regressionRadioButton;
        private System.Windows.Forms.RadioButton classificationRadioButton;
    }
}

