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

namespace V1000_Def_Param_Gen
{
    public partial class frmProgReport : Form
    {
        public Action Worker { get; set; }

        // declare delegate and event handler for pressing the cancel button when the action is in process
        public delegate void ProgressCancelHandler(object sender, ProgressCancelArgs e);
        public event ProgressCancelHandler ProgressCancelUpdated;


        public frmProgReport()
        {
            InitializeComponent();
        }

        public frmProgReport(string p_Action1Text, string p_Action2Text, string p_CancelButtonText)
        {
            InitializeComponent();

            lblAction1.Text = p_Action1Text;
            lblAction2.Text = p_Action2Text;
            lblAction1Update.Text = "";
            lblAction2Update.Text = "";
            btnCancel.Text = p_CancelButtonText;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool b = true;
            ProgressCancelArgs args = new ProgressCancelArgs(b);
            ProgressCancelUpdated(this, args);
            this.Dispose();
        }

        public void ProgressReceived(object sender, ProgressEventArgs e)
        {
            switch (e.Mode_Sel)
            {
                case ProgressEventArgs.ListReadMode: // Excel file read
                    switch (e.ListRead_Stat)
                    {
                        case 0x01:
                            prgActionStatus.Value = e.ListRead_Progress;
                            lblAction2Update.Text = "Reading item number " + e.ListRead_Unit.ToString() + " of " + e.ListRead_Total_Units.ToString();
                            break;
                        case 0x02:
                            ProgressComplete();
                            break;
                        case 0xFF:
                            ProgressError();
                            break;
                    }
                    break;
                case ProgressEventArgs.VFDReadMode: // VFD Read
                    switch (e.VFDRead_Stat)
                    {
                        case 0x01:
                            prgActionStatus.Value = e.VFDRead_Progress;
                            lblAction2Update.Text = "Reading item number " + e.VFDRead_Unit.ToString() + " of " + e.VFDRead_Total_Units.ToString();
                            break;
                        case 0x02:
                            ProgressComplete();
                            break;
                        case 0xFF:
                            ProgressError();
                            break;
                    }
                    break;

                case ProgressEventArgs.ListWriteMode: // Excel file write
                    switch (e.ListWrite_Stat)
                    {
                        case 0x01:
                            prgActionStatus.Value = e.ListWrite_Progress;
                            lblAction2Update.Text = "Writing item number " + e.ListWrite_Unit.ToString() + " of " + e.ListWrite_Total_Units.ToString();
                            break;
                        case 0x02:
                            ProgressComplete();
                            break;
                        case 0xFF:
                            lblAction2Update.Text = "Read error!!!";
                            ProgressError();
                            break;
                    }
                    break;
            }

        } // void ProgressReceived

        private void ProgressComplete()
        {
            lblAction2Update.Text = "Read complete!!!";
            this.Close();
            this.Dispose();
        }

        private void ProgressError()
        {
            lblAction2Update.Text = "Read error!!!";
            Thread.Sleep(2500);
            this.Close();
            this.Dispose();
        }
    } // class frmProgReport

    public class ProgressCancelArgs : EventArgs
    {
        private bool read_cancel = false;

        // Mode definitions:
        // 0 - Excel File Read
        // 1 - VFD parameter read
        byte mode = 0;

        public ProgressCancelArgs() { }
        public ProgressCancelArgs(bool p_ReadCancel) { read_cancel = p_ReadCancel; }

        public bool ReadCancel { get => read_cancel; }
        public byte ProgMode { get => mode; }
    } // class ProgressCancelArgs


} // namespace V1000_Def_Param_Gen
