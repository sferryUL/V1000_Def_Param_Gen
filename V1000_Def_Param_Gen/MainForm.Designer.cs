namespace V1000_Def_Param_Gen
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSlaveAddr = new System.Windows.Forms.TextBox();
            this.lblSlaveAddr = new System.Windows.Forms.Label();
            this.grpCommSettings = new System.Windows.Forms.GroupBox();
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.lblSerialCommPort = new System.Windows.Forms.Label();
            this.spVFD = new System.IO.Ports.SerialPort(this.components);
            this.bwrkReadParamListFile = new System.ComponentModel.BackgroundWorker();
            this.bwrkWriteDefValFile = new System.ComponentModel.BackgroundWorker();
            this.dgvV1000ParamView = new System.Windows.Forms.DataGridView();
            this.cmRegAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmParamNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmParmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmDefVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmVFDVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReadVFDVals = new System.Windows.Forms.Button();
            this.bwrkReadVFDVals = new System.ComponentModel.BackgroundWorker();
            this.lblParamView = new System.Windows.Forms.Label();
            this.grpInFileSettings = new System.Windows.Forms.GroupBox();
            this.btnVFDReset = new System.Windows.Forms.Button();
            this.btnReadParamList = new System.Windows.Forms.Button();
            this.txtParamListFile = new System.Windows.Forms.TextBox();
            this.btnBrowseParamList = new System.Windows.Forms.Button();
            this.lblParamListFile = new System.Windows.Forms.Label();
            this.btnBrowseDefValList = new System.Windows.Forms.Button();
            this.lblParamDefOutFile = new System.Windows.Forms.Label();
            this.opfdParamList = new System.Windows.Forms.OpenFileDialog();
            this.svfdParamDefValFile = new System.Windows.Forms.SaveFileDialog();
            this.grpParamDefValFile = new System.Windows.Forms.GroupBox();
            this.btnWriteDefValList = new System.Windows.Forms.Button();
            this.txtParamDefOutFile = new System.Windows.Forms.TextBox();
            this.grpCommSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvV1000ParamView)).BeginInit();
            this.grpInFileSettings.SuspendLayout();
            this.grpParamDefValFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSlaveAddr
            // 
            this.txtSlaveAddr.Location = new System.Drawing.Point(511, 21);
            this.txtSlaveAddr.Name = "txtSlaveAddr";
            this.txtSlaveAddr.Size = new System.Drawing.Size(46, 20);
            this.txtSlaveAddr.TabIndex = 0;
            this.txtSlaveAddr.TextChanged += new System.EventHandler(this.txtSlaveAddr_TextChanged);
            // 
            // lblSlaveAddr
            // 
            this.lblSlaveAddr.AutoSize = true;
            this.lblSlaveAddr.Location = new System.Drawing.Point(377, 24);
            this.lblSlaveAddr.Name = "lblSlaveAddr";
            this.lblSlaveAddr.Size = new System.Drawing.Size(128, 13);
            this.lblSlaveAddr.TabIndex = 14;
            this.lblSlaveAddr.Text = "VFD Slave Address (hex):";
            this.lblSlaveAddr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpCommSettings
            // 
            this.grpCommSettings.Controls.Add(this.lblSlaveAddr);
            this.grpCommSettings.Controls.Add(this.txtSlaveAddr);
            this.grpCommSettings.Controls.Add(this.cmbSerialPort);
            this.grpCommSettings.Controls.Add(this.lblSerialCommPort);
            this.grpCommSettings.Location = new System.Drawing.Point(13, 13);
            this.grpCommSettings.Name = "grpCommSettings";
            this.grpCommSettings.Size = new System.Drawing.Size(809, 53);
            this.grpCommSettings.TabIndex = 27;
            this.grpCommSettings.TabStop = false;
            this.grpCommSettings.Text = "Serial Communication Settings";
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerialPort.FormattingEnabled = true;
            this.cmbSerialPort.Location = new System.Drawing.Point(145, 21);
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Size = new System.Drawing.Size(135, 21);
            this.cmbSerialPort.TabIndex = 98;
            this.cmbSerialPort.TabStop = false;
            this.cmbSerialPort.SelectedIndexChanged += new System.EventHandler(this.cmbSerialPort_SelectedIndexChanged);
            // 
            // lblSerialCommPort
            // 
            this.lblSerialCommPort.AutoSize = true;
            this.lblSerialCommPort.Location = new System.Drawing.Point(6, 24);
            this.lblSerialCommPort.Name = "lblSerialCommPort";
            this.lblSerialCommPort.Size = new System.Drawing.Size(133, 13);
            this.lblSerialCommPort.TabIndex = 0;
            this.lblSerialCommPort.Text = "Serial Communication Port:";
            // 
            // spVFD
            // 
            this.spVFD.PortName = "COM99";
            this.spVFD.ReadBufferSize = 256;
            this.spVFD.ReceivedBytesThreshold = 7;
            this.spVFD.WriteBufferSize = 256;
            // 
            // bwrkReadParamListFile
            // 
            this.bwrkReadParamListFile.WorkerReportsProgress = true;
            this.bwrkReadParamListFile.WorkerSupportsCancellation = true;
            this.bwrkReadParamListFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwrkReadParamListRead_DoWork);
            this.bwrkReadParamListFile.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwrk_ProgressChanged);
            this.bwrkReadParamListFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwrkReadParamListFile_RunWorkerCompleted);
            // 
            // bwrkWriteDefValFile
            // 
            this.bwrkWriteDefValFile.WorkerReportsProgress = true;
            this.bwrkWriteDefValFile.WorkerSupportsCancellation = true;
            this.bwrkWriteDefValFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwrkWriteDefValFile_DoWork);
            this.bwrkWriteDefValFile.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwrk_ProgressChanged);
            this.bwrkWriteDefValFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwrkWriteDefValFile_RunWorkerCompleted);
            // 
            // dgvV1000ParamView
            // 
            this.dgvV1000ParamView.AllowUserToAddRows = false;
            this.dgvV1000ParamView.AllowUserToDeleteRows = false;
            this.dgvV1000ParamView.AllowUserToResizeColumns = false;
            this.dgvV1000ParamView.AllowUserToResizeRows = false;
            this.dgvV1000ParamView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvV1000ParamView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmRegAddr,
            this.cmParamNum,
            this.cmParmName,
            this.cmDefVal,
            this.cmVFDVal});
            this.dgvV1000ParamView.Location = new System.Drawing.Point(13, 186);
            this.dgvV1000ParamView.Name = "dgvV1000ParamView";
            this.dgvV1000ParamView.Size = new System.Drawing.Size(809, 593);
            this.dgvV1000ParamView.TabIndex = 36;
            // 
            // cmRegAddr
            // 
            this.cmRegAddr.DataPropertyName = "RegAddress";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmRegAddr.DefaultCellStyle = dataGridViewCellStyle1;
            this.cmRegAddr.HeaderText = "Parameter Address";
            this.cmRegAddr.Name = "cmRegAddr";
            this.cmRegAddr.ReadOnly = true;
            this.cmRegAddr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cmRegAddr.Width = 60;
            // 
            // cmParamNum
            // 
            this.cmParamNum.DataPropertyName = "ParamNum";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmParamNum.DefaultCellStyle = dataGridViewCellStyle2;
            this.cmParamNum.HeaderText = "Parameter Number";
            this.cmParamNum.Name = "cmParamNum";
            this.cmParamNum.ReadOnly = true;
            this.cmParamNum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cmParamNum.Width = 60;
            // 
            // cmParmName
            // 
            this.cmParmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmParmName.DataPropertyName = "ParamName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cmParmName.DefaultCellStyle = dataGridViewCellStyle3;
            this.cmParmName.HeaderText = "Parameter Name";
            this.cmParmName.Name = "cmParmName";
            this.cmParmName.ReadOnly = true;
            // 
            // cmDefVal
            // 
            this.cmDefVal.DataPropertyName = "DefVal";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmDefVal.DefaultCellStyle = dataGridViewCellStyle4;
            this.cmDefVal.HeaderText = "Default Value";
            this.cmDefVal.Name = "cmDefVal";
            this.cmDefVal.ReadOnly = true;
            this.cmDefVal.Width = 70;
            // 
            // cmVFDVal
            // 
            this.cmVFDVal.DataPropertyName = "VFDVal";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmVFDVal.DefaultCellStyle = dataGridViewCellStyle5;
            this.cmVFDVal.HeaderText = "VFD Value";
            this.cmVFDVal.Name = "cmVFDVal";
            this.cmVFDVal.ReadOnly = true;
            this.cmVFDVal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cmVFDVal.Width = 70;
            // 
            // btnReadVFDVals
            // 
            this.btnReadVFDVals.Enabled = false;
            this.btnReadVFDVals.Location = new System.Drawing.Point(647, 44);
            this.btnReadVFDVals.Name = "btnReadVFDVals";
            this.btnReadVFDVals.Size = new System.Drawing.Size(156, 23);
            this.btnReadVFDVals.TabIndex = 38;
            this.btnReadVFDVals.Text = "Read VFD Values";
            this.btnReadVFDVals.UseVisualStyleBackColor = true;
            this.btnReadVFDVals.Click += new System.EventHandler(this.btnReadVFDVals_Click);
            // 
            // bwrkReadVFDVals
            // 
            this.bwrkReadVFDVals.WorkerReportsProgress = true;
            this.bwrkReadVFDVals.WorkerSupportsCancellation = true;
            this.bwrkReadVFDVals.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwrkReadVFDVals_DoWork);
            this.bwrkReadVFDVals.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwrk_ProgressChanged);
            this.bwrkReadVFDVals.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwrkReadVFDVals_RunWorkerCompleted);
            // 
            // lblParamView
            // 
            this.lblParamView.AutoSize = true;
            this.lblParamView.Location = new System.Drawing.Point(16, 170);
            this.lblParamView.Name = "lblParamView";
            this.lblParamView.Size = new System.Drawing.Size(114, 13);
            this.lblParamView.TabIndex = 39;
            this.lblParamView.Text = "VFD Parameter Values";
            // 
            // grpInFileSettings
            // 
            this.grpInFileSettings.Controls.Add(this.btnVFDReset);
            this.grpInFileSettings.Controls.Add(this.btnReadParamList);
            this.grpInFileSettings.Controls.Add(this.txtParamListFile);
            this.grpInFileSettings.Controls.Add(this.btnBrowseParamList);
            this.grpInFileSettings.Controls.Add(this.lblParamListFile);
            this.grpInFileSettings.Controls.Add(this.btnReadVFDVals);
            this.grpInFileSettings.Location = new System.Drawing.Point(13, 72);
            this.grpInFileSettings.Name = "grpInFileSettings";
            this.grpInFileSettings.Size = new System.Drawing.Size(809, 80);
            this.grpInFileSettings.TabIndex = 45;
            this.grpInFileSettings.TabStop = false;
            this.grpInFileSettings.Text = "Paramet List File Settings";
            // 
            // btnVFDReset
            // 
            this.btnVFDReset.Location = new System.Drawing.Point(485, 43);
            this.btnVFDReset.Name = "btnVFDReset";
            this.btnVFDReset.Size = new System.Drawing.Size(156, 23);
            this.btnVFDReset.TabIndex = 39;
            this.btnVFDReset.Text = "Reset VFD to Default";
            this.btnVFDReset.UseVisualStyleBackColor = true;
            this.btnVFDReset.Click += new System.EventHandler(this.btnVFDReset_Click);
            // 
            // btnReadParamList
            // 
            this.btnReadParamList.Enabled = false;
            this.btnReadParamList.Location = new System.Drawing.Point(728, 15);
            this.btnReadParamList.Name = "btnReadParamList";
            this.btnReadParamList.Size = new System.Drawing.Size(75, 23);
            this.btnReadParamList.TabIndex = 6;
            this.btnReadParamList.Text = "Read File";
            this.btnReadParamList.UseVisualStyleBackColor = true;
            this.btnReadParamList.Click += new System.EventHandler(this.btnParamListRead_Click);
            // 
            // txtParamListFile
            // 
            this.txtParamListFile.Location = new System.Drawing.Point(145, 17);
            this.txtParamListFile.Name = "txtParamListFile";
            this.txtParamListFile.Size = new System.Drawing.Size(496, 20);
            this.txtParamListFile.TabIndex = 2;
            this.txtParamListFile.TextChanged += new System.EventHandler(this.txtParamListFile_TextChanged);
            // 
            // btnBrowseParamList
            // 
            this.btnBrowseParamList.Location = new System.Drawing.Point(647, 15);
            this.btnBrowseParamList.Name = "btnBrowseParamList";
            this.btnBrowseParamList.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseParamList.TabIndex = 1;
            this.btnBrowseParamList.Text = "Browse";
            this.btnBrowseParamList.UseVisualStyleBackColor = true;
            this.btnBrowseParamList.Click += new System.EventHandler(this.btnParamListBrowse_Click);
            // 
            // lblParamListFile
            // 
            this.lblParamListFile.AutoSize = true;
            this.lblParamListFile.Location = new System.Drawing.Point(9, 20);
            this.lblParamListFile.Name = "lblParamListFile";
            this.lblParamListFile.Size = new System.Drawing.Size(130, 13);
            this.lblParamListFile.TabIndex = 0;
            this.lblParamListFile.Text = "V1000 Parameter List File:";
            // 
            // btnBrowseDefValList
            // 
            this.btnBrowseDefValList.Location = new System.Drawing.Point(653, 22);
            this.btnBrowseDefValList.Name = "btnBrowseDefValList";
            this.btnBrowseDefValList.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDefValList.TabIndex = 4;
            this.btnBrowseDefValList.Text = "Browse";
            this.btnBrowseDefValList.UseVisualStyleBackColor = true;
            this.btnBrowseDefValList.Click += new System.EventHandler(this.btnDefSetBrowse_Click);
            // 
            // lblParamDefOutFile
            // 
            this.lblParamDefOutFile.AutoSize = true;
            this.lblParamDefOutFile.Location = new System.Drawing.Point(9, 28);
            this.lblParamDefOutFile.Name = "lblParamDefOutFile";
            this.lblParamDefOutFile.Size = new System.Drawing.Size(133, 13);
            this.lblParamDefOutFile.TabIndex = 3;
            this.lblParamDefOutFile.Text = "V1000 Default Setting File:";
            // 
            // opfdParamList
            // 
            this.opfdParamList.FileName = " ";
            this.opfdParamList.Filter = "Excel Workbook|*.xlsx|All Files|*.*";
            // 
            // svfdParamDefValFile
            // 
            this.svfdParamDefValFile.Filter = "Parameter Data Files|*.dat";
            // 
            // grpParamDefValFile
            // 
            this.grpParamDefValFile.Controls.Add(this.btnWriteDefValList);
            this.grpParamDefValFile.Controls.Add(this.lblParamDefOutFile);
            this.grpParamDefValFile.Controls.Add(this.btnBrowseDefValList);
            this.grpParamDefValFile.Controls.Add(this.txtParamDefOutFile);
            this.grpParamDefValFile.Enabled = false;
            this.grpParamDefValFile.Location = new System.Drawing.Point(7, 785);
            this.grpParamDefValFile.Name = "grpParamDefValFile";
            this.grpParamDefValFile.Size = new System.Drawing.Size(815, 62);
            this.grpParamDefValFile.TabIndex = 46;
            this.grpParamDefValFile.TabStop = false;
            this.grpParamDefValFile.Text = "Default Parameter Value File Settings";
            // 
            // btnWriteDefValList
            // 
            this.btnWriteDefValList.Enabled = false;
            this.btnWriteDefValList.Location = new System.Drawing.Point(734, 22);
            this.btnWriteDefValList.Name = "btnWriteDefValList";
            this.btnWriteDefValList.Size = new System.Drawing.Size(75, 23);
            this.btnWriteDefValList.TabIndex = 7;
            this.btnWriteDefValList.Text = "Write File";
            this.btnWriteDefValList.UseVisualStyleBackColor = true;
            this.btnWriteDefValList.Click += new System.EventHandler(this.btnWriteDefValFile_Click);
            // 
            // txtParamDefOutFile
            // 
            this.txtParamDefOutFile.Location = new System.Drawing.Point(148, 25);
            this.txtParamDefOutFile.Name = "txtParamDefOutFile";
            this.txtParamDefOutFile.Size = new System.Drawing.Size(499, 20);
            this.txtParamDefOutFile.TabIndex = 5;
            this.txtParamDefOutFile.TextChanged += new System.EventHandler(this.txtParamDefOutFile_TextChanged);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnBrowseParamList;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 861);
            this.Controls.Add(this.grpParamDefValFile);
            this.Controls.Add(this.grpInFileSettings);
            this.Controls.Add(this.lblParamView);
            this.Controls.Add(this.dgvV1000ParamView);
            this.Controls.Add(this.grpCommSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "V1000 Default Parameter Setting File Generator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpCommSettings.ResumeLayout(false);
            this.grpCommSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvV1000ParamView)).EndInit();
            this.grpInFileSettings.ResumeLayout(false);
            this.grpInFileSettings.PerformLayout();
            this.grpParamDefValFile.ResumeLayout(false);
            this.grpParamDefValFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSlaveAddr;
        private System.Windows.Forms.Label lblSlaveAddr;
        private System.Windows.Forms.GroupBox grpCommSettings;
        private System.Windows.Forms.Label lblSerialCommPort;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.IO.Ports.SerialPort spVFD;
        private System.ComponentModel.BackgroundWorker bwrkReadParamListFile;
        private System.ComponentModel.BackgroundWorker bwrkWriteDefValFile;
        private System.Windows.Forms.DataGridView dgvV1000ParamView;
        private System.Windows.Forms.Button btnReadVFDVals;
        private System.ComponentModel.BackgroundWorker bwrkReadVFDVals;
        private System.Windows.Forms.Label lblParamView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmRegAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmParamNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmParmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmDefVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmVFDVal;
        private System.Windows.Forms.GroupBox grpInFileSettings;
        private System.Windows.Forms.TextBox txtParamListFile;
        private System.Windows.Forms.Button btnBrowseParamList;
        private System.Windows.Forms.Label lblParamListFile;
        private System.Windows.Forms.Button btnBrowseDefValList;
        private System.Windows.Forms.Label lblParamDefOutFile;
        private System.Windows.Forms.OpenFileDialog opfdParamList;
        private System.Windows.Forms.SaveFileDialog svfdParamDefValFile;
        private System.Windows.Forms.GroupBox grpParamDefValFile;
        private System.Windows.Forms.Button btnReadParamList;
        private System.Windows.Forms.TextBox txtParamDefOutFile;
        private System.Windows.Forms.Button btnWriteDefValList;
        private System.Windows.Forms.Button btnVFDReset;
    }
}

