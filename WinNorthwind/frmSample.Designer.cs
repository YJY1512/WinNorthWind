
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gudiTextBox1
            // 
            this.gudiTextBox1.InputType = WinNorthwind.validType.Common;
            this.gudiTextBox1.Location = new System.Drawing.Point(34, 39);
            this.gudiTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gudiTextBox1.Name = "gudiTextBox1";
            this.gudiTextBox1.Size = new System.Drawing.Size(114, 25);
            this.gudiTextBox1.TabIndex = 0;
            // 
            // periodDateTime1
            // 
            this.periodDateTime1.dtFrom = "2022-12-20";
            this.periodDateTime1.dtTo = "2022-12-22";
            this.periodDateTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.periodDateTime1.Location = new System.Drawing.Point(31, 181);
            this.periodDateTime1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.periodDateTime1.Name = "periodDateTime1";
            this.periodDateTime1.Size = new System.Drawing.Size(480, 42);
            this.periodDateTime1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gudiTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(31, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(427, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.periodDateTime1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button button1;
    }
}