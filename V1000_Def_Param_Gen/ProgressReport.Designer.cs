namespace V1000_Def_Param_Gen
{
    partial class frmProgReport
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
            this.prgActionStatus = new System.Windows.Forms.ProgressBar();
            this.lblAction2 = new System.Windows.Forms.Label();
            this.lblAction2Update = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAction1Update = new System.Windows.Forms.Label();
            this.lblAction1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prgActionStatus
            // 
            this.prgActionStatus.Location = new System.Drawing.Point(12, 63);
            this.prgActionStatus.Name = "prgActionStatus";
            this.prgActionStatus.Size = new System.Drawing.Size(456, 23);
            this.prgActionStatus.Step = 1;
            this.prgActionStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgActionStatus.TabIndex = 0;
            // 
            // lblAction2
            // 
            this.lblAction2.Location = new System.Drawing.Point(12, 36);
            this.lblAction2.Name = "lblAction2";
            this.lblAction2.Size = new System.Drawing.Size(152, 13);
            this.lblAction2.TabIndex = 1;
            this.lblAction2.Text = "Read Progress:";
            this.lblAction2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAction2Update
            // 
            this.lblAction2Update.Location = new System.Drawing.Point(170, 36);
            this.lblAction2Update.Name = "lblAction2Update";
            this.lblAction2Update.Size = new System.Drawing.Size(293, 13);
            this.lblAction2Update.TabIndex = 2;
            this.lblAction2Update.Text = "Progress Update";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(140, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAction1Update
            // 
            this.lblAction1Update.Location = new System.Drawing.Point(170, 9);
            this.lblAction1Update.Name = "lblAction1Update";
            this.lblAction1Update.Size = new System.Drawing.Size(293, 13);
            this.lblAction1Update.TabIndex = 5;
            this.lblAction1Update.Text = "Progress Update";
            // 
            // lblAction1
            // 
            this.lblAction1.Location = new System.Drawing.Point(12, 9);
            this.lblAction1.Name = "lblAction1";
            this.lblAction1.Size = new System.Drawing.Size(152, 13);
            this.lblAction1.TabIndex = 4;
            this.lblAction1.Text = "Read Progress:";
            this.lblAction1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmProgReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(480, 150);
            this.Controls.Add(this.lblAction1Update);
            this.Controls.Add(this.lblAction1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblAction2Update);
            this.Controls.Add(this.lblAction2);
            this.Controls.Add(this.prgActionStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProgReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Read Progress";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgActionStatus;
        private System.Windows.Forms.Label lblAction2;
        private System.Windows.Forms.Label lblAction2Update;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAction1Update;
        private System.Windows.Forms.Label lblAction1;
    }
}