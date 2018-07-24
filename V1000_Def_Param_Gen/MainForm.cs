using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModbusRTU;
using V1000_Def_Param_Gen;
using System.Runtime.InteropServices;
using XL = Microsoft.Office.Interop.Excel;
using V1000_ModbusRTU;

namespace V1000_Def_Param_Gen
{
    public partial class frmMain : Form
    {
        #region global class object definitions
        // Create field for storing the VFD slave address setting
        byte SlaveAddress = 0xFF;

        // Create Excel file data read objects
        XL.Application xlApp;
        XL.Workbook xlWorkbook;
        XL._Worksheet xlWorksheet;
        XL.Range xlRange;
        String ParamListFile;
        String ParamDefValFile;

        // Create VFD default parameter read objects 
        List<V1000_Param_Data> V1000_Vals = new List<V1000_Param_Data>();
        
        // Create delegate for sending progress of an operation to the Progress Report form
        public delegate void SendProgress(object sender, ProgressEventArgs e);
        private ProgressEventArgs ProgressArgs = new ProgressEventArgs();

        // Create handling of VFD default parameter background worker read event handling
        public event SendProgress ProgressEvent;
        #endregion

        #region General Form Controls
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                cmbSerialPort.Items.Add(s);
            }

            // select last serial port, by default it seems the add-on port is always last.
            if (cmbSerialPort.Items.Count > 1)
            {
                cmbSerialPort.SelectedIndex = cmbSerialPort.Items.Count - 1;
            }
            else
                cmbSerialPort.SelectedIndex = 0;

