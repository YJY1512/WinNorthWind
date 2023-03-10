
namespace WinNorthwind
{
    partial class frmEmployee
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rdoHireDateYear = new System.Windows.Forms.RadioButton();
            this.rdoTitle = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dlg = new System.Windows.Forms.OpenFileDialog();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.picEmp = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.picEmp2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.txtNotes2 = new System.Windows.Forms.TextBox();
            this.txtHomePhone2 = new System.Windows.Forms.TextBox();
            this.dtpHiredDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtpBirthDate2 = new System.Windows.Forms.DateTimePicker();
            this.txtTitle2 = new System.Windows.Forms.TextBox();
            this.txtLastName2 = new System.Windows.Forms.TextBox();
            this.txtFirstName2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtFirstName = new WinNorthwind.GudiTextBox();
            this.txtHomePhone = new WinNorthwind.GudiTextBox();
            this.txtTitle = new WinNorthwind.GudiTextBox();
            this.txtLastName = new WinNorthwind.GudiTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.rdoHireDateYear);
            this.groupBox1.Controls.Add(this.rdoTitle);
            this.groupBox1.Controls.Add(this.rdoName);
            this.groupBox1.Controls.Add(this.txtKeyword);
            this.groupBox1.Location = new System.Drawing.Point(4, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(523, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 28);
            this.button5.TabIndex = 6;
            this.button5.Text = "Excel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(212, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 28);
            this.button4.TabIndex = 5;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(423, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "조회";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rdoHireDateYear
            // 
            this.rdoHireDateYear.AutoSize = true;
            this.rdoHireDateYear.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoHireDateYear.Location = new System.Drawing.Point(137, 9);
            this.rdoHireDateYear.Name = "rdoHireDateYear";
            this.rdoHireDateYear.Size = new System.Drawing.Size(121, 24);
            this.rdoHireDateYear.TabIndex = 3;
            this.rdoHireDateYear.Text = "HireDate Year";
            this.rdoHireDateYear.UseVisualStyleBackColor = true;
            // 
            // rdoTitle
            // 
            this.rdoTitle.AutoSize = true;
            this.rdoTitle.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoTitle.Location = new System.Drawing.Point(80, 9);
            this.rdoTitle.Name = "rdoTitle";
            this.rdoTitle.Size = new System.Drawing.Size(56, 24);
            this.rdoTitle.TabIndex = 2;
            this.rdoTitle.Text = "Title";
            this.rdoTitle.UseVisualStyleBackColor = true;
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Checked = true;
            this.rdoName.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoName.Location = new System.Drawing.Point(12, 9);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(67, 24);
            this.rdoName.TabIndex = 1;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "Name";
            this.rdoName.UseVisualStyleBackColor = true;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtKeyword.Location = new System.Drawing.Point(13, 34);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(197, 27);
            this.txtKeyword.TabIndex = 0;
            // 
            // dgvEmp
            // 
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Location = new System.Drawing.Point(13, 80);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.RowTemplate.Height = 23;
            this.dgvEmp.Size = new System.Drawing.Size(564, 393);
            this.dgvEmp.TabIndex = 1;
            this.dgvEmp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmp_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(452, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "*";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(485, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 31);
            this.button2.TabIndex = 27;
            this.button2.Text = "사원 등록";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNotes.Location = new System.Drawing.Point(3, 223);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(263, 63);
            this.txtNotes.TabIndex = 6;
            this.txtNotes.Tag = "메모사항";
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHireDate.Location = new System.Drawing.Point(3, 149);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(100, 27);
            this.dtpHireDate.TabIndex = 4;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(3, 112);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(100, 27);
            this.dtpBirthDate.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(440, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(353, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Notes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(353, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Home Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(353, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "HireDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(353, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "BirthDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(353, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Title";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(690, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 20);
            this.label19.TabIndex = 30;
            this.label19.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(353, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name";
            // 
            // dlg
            // 
            this.dlg.FileName = "openFileDialog1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(603, 89);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 20);
            this.label20.TabIndex = 29;
            this.label20.Text = "First Name";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.picEmp);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1064, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "사원 신규등록";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.txtHomePhone);
            this.panel1.Controls.Add(this.dtpBirthDate);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.dtpHireDate);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtNotes);
            this.panel1.Location = new System.Drawing.Point(461, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 325);
            this.panel1.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(440, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(353, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(59, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "사진등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picEmp
            // 
            this.picEmp.Location = new System.Drawing.Point(59, 46);
            this.picEmp.Name = "picEmp";
            this.picEmp.Size = new System.Drawing.Size(155, 154);
            this.picEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmp.TabIndex = 0;
            this.picEmp.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1072, 518);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblEmployeeID);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.picEmp2);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.txtNotes2);
            this.tabPage2.Controls.Add(this.txtHomePhone2);
            this.tabPage2.Controls.Add(this.dtpHiredDate2);
            this.tabPage2.Controls.Add(this.dtpBirthDate2);
            this.tabPage2.Controls.Add(this.txtTitle2);
            this.tabPage2.Controls.Add(this.txtLastName2);
            this.tabPage2.Controls.Add(this.txtFirstName2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dgvEmp);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1064, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "사원 검색/관리";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEmployeeID.Location = new System.Drawing.Point(857, 89);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(0, 20);
            this.lblEmployeeID.TabIndex = 67;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.Location = new System.Drawing.Point(908, 434);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 35);
            this.button8.TabIndex = 49;
            this.button8.Text = "사원 삭제";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(929, 224);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 28);
            this.button7.TabIndex = 48;
            this.button7.Text = "사진등록";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // picEmp2
            // 
            this.picEmp2.Location = new System.Drawing.Point(929, 86);
            this.picEmp2.Name = "picEmp2";
            this.picEmp2.Size = new System.Drawing.Size(119, 132);
            this.picEmp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmp2.TabIndex = 47;
            this.picEmp2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(690, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "*";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(735, 434);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 35);
            this.button6.TabIndex = 45;
            this.button6.Text = "사원 수정";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // txtNotes2
            // 
            this.txtNotes2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNotes2.Location = new System.Drawing.Point(735, 308);
            this.txtNotes2.Multiline = true;
            this.txtNotes2.Name = "txtNotes2";
            this.txtNotes2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes2.Size = new System.Drawing.Size(313, 63);
            this.txtNotes2.TabIndex = 44;
            // 
            // txtHomePhone2
            // 
            this.txtHomePhone2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtHomePhone2.Location = new System.Drawing.Point(735, 271);
            this.txtHomePhone2.Name = "txtHomePhone2";
            this.txtHomePhone2.Size = new System.Drawing.Size(100, 27);
            this.txtHomePhone2.TabIndex = 43;
            // 
            // dtpHiredDate2
            // 
            this.dtpHiredDate2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpHiredDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHiredDate2.Location = new System.Drawing.Point(735, 234);
            this.dtpHiredDate2.Name = "dtpHiredDate2";
            this.dtpHiredDate2.Size = new System.Drawing.Size(100, 27);
            this.dtpHiredDate2.TabIndex = 42;
            // 
            // dtpBirthDate2
            // 
            this.dtpBirthDate2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpBirthDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate2.Location = new System.Drawing.Point(735, 197);
            this.dtpBirthDate2.Name = "dtpBirthDate2";
            this.dtpBirthDate2.Size = new System.Drawing.Size(100, 27);
            this.dtpBirthDate2.TabIndex = 41;
            // 
            // txtTitle2
            // 
            this.txtTitle2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTitle2.Location = new System.Drawing.Point(735, 160);
            this.txtTitle2.Name = "txtTitle2";
            this.txtTitle2.Size = new System.Drawing.Size(140, 27);
            this.txtTitle2.TabIndex = 40;
            // 
            // txtLastName2
            // 
            this.txtLastName2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLastName2.Location = new System.Drawing.Point(735, 123);
            this.txtLastName2.Name = "txtLastName2";
            this.txtLastName2.Size = new System.Drawing.Size(100, 27);
            this.txtLastName2.TabIndex = 39;
            // 
            // txtFirstName2
            // 
            this.txtFirstName2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFirstName2.Location = new System.Drawing.Point(735, 86);
            this.txtFirstName2.Name = "txtFirstName2";
            this.txtFirstName2.Size = new System.Drawing.Size(100, 27);
            this.txtFirstName2.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(690, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 20);
            this.label12.TabIndex = 37;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(603, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "Notes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(603, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "Home Phone";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(603, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "HireDate";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(603, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 20);
            this.label16.TabIndex = 33;
            this.label16.Text = "BirthDate";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(603, 163);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 20);
            this.label17.TabIndex = 32;
            this.label17.Text = "Title";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(603, 126);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 20);
            this.label18.TabIndex = 31;
            this.label18.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.Aqua;
            this.txtFirstName.InputType = WinNorthwind.validType.Required;
            this.txtFirstName.Location = new System.Drawing.Point(3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 26);
            this.txtFirstName.TabIndex = 29;
            this.txtFirstName.Tag = "FirstName";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.BackColor = System.Drawing.Color.Aqua;
            this.txtHomePhone.InputType = WinNorthwind.validType.Required;
            this.txtHomePhone.Location = new System.Drawing.Point(3, 188);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(100, 26);
            this.txtHomePhone.TabIndex = 32;
            this.txtHomePhone.Tag = "Phone";
            // 
            // txtTitle
            // 
            this.txtTitle.InputType = WinNorthwind.validType.Common;
            this.txtTitle.Location = new System.Drawing.Point(3, 76);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(263, 26);
            this.txtTitle.TabIndex = 31;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.Aqua;
            this.txtLastName.InputType = WinNorthwind.validType.Required;
            this.txtLastName.Location = new System.Drawing.Point(3, 39);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 26);
            this.txtLastName.TabIndex = 30;
            this.txtLastName.Tag = "LastName";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 518);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rdoHireDateYear;
        private System.Windows.Forms.RadioButton rdoTitle;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog dlg;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picEmp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox picEmp2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtNotes2;
        private System.Windows.Forms.TextBox txtHomePhone2;
        private System.Windows.Forms.DateTimePicker dtpHiredDate2;
        private System.Windows.Forms.DateTimePicker dtpBirthDate2;
        private System.Windows.Forms.TextBox txtTitle2;
        private System.Windows.Forms.TextBox txtLastName2;
        private System.Windows.Forms.TextBox txtFirstName2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private GudiTextBox txtHomePhone;
        private GudiTextBox txtTitle;
        private GudiTextBox txtLastName;
        private GudiTextBox txtFirstName;
        private System.Windows.Forms.Panel panel1;
    }
}