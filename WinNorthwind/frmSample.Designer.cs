
namespace WinNorthwind
{
    partial class frmSample
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
            this.gudiTextBox1 = new WinNorthwind.GudiTextBox();
            this.periodDateTime1 = new WinNorthwind.PeriodDateTime();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gudiTextBox1
            // 
            this.gudiTextBox1.InputType = WinNorthwind.validType.Common;
            this.gudiTextBox1.Location = new System.Drawing.Point(30, 31);
            this.gudiTextBox1.Name = "gudiTextBox1";
            this.gudiTextBox1.Size = new System.Drawing.Size(100, 21);
            this.gudiTextBox1.TabIndex = 0;
            // 
            // periodDateTime1
            // 
            this.periodDateTime1.dtFrom = "2022-12-20";
            this.periodDateTime1.dtTo = "2022-12-21";
            this.periodDateTime1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.periodDateTime1.Location = new System.Drawing.Point(27, 145);
            this.periodDateTime1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.periodDateTime1.Name = "periodDateTime1";
            this.periodDateTime1.Size = new System.Drawing.Size(420, 34);
            this.periodDateTime1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gudiTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(27, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.periodDateTime1);
            this.Name = "frmSample";
            this.Text = "frmSample";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GudiTextBox gudiTextBox1;
        private PeriodDateTime periodDateTime1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}