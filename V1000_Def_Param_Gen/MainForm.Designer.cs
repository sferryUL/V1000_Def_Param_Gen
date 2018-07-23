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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDataBuffer = new System.Windows.Forms.Label();
            this.txtDataBuffer = new System.Windows.Forms.TextBox();
            this.txtModCRC16Result = new System.Windows.Forms.TextBox();
            this.lblModCRC16Result = new System.Windows.Forms.Label();
            this.txtModCRC16Upper = new System.Windows.Forms.TextBox();
            this.lblModCRC16Upper = new System.Windows.Forms.Label();
            this.txtModCRC16Lower = new System.Windows.Forms.TextBox();
            this.lblModCRC16Lower = new System.Windows.Forms.Label();
            this.btnCreateModbusRTUMsg = new System.Windows.Forms.Button();
            this.btnClearMsgData = new System.Windows.Forms.Button();
            this.txtBuffSize = new System.Windows.Forms.TextBox();
            this.lblBuffSize = new System.Windows.Forms.Label();
            this.txtDataBuffComplete = new System.Windows.Forms.TextBox();
            this.lblDataBuffComplete = new System.Windows.Forms.Label();
            this.txtSlaveAddr = new System.Windows.Forms.TextBox();
            this.lblSlaveAddr = new System.Windows.Forms.Label();
            this.lblFuncCode = new System.Windows.Forms.Label();
            this.cmbFuncCode = new System.Windows.Forms.ComboBox();
            this.txtRegCnt = new System.Windows.Forms.TextBox();
            this.lblRegCnt = new System.Windows.Forms.Label();
            this.txtRegSize = new System.Windows.Forms.TextBox();
            this.lblRegSize = new System.Windows.Forms.Label();
            this.txtStartReg = new System.Windows.Forms.TextBox();
            this.lblStartReg = new System.Windows.Forms.Label();
            this.btnTransmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpCommSettings = new System.Windows.Forms.GroupBox();
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.lblSerialCommPort = new System.Windows.Forms.Label();
            this.spVFD = new System.IO.Ports.SerialPort(this.components);
            this.lbVFDResponse = new System.Windows.Forms.ListBox();
            this.ctxtListVFDResponse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblVFDResponseRaw = new System.Windows.Forms.Label();
            this.lblVFDResponse = new System.Windows.Forms.Label();
            this.dgvVFDResponse = new System.Windows.Forms.DataGridView();
            this.cmSlaveAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmFuncCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmStartReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmRegCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReadExcel = new System.Windows.Forms.Button();
            this.bwrkReadExcelFile = new System.ComponentModel.BackgroundWorker();
            this.btnReadVFDDefs = new System.Windows.Forms.Button();
            this.bwrkReadVFDDefs = new System.ComponentModel.BackgroundWorker();
            this.btnWriteExcel = new System.Windows.Forms.Button();
            this.bwrkWriteExcelFile = new System.ComponentModel.BackgroundWorker();
            this.dgvVFDParamView = new System.Windows.Forms.DataGridView();
            this.cmRegAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmParamNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmParmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmDefVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmVFDVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statProgLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.bwrkLoadVFDDefs = new System.ComponentModel.BackgroundWorker();
            this.btnReadVFD = new System.Windows.Forms.Button();
            this.bwrkReadVFDVals = new System.ComponentModel.BackgroundWorker();
            this.lblParamView = new System.Windows.Forms.Label();
            this.dgvVFDSchedParamChange = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVFDModifiedParams = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVFDModifiedParams = new System.Windows.Forms.Label();
            this.lblVFDParamsToChange = new System.Windows.Forms.Label();
            this.btnModVFD = new System.Windows.Forms.Button();
            this.bwrkModVFD = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpCommSettings.SuspendLayout();
            this.ctxtListVFDResponse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVFDResponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVFDParamView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVFDSchedParamChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVFDModifiedParams)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataBuffer
            // 
            this.lblDataBuffer.AutoSize = true;
            this.lblDataBuffer.Location = new System.Drawing.Point(30, 84);
            this.lblDataBuffer.Name = "lblDataBuffer";
            this.lblDataBuffer.Size = new System.Drawing.Size(90, 13);
            this.lblDataBuffer.TabIndex = 0;
            this.lblDataBuffer.Text = "Data Buffer (hex):";
            this.lblDataBuffer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDataBuffer
            // 
            this.txtDataBuffer.Location = new System.Drawing.Point(126, 81);
            this.txtDataBuffer.Name = "txtDataBuffer";
            this.txtDataBuffer.Size = new System.Drawing.Size(278, 20);
            this.txtDataBuffer.TabIndex = 4;
            // 
            // txtModCRC16Result
            // 
            this.txtModCRC16Result.Location = new System.Drawing.Point(156, 22);
            this.txtModCRC16Result.Name = "txtModCRC16Result";
            this.txtModCRC16Result.ReadOnly = true;
            this.txtModCRC16Result.Size = new System.Drawing.Size(75, 20);
            this.txtModCRC16Result.TabIndex = 3;
            this.txtModCRC16Result.TabStop = false;
            // 
            // lblModCRC16Result
            // 
            this.lblModCRC16Result.AutoSize = true;
            this.lblModCRC16Result.Location = new System.Drawing.Point(29, 25);
            this.lblModCRC16Result.Name = "lblModCRC16Result";
            this.lblModCRC16Result.Size = new System.Drawing.Size(121, 13);
            this.lblModCRC16Result.TabIndex = 2;
            this.lblModCRC16Result.Text = "Modbus CRC-16 Result:";
            this.lblModCRC16Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModCRC16Upper
            // 
            this.txtModCRC16Upper.Location = new System.Drawing.Point(156, 48);
            this.txtModCRC16Upper.Name = "txtModCRC16Upper";
            this.txtModCRC16Upper.ReadOnly = true;
            this.txtModCRC16Upper.Size = new System.Drawing.Size(75, 20);
            this.txtModCRC16Upper.TabIndex = 5;
            this.txtModCRC16Upper.TabStop = false;
            // 
            // lblModCRC16Upper
            // 
            this.lblModCRC16Upper.AutoSize = true;
            this.lblModCRC16Upper.Location = new System.Drawing.Point(6, 51);
            this.lblModCRC16Upper.Name = "lblModCRC16Upper";
            this.lblModCRC16Upper.Size = new System.Drawing.Size(144, 13);
            this.lblModCRC16Upper.TabIndex = 4;
            this.lblModCRC16Upper.Text = "Modbus CRC-16 Upper Byte:";
            this.lblModCRC16Upper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModCRC16Lower
            // 
            this.txtModCRC16Lower.Location = new System.Drawing.Point(156, 74);
            this.txtModCRC16Lower.Name = "txtModCRC16Lower";
            this.txtModCRC16Lower.ReadOnly = true;
            this.txtModCRC16Lower.Size = new System.Drawing.Size(75, 20);
            this.txtModCRC16Lower.TabIndex = 7;
            this.txtModCRC16Lower.TabStop = false;
            // 
            // lblModCRC16Lower
            // 
            this.lblModCRC16Lower.AutoSize = true;
            this.lblModCRC16Lower.Location = new System.Drawing.Point(6, 77);
            this.lblModCRC16Lower.Name = "lblModCRC16Lower";
            this.lblModCRC16Lower.Size = new System.Drawing.Size(144, 13);
            this.lblModCRC16Lower.TabIndex = 6;
            this.lblModCRC16Lower.Text = "Modbus CRC-16 Lower Byte:";
            this.lblModCRC16Lower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCreateModbusRTUMsg
            // 
            this.btnCreateModbusRTUMsg.Location = new System.Drawing.Point(417, 223);
            this.btnCreateModbusRTUMsg.Name = "btnCreateModbusRTUMsg";
            this.btnCreateModbusRTUMsg.Size = new System.Drawing.Size(175, 23);
            this.btnCreateModbusRTUMsg.TabIndex = 5;
            this.btnCreateModbusRTUMsg.Text = "Create Modbus RTU Message";
            this.btnCreateModbusRTUMsg.UseVisualStyleBackColor = true;
            this.btnCreateModbusRTUMsg.Click += new System.EventHandler(this.btnCreateModbusRTUMsg_Click);
            // 
            // btnClearMsgData
            // 
            this.btnClearMsgData.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearMsgData.Location = new System.Drawing.Point(417, 275);
            this.btnClearMsgData.Name = "btnClearMsgData";
            this.btnClearMsgData.Size = new System.Drawing.Size(175, 23);
            this.btnClearMsgData.TabIndex = 7;
            this.btnClearMsgData.Text = "Clear Message Data";
            this.btnClearMsgData.UseVisualStyleBackColor = true;
            this.btnClearMsgData.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtBuffSize
            // 
            this.txtBuffSize.Location = new System.Drawing.Point(537, 81);
            this.txtBuffSize.Name = "txtBuffSize";
            this.txtBuffSize.ReadOnly = true;
            this.txtBuffSize.Size = new System.Drawing.Size(38, 20);
            this.txtBuffSize.TabIndex = 11;
            this.txtBuffSize.TabStop = false;
            // 
            // lblBuffSize
            // 
            this.lblBuffSize.AutoSize = true;
            this.lblBuffSize.Location = new System.Drawing.Point(410, 84);
            this.lblBuffSize.Name = "lblBuffSize";
            this.lblBuffSize.Size = new System.Drawing.Size(121, 13);
            this.lblBuffSize.TabIndex = 10;
            this.lblBuffSize.Text = "Data Buffer Size (bytes):";
            this.lblBuffSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDataBuffComplete
            // 
            this.txtDataBuffComplete.Location = new System.Drawing.Point(180, 317);
            this.txtDataBuffComplete.Name = "txtDataBuffComplete";
            this.txtDataBuffComplete.ReadOnly = true;
            this.txtDataBuffComplete.Size = new System.Drawing.Size(412, 20);
            this.txtDataBuffComplete.TabIndex = 13;
            this.txtDataBuffComplete.TabStop = false;
            // 
            // lblDataBuffComplete
            // 
            this.lblDataBuffComplete.AutoSize = true;
            this.lblDataBuffComplete.Location = new System.Drawing.Point(9, 320);
            this.lblDataBuffComplete.Name = "lblDataBuffComplete";
            this.lblDataBuffComplete.Size = new System.Drawing.Size(165, 13);
            this.lblDataBuffComplete.TabIndex = 12;
            this.lblDataBuffComplete.Text = "Full Modbus RTU Message (hex):";
            this.lblDataBuffComplete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSlaveAddr
            // 
            this.txtSlaveAddr.Location = new System.Drawing.Point(126, 22);
            this.txtSlaveAddr.Name = "txtSlaveAddr";
            this.txtSlaveAddr.Size = new System.Drawing.Size(46, 20);
            this.txtSlaveAddr.TabIndex = 0;
            this.txtSlaveAddr.Text = "1F";
            // 
            // lblSlaveAddr
            // 
            this.lblSlaveAddr.AutoSize = true;
            this.lblSlaveAddr.Location = new System.Drawing.Point(16, 25);
            this.lblSlaveAddr.Name = "lblSlaveAddr";
            this.lblSlaveAddr.Size = new System.Drawing.Size(104, 13);
            this.lblSlaveAddr.TabIndex = 14;
            this.lblSlaveAddr.Text = "Slave Address (hex):";
            this.lblSlaveAddr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuncCode
            // 
            this.lblFuncCode.AutoSize = true;
            this.lblFuncCode.Location = new System.Drawing.Point(335, 25);
            this.lblFuncCode.Name = "lblFuncCode";
            this.lblFuncCode.Size = new System.Drawing.Size(79, 13);
            this.lblFuncCode.TabIndex = 16;
            this.lblFuncCode.Text = "Function Code:";
            this.lblFuncCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbFuncCode
            // 
            this.cmbFuncCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncCode.FormattingEnabled = true;
            this.cmbFuncCode.Items.AddRange(new object[] {
            "0x03 - Read Registers",
            "0x08 - Loopback Test",
            "0x10 - Write Registers"});
            this.cmbFuncCode.Location = new System.Drawing.Point(420, 22);
            this.cmbFuncCode.Name = "cmbFuncCode";
            this.cmbFuncCode.Size = new System.Drawing.Size(155, 21);
            this.cmbFuncCode.TabIndex = 1;
            // 
            // txtRegCnt
            // 
            this.txtRegCnt.Location = new System.Drawing.Point(322, 50);
            this.txtRegCnt.Name = "txtRegCnt";
            this.txtRegCnt.Size = new System.Drawing.Size(46, 20);
            this.txtRegCnt.TabIndex = 3;
            // 
            // lblRegCnt
            // 
            this.lblRegCnt.AutoSize = true;
            this.lblRegCnt.Location = new System.Drawing.Point(236, 53);
            this.lblRegCnt.Name = "lblRegCnt";
            this.lblRegCnt.Size = new System.Drawing.Size(80, 13);
            this.lblRegCnt.TabIndex = 18;
            this.lblRegCnt.Text = "Register Count:";
            this.lblRegCnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRegSize
            // 
            this.txtRegSize.Location = new System.Drawing.Point(529, 50);
            this.txtRegSize.Name = "txtRegSize";
            this.txtRegSize.ReadOnly = true;
            this.txtRegSize.Size = new System.Drawing.Size(46, 20);
            this.txtRegSize.TabIndex = 99;
            this.txtRegSize.TabStop = false;
            this.txtRegSize.Text = "2";
            // 
            // lblRegSize
            // 
            this.lblRegSize.AutoSize = true;
            this.lblRegSize.Location = new System.Drawing.Point(417, 53);
            this.lblRegSize.Name = "lblRegSize";
            this.lblRegSize.Size = new System.Drawing.Size(106, 13);
            this.lblRegSize.TabIndex = 20;
            this.lblRegSize.Text = "Register Size (bytes):";
            this.lblRegSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStartReg
            // 
            this.txtStartReg.Location = new System.Drawing.Point(126, 50);
            this.txtStartReg.Name = "txtStartReg";
            this.txtStartReg.Size = new System.Drawing.Size(46, 20);
            this.txtStartReg.TabIndex = 2;
            // 
            // lblStartReg
            // 
            this.lblStartReg.AutoSize = true;
            this.lblStartReg.Location = new System.Drawing.Point(6, 53);
            this.lblStartReg.Name = "lblStartReg";
            this.lblStartReg.Size = new System.Drawing.Size(114, 13);
            this.lblStartReg.TabIndex = 22;
            this.lblStartReg.Text = "Starting Register (hex):";
            this.lblStartReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTransmit
            // 
            this.btnTransmit.Location = new System.Drawing.Point(417, 248);
            this.btnTransmit.Name = "btnTransmit";
            this.btnTransmit.Size = new System.Drawing.Size(175, 23);
            this.btnTransmit.TabIndex = 6;
            this.btnTransmit.Text = "Transmit Message";
            this.btnTransmit.UseVisualStyleBackColor = true;
            this.btnTransmit.Click += new System.EventHandler(this.btnTransmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtModCRC16Result);
            this.groupBox1.Controls.Add(this.lblModCRC16Result);
            this.groupBox1.Controls.Add(this.lblModCRC16Upper);
            this.groupBox1.Controls.Add(this.txtModCRC16Upper);
            this.groupBox1.Controls.Add(this.lblModCRC16Lower);
            this.groupBox1.Controls.Add(this.txtModCRC16Lower);
            this.groupBox1.Location = new System.Drawing.Point(12, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 108);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modbus CRC-16 Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSlaveAddr);
            this.groupBox2.Controls.Add(this.txtSlaveAddr);
            this.groupBox2.Controls.Add(this.lblStartReg);
            this.groupBox2.Controls.Add(this.txtStartReg);
            this.groupBox2.Controls.Add(this.txtRegSize);
            this.groupBox2.Controls.Add(this.lblRegCnt);
            this.groupBox2.Controls.Add(this.txtBuffSize);
            this.groupBox2.Controls.Add(this.lblBuffSize);
            this.groupBox2.Controls.Add(this.lblRegSize);
            this.groupBox2.Controls.Add(this.txtRegCnt);
            this.groupBox2.Controls.Add(this.cmbFuncCode);
            this.groupBox2.Controls.Add(this.lblFuncCode);
            this.groupBox2.Controls.Add(this.txtDataBuffer);
            this.groupBox2.Controls.Add(this.lblDataBuffer);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 113);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modbus RTU Message Data";
            // 
            // grpCommSettings
            // 
            this.grpCommSettings.Controls.Add(this.cmbSerialPort);
            this.grpCommSettings.Controls.Add(this.lblSerialCommPort);
            this.grpCommSettings.Location = new System.Drawing.Point(13, 13);
            this.grpCommSettings.Name = "grpCommSettings";
            this.grpCommSettings.Size = new System.Drawing.Size(580, 53);
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
            this.cmbSerialPort.Size = new System.Drawing.Size(85, 21);
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
            // lbVFDResponse
            // 
            this.lbVFDResponse.ContextMenuStrip = this.ctxtListVFDResponse;
            this.lbVFDResponse.FormattingEnabled = true;
            this.lbVFDResponse.Location = new System.Drawing.Point(12, 368);
            this.lbVFDResponse.Name = "lbVFDResponse";
            this.lbVFDResponse.Size = new System.Drawing.Size(581, 69);
            this.lbVFDResponse.TabIndex = 28;
            this.lbVFDResponse.TabStop = false;
            // 
            // ctxtListVFDResponse
            // 
            this.ctxtListVFDResponse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.ctxtListVFDResponse.Name = "ctxtListVFDResponse";
            this.ctxtListVFDResponse.Size = new System.Drawing.Size(102, 26);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // lblVFDResponseRaw
            // 
            this.lblVFDResponseRaw.AutoSize = true;
            this.lblVFDResponseRaw.Location = new System.Drawing.Point(9, 352);
            this.lblVFDResponseRaw.Name = "lblVFDResponseRaw";
            this.lblVFDResponseRaw.Size = new System.Drawing.Size(174, 13);
            this.lblVFDResponseRaw.TabIndex = 29;
            this.lblVFDResponseRaw.Text = "VFD Response History (Raw Data):";
            // 
            // lblVFDResponse
            // 
            this.lblVFDResponse.AutoSize = true;
            this.lblVFDResponse.Location = new System.Drawing.Point(9, 453);
            this.lblVFDResponse.Name = "lblVFDResponse";
            this.lblVFDResponse.Size = new System.Drawing.Size(117, 13);
            this.lblVFDResponse.TabIndex = 30;
            this.lblVFDResponse.Text = "VFD Response History:";
            // 
            // dgvVFDResponse
            // 
            this.dgvVFDResponse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVFDResponse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmSlaveAddr,
            this.cmFuncCode,
            this.cmStartReg,
            this.cmRegCount,
            this.cmData});
            this.dgvVFDResponse.ContextMenuStrip = this.ctxtListVFDResponse;
            this.dgvVFDResponse.Location = new System.Drawing.Point(11, 469);
            this.dgvVFDResponse.MultiSelect = false;
            this.dgvVFDResponse.Name = "dgvVFDResponse";
            this.dgvVFDResponse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVFDResponse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVFDResponse.Size = new System.Drawing.Size(581, 129);
            this.dgvVFDResponse.TabIndex = 32;
            // 
            // cmSlaveAddr
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cmSlaveAddr.DefaultCellStyle = dataGridViewCellStyle1;
            this.cmSlaveAddr.HeaderText = "Slave Address";
            this.cmSlaveAddr.Name = "cmSlaveAddr";
            this.cmSlaveAddr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cmSlaveAddr.Width = 50;
            // 
            // cmFuncCode
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cmFuncCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.cmFuncCode.HeaderText = "Function Code";
            this.cmFuncCode.Name = "cmFuncCode";
            this.cmFuncCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cmFuncCode.Width = 50;
            // 
            // cmStartReg
            // 
            this.cmStartReg.HeaderText = "Start Register";
            this.cmStartReg.Name = "cmStartReg";
            this.cmStartReg.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cmRegCount
            // 
            this.cmRegCount.HeaderText = "Register Count";
            this.cmRegCount.Name = "cmRegCount";
            this.cmRegCount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cmRegCount.Width = 50;
            // 
            // cmData
            // 
            this.cmData.HeaderText = "Data";
            this.cmData.Name = "cmData";
            this.cmData.Width = 285;
            // 
            // btnReadExcel
            // 
            this.btnReadExcel.Enabled = false;
            this.btnReadExcel.Location = new System.Drawing.Point(264, 223);
            this.btnReadExcel.Name = "btnReadExcel";
            this.btnReadExcel.Size = new System.Drawing.Size(147, 23);
            this.btnReadExcel.TabIndex = 33;
            this.btnReadExcel.Text = "Read Excel File";
            this.btnReadExcel.UseVisualStyleBackColor = true;
            this.btnReadExcel.Click += new System.EventHandler(this.btnReadExcel_Click);
            // 
            // bwrkReadExcelFile
            // 
            this.bwrkReadExcelFile.WorkerReportsProgress = true;
            this.bwrkReadExcelFile.WorkerSupportsCancellation = true;
            this.bwrkReadExcelFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwrkReadExcelFile_DoWork);
            this.bwrkReadExcelFile.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwrk_ProgressChanged);
            this.bwrkReadExcelFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwrk_ProgressComplete);
            // 
            // btnReadVFDDefs
            // 
            this.btnReadVFDDefs.Enabled = false;
            this.btnReadVFDDefs.Location = new System.Drawing.Point(264, 248);
            this.btnReadVFDDefs.Name = "btnReadVFDDefs";
            this.btnReadVFDDefs.Size = new System.Drawing.Size(147, 23);
            this.btnReadVFDDefs.TabIndex = 34;
            this.btnReadVFDDefs.Text = "Read VFD Defaults";
            this.btnReadVFDDefs.UseVisualStyleBackColor = true;
            this.btnReadVFDDefs.Click += new System.EventHandler(this.btnReadVFDDefs_Click);
            // 
            // bwrkReadVFDDefs
            // 
            this.bwrkReadVFDDefs.WorkerReportsProgress = true;
            this.bwrkReadVFDDefs.WorkerSupportsCancellation = true;
            this.bwrkReadVFDDefs.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwrkReadVFDDefs_DoWork);
            this.bwrkReadVFDDefs.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwrk_ProgressChanged);
            this.bwrkReadVFDDefs.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwrk_ProgressComplete);
            // 
            // btnWriteExcel
            // 
            this.btnWriteExcel.Enabled = false;
            this.btnWriteExcel.Location = new System.Drawing.Point(264, 275);
            this.btnWriteExcel.Name = "btnWriteExcel";
            this.btnWriteExcel.Size = new System.Drawing.Size(147, 23);
            this.btnWriteExcel.TabIndex = 35;
            this.btnWriteExcel.Text = "Write Excel File";
            this.btnWriteExcel.UseVisualStyleBackColor = true;
            this.btnWriteExcel.Click += new System.EventHandler(this.btnWriteExcel_Click);
            // 
            // bwrkWriteExcelFile
            // 
            this.bwrkWriteExcelFile.WorkerReportsProgress = true;
            this.bwrkWriteExcelFile.WorkerSupportsCancellation = true;
            this.bwrkWriteExcelFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwrkWriteExcelFile_DoWork);
            this.bwrkWriteExcelFile.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwrk_ProgressChanged);
            this.bwrkWriteExcelFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwrk_ProgressComplete);
            // 
            // dgvVFDParamView
            // 
            this.dgvVFDParamView.AllowUserToAddRows = false;
            this.dgvVFDParamView.AllowUserToDeleteRows = false;
            this.dgvVFDParamView.AllowUserToResizeColumns = false;
            this.dgvVFDParamView.AllowUserToResizeRows = false;
            this.dgvVFDParamView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVFDParamView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmRegAddr,
            this.cmParamNum,
            this.cmParmName,
            this.cmDefVal,
            this.cmVFDVal});
            this.dgvVFDParamView.Location = new System.Drawing.Point(599, 37);
            this.dgvVFDParamView.Name = "dgvVFDParamView";
            this.dgvVFDParamView.Size = new System.Drawing.Size(695, 234);
            this.dgvVFDParamView.TabIndex = 36;
            this.dgvVFDParamView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVFDParamView_CellEndEdit);
            // 
            // cmRegAddr
            // 
            this.cmRegAddr.DataPropertyName = "RegAddress";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmRegAddr.DefaultCellStyle = dataGridViewCellStyle3;
            this.cmRegAddr.HeaderText = "Parameter Address";
            this.cmRegAddr.Name = "cmRegAddr";
            this.cmRegAddr.ReadOnly = true;
            this.cmRegAddr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cmRegAddr.Width = 60;
            // 
            // cmParamNum
            // 
            this.cmParamNum.DataPropertyName = "ParamNum";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmParamNum.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cmParmName.DefaultCellStyle = dataGridViewCellStyle5;
            this.cmParmName.HeaderText = "Parameter Name";
            this.cmParmName.Name = "cmParmName";
            this.cmParmName.ReadOnly = true;
            // 
            // cmDefVal
            // 
            this.cmDefVal.DataPropertyName = "DefVal";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmDefVal.DefaultCellStyle = dataGridViewCellStyle6;
            this.cmDefVal.HeaderText = "Default Value";
            this.cmDefVal.Name = "cmDefVal";
            this.cmDefVal.ReadOnly = true;
            this.cmDefVal.Width = 70;
            // 
            // cmVFDVal
            // 
            this.cmVFDVal.DataPropertyName = "VFDVal";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cmVFDVal.DefaultCellStyle = dataGridViewCellStyle7;
            this.cmVFDVal.HeaderText = "VFD Value";
            this.cmVFDVal.Name = "cmVFDVal";
            this.cmVFDVal.ReadOnly = true;
            this.cmVFDVal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cmVFDVal.Width = 70;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statProgLabel,
            this.statProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 614);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1477, 22);
            this.statusStrip1.TabIndex = 37;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statProgLabel
            // 
            this.statProgLabel.Name = "statProgLabel";
            this.statProgLabel.Size = new System.Drawing.Size(162, 17);
            this.statProgLabel.Text = "Parameter List Load Progress:";
            this.statProgLabel.Visible = false;
            // 
            // statProgress
            // 
            this.statProgress.Name = "statProgress";
            this.statProgress.Size = new System.Drawing.Size(900, 16);
            this.statProgress.Visible = false;
            // 
            // bwrkLoadVFDDefs
            // 
            this.bwrkLoadVFDDefs.WorkerReportsProgress = true;
            this.bwrkLoadVFDDefs.WorkerSupportsCancellation = true;
            this.bwrkLoadVFDDefs.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwrkLoadVFDDefs_DoWork);
            this.bwrkLoadVFDDefs.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwrkDGV_ProgressChanged);
            this.bwrkLoadVFDDefs.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwrkLoadVFDDefs_RunWorkerCompleted);
            // 
            // btnReadVFD
            // 
            this.btnReadVFD.Enabled = false;
            this.btnReadVFD.Location = new System.Drawing.Point(1300, 37);
            this.btnReadVFD.Name = "btnReadVFD";
            this.btnReadVFD.Size = new System.Drawing.Size(165, 23);
            this.btnReadVFD.TabIndex = 38;
            this.btnReadVFD.Text = "Read VFD Parameter Settings";
            this.btnReadVFD.UseVisualStyleBackColor = true;
            this.btnReadVFD.Click += new System.EventHandler(this.btnReadVFD_Click);
            // 
            // bwrkReadVFDVals
            // 
            this.bwrkReadVFDVals.WorkerReportsProgress = true;
            this.bwrkReadVFDVals.WorkerSupportsCancellation = true;
            this.bwrkReadVFDVals.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwrkReadVFDVals_DoWork);
            this.bwrkReadVFDVals.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwrkDGV_ProgressChanged);
            this.bwrkReadVFDVals.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwrkReadVFDVals_RunWorkerCompleted);
            // 
            // lblParamView
            // 
            this.lblParamView.AutoSize = true;
            this.lblParamView.Location = new System.Drawing.Point(599, 18);
            this.lblParamView.Name = "lblParamView";
            this.lblParamView.Size = new System.Drawing.Size(114, 13);
            this.lblParamView.TabIndex = 39;
            this.lblParamView.Text = "VFD Parameter Values";
            // 
            // dgvVFDSchedParamChange
            // 
            this.dgvVFDSchedParamChange.AllowUserToAddRows = false;
            this.dgvVFDSchedParamChange.AllowUserToDeleteRows = false;
            this.dgvVFDSchedParamChange.AllowUserToResizeColumns = false;
            this.dgvVFDSchedParamChange.AllowUserToResizeRows = false;
            this.dgvVFDSchedParamChange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVFDSchedParamChange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvVFDSchedParamChange.Location = new System.Drawing.Point(598, 295);
            this.dgvVFDSchedParamChange.Name = "dgvVFDSchedParamChange";
            this.dgvVFDSchedParamChange.Size = new System.Drawing.Size(695, 142);
            this.dgvVFDSchedParamChange.TabIndex = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RegAddress";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn1.HeaderText = "Parameter Address";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ParamNum";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn2.HeaderText = "Parameter Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ParamName";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn3.HeaderText = "Parameter Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DefVal";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn4.HeaderText = "Default Value";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "VFDVal";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn5.HeaderText = "VFD Value";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dgvVFDModifiedParams
            // 
            this.dgvVFDModifiedParams.AllowUserToAddRows = false;
            this.dgvVFDModifiedParams.AllowUserToDeleteRows = false;
            this.dgvVFDModifiedParams.AllowUserToResizeColumns = false;
            this.dgvVFDModifiedParams.AllowUserToResizeRows = false;
            this.dgvVFDModifiedParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVFDModifiedParams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvVFDModifiedParams.Location = new System.Drawing.Point(599, 469);
            this.dgvVFDModifiedParams.Name = "dgvVFDModifiedParams";
            this.dgvVFDModifiedParams.Size = new System.Drawing.Size(695, 129);
            this.dgvVFDModifiedParams.TabIndex = 41;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RegAddress";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn6.HeaderText = "Parameter Address";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ParamNum";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn7.HeaderText = "Parameter Number";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.Width = 60;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ParamName";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn8.HeaderText = "Parameter Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DefVal";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn9.HeaderText = "Default Value";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 70;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "VFDVal";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn10.HeaderText = "VFD Value";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn10.Width = 70;
            // 
            // lblVFDModifiedParams
            // 
            this.lblVFDModifiedParams.AutoSize = true;
            this.lblVFDModifiedParams.Location = new System.Drawing.Point(600, 453);
            this.lblVFDModifiedParams.Name = "lblVFDModifiedParams";
            this.lblVFDModifiedParams.Size = new System.Drawing.Size(127, 13);
            this.lblVFDModifiedParams.TabIndex = 42;
            this.lblVFDModifiedParams.Text = "VFD Modified Parameters";
            // 
            // lblVFDParamsToChange
            // 
            this.lblVFDParamsToChange.AutoSize = true;
            this.lblVFDParamsToChange.Location = new System.Drawing.Point(599, 279);
            this.lblVFDParamsToChange.Name = "lblVFDParamsToChange";
            this.lblVFDParamsToChange.Size = new System.Drawing.Size(181, 13);
            this.lblVFDParamsToChange.TabIndex = 43;
            this.lblVFDParamsToChange.Text = "VFD Scheduled Parameter Changes:";
            // 
            // btnModVFD
            // 
            this.btnModVFD.Enabled = false;
            this.btnModVFD.Location = new System.Drawing.Point(1300, 295);
            this.btnModVFD.Name = "btnModVFD";
            this.btnModVFD.Size = new System.Drawing.Size(165, 23);
            this.btnModVFD.TabIndex = 44;
            this.btnModVFD.Text = "Modify VFD Parameters";
            this.btnModVFD.UseVisualStyleBackColor = true;
            this.btnModVFD.Click += new System.EventHandler(this.btnModVFD_Click);
            // 
            // bwrkModVFD
            // 
            this.bwrkModVFD.WorkerReportsProgress = true;
            this.bwrkModVFD.WorkerSupportsCancellation = true;
            this.bwrkModVFD.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwrkModVFD_DoWork);
            this.bwrkModVFD.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwrkDGV_ProgressChanged);
            this.bwrkModVFD.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwrkModVFD_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCreateModbusRTUMsg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClearMsgData;
            this.ClientSize = new System.Drawing.Size(1477, 636);
            this.Controls.Add(this.btnModVFD);
            this.Controls.Add(this.lblVFDParamsToChange);
            this.Controls.Add(this.lblVFDModifiedParams);
            this.Controls.Add(this.dgvVFDModifiedParams);
            this.Controls.Add(this.dgvVFDSchedParamChange);
            this.Controls.Add(this.lblParamView);
            this.Controls.Add(this.btnReadVFD);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvVFDParamView);
            this.Controls.Add(this.btnWriteExcel);
            this.Controls.Add(this.btnReadVFDDefs);
            this.Controls.Add(this.btnReadExcel);
            this.Controls.Add(this.dgvVFDResponse);
            this.Controls.Add(this.lblVFDResponse);
            this.Controls.Add(this.lblVFDResponseRaw);
            this.Controls.Add(this.lbVFDResponse);
            this.Controls.Add(this.grpCommSettings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTransmit);
            this.Controls.Add(this.txtDataBuffComplete);
            this.Controls.Add(this.lblDataBuffComplete);
            this.Controls.Add(this.btnClearMsgData);
            this.Controls.Add(this.btnCreateModbusRTUMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "Modbus RTU Message Creator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpCommSettings.ResumeLayout(false);
            this.grpCommSettings.PerformLayout();
            this.ctxtListVFDResponse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVFDResponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVFDParamView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVFDSchedParamChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVFDModifiedParams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataBuffer;
        private System.Windows.Forms.TextBox txtDataBuffer;
        private System.Windows.Forms.TextBox txtModCRC16Result;
        private System.Windows.Forms.Label lblModCRC16Result;
        private System.Windows.Forms.TextBox txtModCRC16Upper;
        private System.Windows.Forms.Label lblModCRC16Upper;
        private System.Windows.Forms.TextBox txtModCRC16Lower;
        private System.Windows.Forms.Label lblModCRC16Lower;
        private System.Windows.Forms.Button btnCreateModbusRTUMsg;
        private System.Windows.Forms.Button btnClearMsgData;
        private System.Windows.Forms.TextBox txtBuffSize;
        private System.Windows.Forms.Label lblBuffSize;
        private System.Windows.Forms.TextBox txtDataBuffComplete;
        private System.Windows.Forms.Label lblDataBuffComplete;
        private System.Windows.Forms.TextBox txtSlaveAddr;
        private System.Windows.Forms.Label lblSlaveAddr;
        private System.Windows.Forms.Label lblFuncCode;
        private System.Windows.Forms.ComboBox cmbFuncCode;
        private System.Windows.Forms.TextBox txtRegCnt;
        private System.Windows.Forms.Label lblRegCnt;
        private System.Windows.Forms.TextBox txtRegSize;
        private System.Windows.Forms.Label lblRegSize;
        private System.Windows.Forms.TextBox txtStartReg;
        private System.Windows.Forms.Label lblStartReg;
        private System.Windows.Forms.Button btnTransmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpCommSettings;
        private System.Windows.Forms.Label lblSerialCommPort;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.IO.Ports.SerialPort spVFD;
        private System.Windows.Forms.ListBox lbVFDResponse;
        private System.Windows.Forms.Label lblVFDResponseRaw;
        private System.Windows.Forms.ContextMenuStrip ctxtListVFDResponse;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Label lblVFDResponse;
        private System.Windows.Forms.DataGridView dgvVFDResponse;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmSlaveAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmFuncCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmStartReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmRegCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmData;
        private System.Windows.Forms.Button btnReadExcel;
        private System.ComponentModel.BackgroundWorker bwrkReadExcelFile;
        private System.Windows.Forms.Button btnReadVFDDefs;
        private System.ComponentModel.BackgroundWorker bwrkReadVFDDefs;
        private System.Windows.Forms.Button btnWriteExcel;
        private System.ComponentModel.BackgroundWorker bwrkWriteExcelFile;
        private System.Windows.Forms.DataGridView dgvVFDParamView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statProgLabel;
        private System.Windows.Forms.ToolStripProgressBar statProgress;
        private System.ComponentModel.BackgroundWorker bwrkLoadVFDDefs;
        private System.Windows.Forms.Button btnReadVFD;
        private System.ComponentModel.BackgroundWorker bwrkReadVFDVals;
        private System.Windows.Forms.Label lblParamView;
        private System.Windows.Forms.DataGridView dgvVFDSchedParamChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView dgvVFDModifiedParams;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label lblVFDModifiedParams;
        private System.Windows.Forms.Label lblVFDParamsToChange;
        private System.Windows.Forms.Button btnModVFD;
        private System.ComponentModel.BackgroundWorker bwrkModVFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmRegAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmParamNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmParmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmDefVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmVFDVal;
    }
}