            txtSlaveAddr.Text = "1F";
            btnBrowseParamList.Focus();
            this.AcceptButton = btnBrowseParamList;

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (spVFD.IsOpen)
                spVFD.Close();
        }

        private void txtSlaveAddr_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SlaveAddress = Convert.ToByte(txtSlaveAddr.Text, 16);
            }
            catch
            {
                MessageBox.Show("Invalid VFD Slave Address Entry Format!!");
                txtSlaveAddr.Text = "";
            }
        }

        private void cmbSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            spVFD.PortName = cmbSerialPort.GetItemText(cmbSerialPort.SelectedItem);
        }
        #endregion

        #region V1000 Parameter Listing File Methods
        private void btnParamListBrowse_Click(object sender, EventArgs e)
        {
            opfdParamList.ShowDialog();
            txtParamListFile.Text = opfdParamList.FileName;
        }

        private void txtParamListFile_TextChanged(object sender, EventArgs e)
        {
            if (txtParamListFile.Text != "")
            {
                ParamListFile = txtParamListFile.Text;
                btnReadParamList.Enabled = true;
                btnReadParamList.Focus();
                this.AcceptButton = btnReadParamList;
            }
            else
            {
                ParamListFile = null;
                btnReadParamList.Enabled = false;
            }

        }

        private void btnParamListRead_Click(object sender, EventArgs e)
        {
            if (!bwrkReadParamListFile.IsBusy)
            {
                // Clear all existing rows in the datagridview
                dgvV1000ParamView.Rows.Clear();

                // Reset all progress flags and start the list file read thread
                ProgressArgs.ClearListReadVals();
                ProgressArgs.Mode_Sel = ProgressEventArgs.ListReadMode;
                ProgressArgs.ListRead_Stat = 0x01;
                bwrkReadParamListFile.RunWorkerAsync();

                // Create the progress reporting form object and show it.
                frmProgReport frmListFileRead = new frmProgReport("", "Data Read Progress:", "Cancel Data Read");
                frmListFileRead.ProgressCancelUpdated += new frmProgReport.ProgressCancelHandler(Progress_Cancel_Clicked);
                ProgressEvent += frmListFileRead.ProgressReceived;

                // Set the progress form display location at the center of the main form.
                int x = (this.DesktopBounds.X + (this.Width / 2)) - (frmListFileRead.DesktopBounds.Width / 2);
                int y = (this.DesktopBounds.Y + (this.Height / 2)) - (frmListFileRead.DesktopBounds.Height / 2);
                frmListFileRead.SetDesktopLocation(x, y);

                // Show the form
                frmListFileRead.Show();

                btnReadParamList.Enabled = false;
            }
        }

        private void bwrkReadParamListRead_DoWork(object sender, DoWorkEventArgs e)
        {
            xlApp = new XL.Application();
            xlWorkbook = xlApp.Workbooks.Open(ParamListFile);
            xlWorksheet = xlWorkbook.Sheets[1];
            xlRange = xlWorksheet.UsedRange;

            V1000_Vals.Clear();

            ProgressArgs.ListRead_Total_Units = xlRange.Rows.Count - 1;

            for (int i = 2; i <= xlRange.Rows.Count; i++)
            {
                if (bwrkReadParamListFile.CancellationPending)
                {
                    e.Cancel = true;
                    bwrkReadParamListFile.ReportProgress(0);
                    return;
                }

                V1000_Param_Data ParamData = new V1000_Param_Data();

                if (xlRange.Cells[i, 1] != null && xlRange.Cells[i, 1].Value2 != null)
                    ParamData.RegAddress = Convert.ToUInt16(xlRange.Cells[i, 1].Value2);
                else
                    ParamData.RegAddress = 0;

                if (xlRange.Cells[i, 2] != null && xlRange.Cells[i, 2].Value2 != null)
                    ParamData.ParamNum = xlRange.Cells[i, 2].Value2.ToString();
                else
                    ParamData.ParamNum = "0";

                if (xlRange.Cells[i, 3] != null && xlRange.Cells[i, 3].Value2 != null)
                    ParamData.ParamName = xlRange.Cells[i, 3].Value2.ToString();
                else
                    ParamData.ParamName = "0";

                if (xlRange.Cells[i, 4] != null && xlRange.Cells[i, 4].Value2 != null)
                    ParamData.DefVal = Convert.ToUInt16(xlRange.Cells[i, 4].Value2);
                else
                    ParamData.DefVal = 0;

                if (xlRange.Cells[i, 5] != null && xlRange.Cells[i, 5].Value2 != null)
                    ParamData.Multiplier = Convert.ToUInt16(xlRange.Cells[i, 5].Value2);
                else
                    ParamData.Multiplier = 1;

                if (xlRange.Cells[i, 6] != null && xlRange.Cells[i, 6].Value2 != null)
                    ParamData.NumBase = Convert.ToByte(xlRange.Cells[i, 6].Value2);
                else
                    ParamData.NumBase = 10;

                if (xlRange.Cells[i, 7] != null && xlRange.Cells[i, 7].Value2 != null)
                    ParamData.Units = xlRange.Cells[i, 7].Value2.ToString();
                else
                    ParamData.Units = "";

                // Create a string version for display purposes of the actual default paramater value
                if (ParamData.NumBase == 16)
                    ParamData.DefValDisp = "0x" + ParamData.DefVal.ToString("X4");
                else
                    ParamData.DefValDisp = ((float)ParamData.DefVal / ParamData.Multiplier).ToString() + " " + ParamData.Units;

                V1000_Vals.Add(ParamData);

                ProgressArgs.ListRead_Unit = i - 2;
                ProgressArgs.ListRead_Progress = (byte)(((float)ProgressArgs.ListRead_Unit / ProgressArgs.ListRead_Total_Units) * 100);
                bwrkReadParamListFile.ReportProgress((int)ProgressArgs.ListRead_Progress);

            }

            ProgressArgs.ListRead_Progress = 100;
            ProgressArgs.ListRead_Stat = 0x02;
            e.Result = ProgressArgs.ListRead_Stat;
            bwrkReadParamListFile.ReportProgress(100);
        }

        private void bwrkReadParamListFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(xlRange);
            xlWorkbook.Close();
            xlApp.Quit();
            Marshal.ReleaseComObject(xlWorkbook);
            Marshal.ReleaseComObject(xlWorksheet);
            Marshal.ReleaseComObject(xlApp);

            for (int i = 0; i < V1000_Vals.Count; i++)
            {
                dgvV1000ParamView.Rows.Add(new string[]
                {
                    ("0x" + V1000_Vals[i].RegAddress.ToString("X4")),
                    V1000_Vals[i].ParamNum,
                    V1000_Vals[i].ParamName,
                    V1000_Vals[i].DefValDisp
                });
            }

            btnReadParamList.Enabled = true;    // re-enable the Parameter Listing File Read button

            // Enable the ability to read the VFD values provided there was actual parameter data read
            if (V1000_Vals.Count > 0)
            {
                btnReadVFDVals.Enabled = true;
                btnReadVFDVals.Focus();
                this.AcceptButton = btnReadVFDVals;
            }
        }
        #endregion

        #region V1000 Drive Parameter Setting Read Methods
        private void btnReadVFDVals_Click(object sender, EventArgs e)
        {
            if (!bwrkReadVFDVals.IsBusy)
            {
                // Reset all progress flags and start the VFD parameter setting read thread
                ProgressArgs.ClearVFDReadVals();    // Initialize the progress flags for a VFD read
                ProgressArgs.Mode_Sel = ProgressEventArgs.VFDReadMode;
                ProgressArgs.VFDRead_Stat = 0x01;
                bwrkReadVFDVals.RunWorkerAsync();   // Start the separate thread for reading the current VFD parameter settings

                // Create the progress reporting form object and show it.
                frmProgReport frmVFDReadProg = new frmProgReport("VFD Read Parameter:", "Data Read Progress", "Cancel VFD Read");
                frmVFDReadProg.ProgressCancelUpdated += new frmProgReport.ProgressCancelHandler(Progress_Cancel_Clicked);
                ProgressEvent += frmVFDReadProg.ProgressReceived;

                // Set the progress form display location at the center of the main form.
                int x = (this.DesktopBounds.X + (this.Width / 2)) - (frmVFDReadProg.DesktopBounds.Width / 2);
                int y = (this.DesktopBounds.Y + (this.Height / 2)) - (frmVFDReadProg.DesktopBounds.Height / 2);
                frmVFDReadProg.SetDesktopLocation(x, y);

                // Show the form
                frmVFDReadProg.Show();

                btnReadVFDVals.Enabled = false; // disable the Read VFD button while a read is in progress.
            }
        }

        private void bwrkReadVFDVals_DoWork(object sender, DoWorkEventArgs e)
        {
            int status = 0;
            V1000_ModbusRTU_Comm comm = new V1000_ModbusRTU_Comm();
            ModbusRTUMsg msg = new ModbusRTUMsg(SlaveAddress);
            ModbusRTUMaster modbus = new ModbusRTUMaster();
            List<ushort> tmp = new List<ushort>();

            // proceed further only if opening of communication port is successful
            if (comm.OpenCommPort(ref spVFD) == 0x0001)
            {
                ProgressArgs.VFDRead_Total_Units = V1000_Vals.Count;

                for (int i = 0; i < ProgressArgs.VFDRead_Total_Units; i++)
                {
                    if (bwrkReadVFDVals.CancellationPending)
                    {
                        e.Cancel = true;
                        bwrkReadVFDVals.ReportProgress(0);
                        return;
                    }

                    msg.Clear();
                    msg = modbus.CreateMessage(msg.SlaveAddr, ModbusRTUMaster.ReadReg, V1000_Vals[i].RegAddress, 1, tmp);

                    status = comm.DataTransfer(ref msg, ref spVFD);
                    if (status == 0x0001)
                    {
                        V1000_Vals[i].ParamVal = msg.Data[0];

                        // Create a string version for display purposes of the actual paramater value
                        if (V1000_Vals[i].NumBase == 16)
                            V1000_Vals[i].ParamValDisp = "0x" + V1000_Vals[i].ParamVal.ToString("X4");
                        else
                            V1000_Vals[i].ParamValDisp = ((float)V1000_Vals[i].ParamVal / V1000_Vals[i].Multiplier).ToString() + " " + V1000_Vals[i].Units;
                    }

                    ProgressArgs.VFDRead_Unit = i;
                    ProgressArgs.VFDRead_Progress = (byte)(((float)i / ProgressArgs.VFDRead_Total_Units) * 100);
                    bwrkReadVFDVals.ReportProgress((int)ProgressArgs.VFDRead_Progress);
                }

                ProgressArgs.VFDRead_Progress = 100;
                ProgressArgs.VFDRead_Stat = 0x02;
                e.Result = 0x02;
                comm.CloseCommPort(ref spVFD);
                bwrkReadVFDVals.ReportProgress(100);
            }
        }

        private void bwrkReadVFDVals_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (ProgressArgs.VFDRead_Unit > 0)
            {
                // populate the VFD Value column on the VFD Parameter Values datagridview
                for (int i = 0; i < dgvV1000ParamView.RowCount; i++)
                    dgvV1000ParamView.Rows[i].Cells[4].Value = V1000_Vals[i].ParamValDisp;

                btnReadVFDVals.Enabled = true; // re-enable the VFD read button
                grpParamDefValFile.Enabled = true;
                btnBrowseDefValList.Focus();
                this.AcceptButton = btnBrowseDefValList;
            }
            else
            {
                MessageBox.Show("Error getting parameter settings from VFD");
            }
        }

        #endregion

        #region V1000 Default Parameter Listing File Write Methods
        private void btnDefSetBrowse_Click(object sender, EventArgs e)
        {
            svfdParamDefValFile.ShowDialog();
            txtParamDefOutFile.Text = svfdParamDefValFile.FileName;
        }

        private void txtParamDefOutFile_TextChanged(object sender, EventArgs e)
        {
            if (txtParamDefOutFile.Text != "")
            {
                ParamDefValFile = txtParamDefOutFile.Text;
                btnWriteDefValList.Enabled = true;
                btnWriteDefValList.Focus();
                this.AcceptButton = btnWriteDefValList;
            }
            else
            {
                ParamDefValFile = null;
                btnWriteDefValList.Enabled = false;
            }
        }

        private void btnWriteDefValFile_Click(object sender, EventArgs e)
        {
            if ((ParamDefValFile != null) && !bwrkWriteDefValFile.IsBusy)
            {
                // Reset all progress flags and start the list file read thread
                ProgressArgs.ClearWriteListVals();
                ProgressArgs.Mode_Sel = ProgressEventArgs.ListWriteMode;
                ProgressArgs.ListWrite_Stat = 0x01;
                bwrkWriteDefValFile.RunWorkerAsync();

                // Create the progress reporting form object and show it.
                frmProgReport frmListFileWrite = new frmProgReport("", "Data Write Progress:", "Cancel Data Write");
                frmListFileWrite.ProgressCancelUpdated += new frmProgReport.ProgressCancelHandler(Progress_Cancel_Clicked);
                ProgressEvent += frmListFileWrite.ProgressReceived;

                // Set the progress form display location at the center of the main form.
                int x = (this.DesktopBounds.X + (this.Width / 2)) - (frmListFileWrite.DesktopBounds.Width / 2);
                int y = (this.DesktopBounds.Y + (this.Height / 2)) - (frmListFileWrite.DesktopBounds.Height / 2);
                frmListFileWrite.SetDesktopLocation(x, y);

                // Show the form
                frmListFileWrite.Show();

                btnWriteDefValList.Enabled = false;
            }
        }

        private void bwrkWriteDefValFile_DoWork(object sender, DoWorkEventArgs e)
        {
            xlApp = new XL.Application();
            xlWorkbook = xlApp.Workbooks.Add();
            xlWorksheet = xlWorkbook.Sheets[1];
            xlRange = xlWorksheet.UsedRange;

            ProgressArgs.ListWrite_Total_Units = V1000_Vals.Count;

            xlWorksheet.Cells[1, 1].Value2 = "REGISTER ADDRESS";
            xlWorksheet.Cells[1, 2].Value2 = "PARAMETER NUMBER";
            xlWorksheet.Cells[1, 3].Value2 = "PARAMETER NAME";
            xlWorksheet.Cells[1, 4].Value2 = "DEFAULT VALUE";
            xlWorksheet.Cells[1, 5].Value2 = "MULTIPLIER";
            xlWorksheet.Cells[1, 6].Value2 = "BASE";
            xlWorksheet.Cells[1, 7].Value2 = "UNITS";

            for (int i = 0; i < V1000_Vals.Count; i++)
            {
                if (bwrkWriteDefValFile.CancellationPending)
                {
                    e.Cancel = true;
                    bwrkWriteDefValFile.ReportProgress(0);
                    return;
                }
                xlWorksheet.Cells[i + 2, 1].Value2 = V1000_Vals[i].RegAddress;
                xlWorksheet.Cells[i + 2, 2].Value2 = V1000_Vals[i].ParamNum;
                xlWorksheet.Cells[i + 2, 3].Value2 = V1000_Vals[i].ParamName;
                xlWorksheet.Cells[i + 2, 4].Value2 = V1000_Vals[i].ParamVal;
                xlWorksheet.Cells[i + 2, 5].Value2 = V1000_Vals[i].Multiplier;
                xlWorksheet.Cells[i + 2, 6].Value2 = V1000_Vals[i].NumBase;
                xlWorksheet.Cells[i + 2, 7].Value2 = V1000_Vals[i].Units;

                ProgressArgs.ListWrite_Unit = i + 1;
                ProgressArgs.ListWrite_Progress = (byte)(((float)i / ProgressArgs.ListWrite_Total_Units) * 100);
                bwrkWriteDefValFile.ReportProgress((int)ProgressArgs.ListWrite_Progress);
            }

            ProgressArgs.ListWrite_Progress = 100;
            bwrkWriteDefValFile.ReportProgress(100);
            ProgressArgs.ListWrite_Stat = ProgressEventArgs.ListWriteMode;
            e.Result = 0x02;

        }

        private void bwrkWriteDefValFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(xlRange);

            xlWorkbook.SaveAs(ParamDefValFile);
            xlWorkbook.Close();
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkbook);
            Marshal.ReleaseComObject(xlWorksheet);
            Marshal.ReleaseComObject(xlApp);

            btnWriteDefValList.Enabled = true;    // re-enable the Parameter Listing File Read button
        }
        #endregion

        private void bwrk_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressEvent?.Invoke(this, ProgressArgs);
        }

        private void Progress_Cancel_Clicked(object sender, ProgressCancelArgs e)
        {
            switch (e.ProgMode)
            {
                case 0x00:
                    if (e.ReadCancel && bwrkReadParamListFile.IsBusy)
                    {
                        bwrkReadParamListFile.CancelAsync();
                    }
                    break;
                case 0x01:
                    if (e.ReadCancel && bwrkReadVFDVals.IsBusy)
                    {
                        bwrkReadVFDVals.CancelAsync();
                    }
                    break;
                case 0x02:
                    if (e.ReadCancel && bwrkWriteDefValFile.IsBusy)
                    {
                        bwrkWriteDefValFile.CancelAsync();
                    }
                    break;
            }
        }

        private void btnVFDReset_Click(object sender, EventArgs e)
        {
            V1000_ModbusRTU_Comm comm = new V1000_ModbusRTU_Comm();
            ModbusRTUMsg msg = new ModbusRTUMsg(0x1F);
            ModbusRTUMaster modbus = new ModbusRTUMaster();
            List<ushort> val = new List<ushort>();

            msg.Clear();
            val.Clear();
            val.Add(2220);
            msg = modbus.CreateMessage(msg.SlaveAddr, ModbusRTUMaster.WriteReg, 0x0103, 1, val);

            comm.OpenCommPort(ref spVFD);
            int status = comm.DataTransfer(ref msg, ref spVFD);
            if (status != 0x0001)
                MessageBox.Show("VFD Parameter Reset to Default Failure!!");
            comm.CloseCommPort(ref spVFD);
        }
    }

    public class ProgressEventArgs : EventArgs
    {
        // Mode Legend:
        public const byte ListReadMode = 0x01;
        public const byte ListWriteMode = 0x02;
        public const byte VFDReadMode = 0x03;

        public byte Mode_Sel = 0;

        // status legend:
        public const byte Stat_NotRunning = 0x00;
        public const byte Stat_Running = 0x01;
        public const byte Stat_Complete = 0x02;
        public const byte Stat_Canceled = 0x03;
        public const byte Stat_Error = 0xFF;

        public byte ListRead_Stat = 0;
        public byte ListRead_ErrCode = 0;
        public int  ListRead_Unit = 0;
        public int  ListRead_Total_Units = 0;
        public byte ListRead_Progress = 0;

        public byte   VFDRead_Stat = 0;
        public byte   VFDRead_ErrCode = 0;
        public int    VFDRead_Unit = 0;
        public int    VFDRead_Total_Units = 0;
        public byte   VFDRead_Progress = 0;
        public string VFDRead_ParamNum = "";
        public string VFDRead_ParamName = "";

        public byte ListWrite_Stat = 0;
        public byte ListWrite_ErrCode = 0;
        public int  ListWrite_Unit = 0;
        public int  ListWrite_Total_Units = 0;
        public byte ListWrite_Progress = 0;

        public ProgressEventArgs() { }

        public void ClearAll()
        {
            ListRead_Stat = 0;
            ListRead_ErrCode = 0;
            ListRead_Unit = 0;
            ListRead_Total_Units = 0;
            ListRead_Progress = 0;

            VFDRead_Stat = 0;
            VFDRead_ErrCode = 0;
            VFDRead_Unit = 0;
            VFDRead_Total_Units = 0;
            VFDRead_Progress = 0;
            VFDRead_ParamNum = "";
            VFDRead_ParamName = "";

            ListWrite_Stat = 0;
            ListWrite_ErrCode = 0;
            ListWrite_Unit = 0;
            ListWrite_Total_Units = 0;
            ListWrite_Progress = 0;
    }

        public void ClearListReadVals()
        {
            ListRead_Stat = 0;
            ListRead_ErrCode = 0;
            ListRead_Unit = 0;
            ListRead_Total_Units = 0;
            ListRead_Progress = 0;
        }

        public void ClearVFDReadVals()
        {
            VFDRead_Stat = 0;
            VFDRead_ErrCode = 0;
            VFDRead_Unit = 0;
            VFDRead_Total_Units = 0;
            VFDRead_Progress = 0;
            VFDRead_ParamNum = "";
            VFDRead_ParamName = "";
        }

        public void ClearWriteListVals()
        {
            ListWrite_Stat = 0;
            ListWrite_ErrCode = 0;
            ListWrite_Unit = 0;
            ListWrite_Total_Units = 0;
            ListWrite_Progress = 0;
        }

    }

}
