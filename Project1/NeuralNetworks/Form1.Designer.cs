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
            this.deleteLayerButton = new System.Windows.Forms.Button();
            this.addLayerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfNeurons = new System.Windows.Forms.NumericUpDown();
            this.layersList = new System.Windows.Forms.ListBox();
            this.biasCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.activationFunctionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.unipolarRadioButton = new System.Windows.Forms.RadioButton();
            this.bipolarRadioButton = new System.Windows.Forms.RadioButton();
            this.mainPanel.SuspendLayout();
            this.defineLayersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfNeurons)).BeginInit();
            this.activationFunctionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // computeButton
            // 
            this.computeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computeButton.FlatAppearance.BorderSize = 3;
            this.computeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.computeButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.computeButton.Location = new System.Drawing.Point(359, 495);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(350, 51);
            this.computeButton.TabIndex = 0;
            this.computeButton.Text = "COMPUTE";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // loadTrainingSetButton
            // 
            this.loadTrainingSetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadTrainingSetButton.FlatAppearance.BorderSize = 2;
            this.loadTrainingSetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTrainingSetButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadTrainingSetButton.Location = new System.Drawing.Point(3, 3);
            this.loadTrainingSetButton.Name = "loadTrainingSetButton";
            this.loadTrainingSetButton.Size = new System.Drawing.Size(350, 76);
            this.loadTrainingSetButton.TabIndex = 1;
            this.loadTrainingSetButton.Text = "Load training set";
            this.loadTrainingSetButton.UseVisualStyleBackColor = true;
            this.loadTrainingSetButton.Click += new System.EventHandler(this.loadTrainingSetButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mainPanel.ColumnCount = 3;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.Controls.Add(this.loadTestSetButton, 1, 0);
            this.mainPanel.Controls.Add(this.loadTrainingSetButton, 0, 0);
            this.mainPanel.Controls.Add(this.computeButton, 1, 4);
            this.mainPanel.Controls.Add(this.defineLayersPanel, 0, 2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 5;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainPanel.Size = new System.Drawing.Size(733, 549);
            this.mainPanel.TabIndex = 2;
            // 
            // loadTestSetButton
            // 
            this.loadTestSetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadTestSetButton.FlatAppearance.BorderSize = 2;
            this.loadTestSetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTestSetButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadTestSetButton.Location = new System.Drawing.Point(359, 3);
            this.loadTestSetButton.Name = "loadTestSetButton";
            this.loadTestSetButton.Size = new System.Drawing.Size(350, 76);
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
            this.defineLayersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.defineLayersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.defineLayersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.defineLayersPanel.Controls.Add(this.label3, 0, 4);
            this.defineLayersPanel.Controls.Add(this.deleteLayerButton, 3, 5);
            this.defineLayersPanel.Controls.Add(this.addLayerButton, 0, 5);
            this.defineLayersPanel.Controls.Add(this.label2, 0, 2);
            this.defineLayersPanel.Controls.Add(this.label1, 0, 0);
            this.defineLayersPanel.Controls.Add(this.numberOfNeurons, 1, 2);
            this.defineLayersPanel.Controls.Add(this.layersList, 3, 2);
            this.defineLayersPanel.Controls.Add(this.biasCheckBox, 1, 3);
            this.defineLayersPanel.Controls.Add(this.activationFunctionPanel, 1, 4);
            this.defineLayersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defineLayersPanel.Location = new System.Drawing.Point(3, 101);
            this.defineLayersPanel.Name = "defineLayersPanel";
            this.defineLayersPanel.RowCount = 6;
            this.defineLayersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.defineLayersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.defineLayersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.defineLayersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.defineLayersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.defineLayersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.defineLayersPanel.Size = new System.Drawing.Size(706, 279);
            this.defineLayersPanel.TabIndex = 3;
            // 
            // deleteLayerButton
            // 
            this.deleteLayerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteLayerButton.FlatAppearance.BorderSize = 2;
            this.deleteLayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteLayerButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteLayerButton.Location = new System.Drawing.Point(355, 236);
            this.deleteLayerButton.Name = "deleteLayerButton";
            this.deleteLayerButton.Size = new System.Drawing.Size(348, 40);
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
            this.addLayerButton.Size = new System.Drawing.Size(346, 40);
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
            this.label2.Size = new System.Drawing.Size(170, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "number of neurons:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.defineLayersPanel.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Define layers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfNeurons
            // 
            this.numberOfNeurons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfNeurons.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberOfNeurons.Location = new System.Drawing.Point(186, 78);
            this.numberOfNeurons.Margin = new System.Windows.Forms.Padding(10);
            this.numberOfNeurons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfNeurons.Name = "numberOfNeurons";
            this.numberOfNeurons.Size = new System.Drawing.Size(156, 26);
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
            this.layersList.Location = new System.Drawing.Point(355, 71);
            this.layersList.Name = "layersList";
            this.defineLayersPanel.SetRowSpan(this.layersList, 3);
            this.layersList.Size = new System.Drawing.Size(348, 159);
            this.layersList.TabIndex = 4;
            // 
            // biasCheckBox
            // 
            this.biasCheckBox.AutoSize = true;
            this.biasCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.biasCheckBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.biasCheckBox.Location = new System.Drawing.Point(186, 112);
            this.biasCheckBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.biasCheckBox.Name = "biasCheckBox";
            this.biasCheckBox.Size = new System.Drawing.Size(163, 35);
            this.biasCheckBox.TabIndex = 7;
            this.biasCheckBox.Text = "Bias";
            this.biasCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 83);
            this.label3.TabIndex = 8;
            this.label3.Text = "activation function:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activationFunctionPanel
            // 
            this.activationFunctionPanel.ColumnCount = 1;
            this.activationFunctionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.activationFunctionPanel.Controls.Add(this.bipolarRadioButton, 0, 1);
            this.activationFunctionPanel.Controls.Add(this.unipolarRadioButton, 0, 0);
            this.activationFunctionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activationFunctionPanel.Location = new System.Drawing.Point(179, 153);
            this.activationFunctionPanel.Name = "activationFunctionPanel";
            this.activationFunctionPanel.RowCount = 2;
            this.activationFunctionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.activationFunctionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.activationFunctionPanel.Size = new System.Drawing.Size(170, 77);
            this.activationFunctionPanel.TabIndex = 9;
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
            this.unipolarRadioButton.Text = "Unipolar";
            this.unipolarRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.unipolarRadioButton.UseVisualStyleBackColor = true;
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
            this.bipolarRadioButton.Text = "Bipolar";
            this.bipolarRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bipolarRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 549);
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
    }
}

