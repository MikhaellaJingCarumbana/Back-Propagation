namespace BackPropagation_Carumbana
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
            this.gbSetup = new System.Windows.Forms.GroupBox();
            this.numUDNeuron = new System.Windows.Forms.NumericUpDown();
            this.lblHN = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gbTraining = new System.Windows.Forms.GroupBox();
            this.numUDEpoch = new System.Windows.Forms.NumericUpDown();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvInputOutput = new System.Windows.Forms.DataGridView();
            this.Input3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Input2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Input1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Output = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkKeepInputs = new System.Windows.Forms.CheckBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rbInputAND4 = new System.Windows.Forms.RadioButton();
            this.gbSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNeuron)).BeginInit();
            this.gbTraining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDEpoch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSetup
            // 
            this.gbSetup.Controls.Add(this.numUDNeuron);
            this.gbSetup.Controls.Add(this.lblHN);
            this.gbSetup.Controls.Add(this.btnReset);
            this.gbSetup.Controls.Add(this.btnCreate);
            this.gbSetup.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.gbSetup.Location = new System.Drawing.Point(29, 24);
            this.gbSetup.Name = "gbSetup";
            this.gbSetup.Size = new System.Drawing.Size(355, 100);
            this.gbSetup.TabIndex = 1;
            this.gbSetup.TabStop = false;
            this.gbSetup.Text = "Model Setup";
            this.gbSetup.Enter += new System.EventHandler(this.gbSetup_Enter);
            // 
            // numUDNeuron
            // 
            this.numUDNeuron.Location = new System.Drawing.Point(222, 29);
            this.numUDNeuron.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUDNeuron.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDNeuron.Name = "numUDNeuron";
            this.numUDNeuron.Size = new System.Drawing.Size(75, 22);
            this.numUDNeuron.TabIndex = 8;
            this.numUDNeuron.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUDNeuron.ValueChanged += new System.EventHandler(this.numUDNeuron_ValueChanged);
            // 
            // lblHN
            // 
            this.lblHN.AutoSize = true;
            this.lblHN.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHN.Location = new System.Drawing.Point(49, 30);
            this.lblHN.Name = "lblHN";
            this.lblHN.Size = new System.Drawing.Size(167, 15);
            this.lblHN.TabIndex = 7;
            this.lblHN.Text = "Number of hidden neurons:";
            this.lblHN.Click += new System.EventHandler(this.lblHN_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(193, 61);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(112, 61);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // gbTraining
            // 
            this.gbTraining.Controls.Add(this.numUDEpoch);
            this.gbTraining.Controls.Add(this.btnTrain);
            this.gbTraining.Controls.Add(this.btnLoad);
            this.gbTraining.Controls.Add(this.label1);
            this.gbTraining.Controls.Add(this.btnSave);
            this.gbTraining.Location = new System.Drawing.Point(396, 24);
            this.gbTraining.Name = "gbTraining";
            this.gbTraining.Size = new System.Drawing.Size(355, 100);
            this.gbTraining.TabIndex = 9;
            this.gbTraining.TabStop = false;
            this.gbTraining.Text = " ";
            this.gbTraining.Enter += new System.EventHandler(this.gbTraining_Enter);
            // 
            // numUDEpoch
            // 
            this.numUDEpoch.Location = new System.Drawing.Point(243, 29);
            this.numUDEpoch.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUDEpoch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDEpoch.Name = "numUDEpoch";
            this.numUDEpoch.Size = new System.Drawing.Size(75, 20);
            this.numUDEpoch.TabIndex = 6;
            this.numUDEpoch.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUDEpoch.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnTrain
            // 
            this.btnTrain.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnTrain.Location = new System.Drawing.Point(243, 61);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(75, 23);
            this.btnTrain.TabIndex = 5;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoad.Location = new System.Drawing.Point(162, 61);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(70, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of times to train:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(81, 61);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvInputOutput
            // 
            this.dgvInputOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInputOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInputOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Input3,
            this.Input2,
            this.Input1,
            this.I0,
            this.Output});
            this.dgvInputOutput.Location = new System.Drawing.Point(29, 172);
            this.dgvInputOutput.Name = "dgvInputOutput";
            this.dgvInputOutput.RowHeadersWidth = 51;
            this.dgvInputOutput.Size = new System.Drawing.Size(722, 265);
            this.dgvInputOutput.TabIndex = 35;
            this.dgvInputOutput.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInputOutput_CellContentClick);
            // 
            // Input3
            // 
            this.Input3.HeaderText = "Input 3";
            this.Input3.MinimumWidth = 6;
            this.Input3.Name = "Input3";
            // 
            // Input2
            // 
            this.Input2.HeaderText = "Input 2";
            this.Input2.MinimumWidth = 6;
            this.Input2.Name = "Input2";
            // 
            // Input1
            // 
            this.Input1.HeaderText = "Input 1";
            this.Input1.MinimumWidth = 6;
            this.Input1.Name = "Input1";
            // 
            // I0
            // 
            this.I0.HeaderText = "Input 0";
            this.I0.MinimumWidth = 6;
            this.I0.Name = "I0";
            // 
            // Output
            // 
            this.Output.HeaderText = "Output";
            this.Output.MinimumWidth = 6;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            // 
            // chkKeepInputs
            // 
            this.chkKeepInputs.AutoSize = true;
            this.chkKeepInputs.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.chkKeepInputs.Location = new System.Drawing.Point(533, 149);
            this.chkKeepInputs.Name = "chkKeepInputs";
            this.chkKeepInputs.Size = new System.Drawing.Size(89, 17);
            this.chkKeepInputs.TabIndex = 39;
            this.chkKeepInputs.Text = "Keep Inputs";
            this.chkKeepInputs.UseVisualStyleBackColor = true;
            this.chkKeepInputs.CheckedChanged += new System.EventHandler(this.chkKeepInputs_CheckedChanged);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTest.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTest.Location = new System.Drawing.Point(220, 452);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(138, 32);
            this.btnTest.TabIndex = 40;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(364, 452);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 32);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rbInputAND4
            // 
            this.rbInputAND4.AutoSize = true;
            this.rbInputAND4.Checked = true;
            this.rbInputAND4.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.rbInputAND4.Location = new System.Drawing.Point(29, 147);
            this.rbInputAND4.Name = "rbInputAND4";
            this.rbInputAND4.Size = new System.Drawing.Size(125, 17);
            this.rbInputAND4.TabIndex = 7;
            this.rbInputAND4.TabStop = true;
            this.rbInputAND4.Text = "4-input AND GATE";
            this.rbInputAND4.UseVisualStyleBackColor = true;
            this.rbInputAND4.CheckedChanged += new System.EventHandler(this.rbInputAND4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(783, 499);
            this.Controls.Add(this.rbInputAND4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.chkKeepInputs);
            this.Controls.Add(this.dgvInputOutput);
            this.Controls.Add(this.gbTraining);
            this.Controls.Add(this.gbSetup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Back Propagation";
            this.gbSetup.ResumeLayout(false);
            this.gbSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNeuron)).EndInit();
            this.gbTraining.ResumeLayout(false);
            this.gbTraining.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDEpoch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSetup;
        private System.Windows.Forms.NumericUpDown numUDNeuron;
        private System.Windows.Forms.Label lblHN;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox gbTraining;
        private System.Windows.Forms.NumericUpDown numUDEpoch;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvInputOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Input3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Input2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Input1;
        private System.Windows.Forms.DataGridViewTextBoxColumn I0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Output;
        private System.Windows.Forms.CheckBox chkKeepInputs;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rbInputAND4;
    }
}

