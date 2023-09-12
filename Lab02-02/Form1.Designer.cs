namespace Lab02_02
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTTSV = new System.Windows.Forms.GroupBox();
            this.comboBoxCN = new System.Windows.Forms.ComboBox();
            this.textBoxDTB = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMSSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewSV = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSSNu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSSNam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonThemSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.checkBoxNam = new System.Windows.Forms.RadioButton();
            this.checkBoxNu = new System.Windows.Forms.RadioButton();
            this.groupBoxTTSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // groupBoxTTSV
            // 
            this.groupBoxTTSV.Controls.Add(this.checkBoxNu);
            this.groupBoxTTSV.Controls.Add(this.checkBoxNam);
            this.groupBoxTTSV.Controls.Add(this.comboBoxCN);
            this.groupBoxTTSV.Controls.Add(this.textBoxDTB);
            this.groupBoxTTSV.Controls.Add(this.textBoxName);
            this.groupBoxTTSV.Controls.Add(this.textBoxMSSV);
            this.groupBoxTTSV.Controls.Add(this.label6);
            this.groupBoxTTSV.Controls.Add(this.label5);
            this.groupBoxTTSV.Controls.Add(this.label4);
            this.groupBoxTTSV.Controls.Add(this.label3);
            this.groupBoxTTSV.Controls.Add(this.label2);
            this.groupBoxTTSV.Location = new System.Drawing.Point(12, 77);
            this.groupBoxTTSV.Name = "groupBoxTTSV";
            this.groupBoxTTSV.Size = new System.Drawing.Size(265, 177);
            this.groupBoxTTSV.TabIndex = 1;
            this.groupBoxTTSV.TabStop = false;
            this.groupBoxTTSV.Text = "Thông Tin Sinh Viên";
            // 
            // comboBoxCN
            // 
            this.comboBoxCN.FormattingEnabled = true;
            this.comboBoxCN.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.comboBoxCN.Location = new System.Drawing.Point(96, 141);
            this.comboBoxCN.Name = "comboBoxCN";
            this.comboBoxCN.Size = new System.Drawing.Size(163, 21);
            this.comboBoxCN.TabIndex = 10;
            // 
            // textBoxDTB
            // 
            this.textBoxDTB.Location = new System.Drawing.Point(96, 103);
            this.textBoxDTB.Name = "textBoxDTB";
            this.textBoxDTB.Size = new System.Drawing.Size(68, 20);
            this.textBoxDTB.TabIndex = 9;
            this.textBoxDTB.TextChanged += new System.EventHandler(this.textBoxDTB_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(96, 54);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(163, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxMSSV
            // 
            this.textBoxMSSV.Location = new System.Drawing.Point(96, 28);
            this.textBoxMSSV.Name = "textBoxMSSV";
            this.textBoxMSSV.Size = new System.Drawing.Size(100, 20);
            this.textBoxMSSV.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Chuyên Ngành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Điểm TB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // dataGridViewSV
            // 
            this.dataGridViewSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.HoTen,
            this.GioiTinh,
            this.DTB,
            this.Khoa});
            this.dataGridViewSV.Location = new System.Drawing.Point(296, 77);
            this.dataGridViewSV.Name = "dataGridViewSV";
            this.dataGridViewSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSV.Size = new System.Drawing.Size(492, 204);
            this.dataGridViewSV.TabIndex = 2;
            this.dataGridViewSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSV_CellClick);
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // DTB
            // 
            this.DTB.HeaderText = "DTB";
            this.DTB.Name = "DTB";
            // 
            // Khoa
            // 
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.Name = "Khoa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSSNu);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxSSNam);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(546, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 63);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sỉ Số";
            // 
            // textBoxSSNu
            // 
            this.textBoxSSNu.Location = new System.Drawing.Point(179, 21);
            this.textBoxSSNu.Name = "textBoxSSNu";
            this.textBoxSSNu.Size = new System.Drawing.Size(47, 20);
            this.textBoxSSNu.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nữ";
            // 
            // textBoxSSNam
            // 
            this.textBoxSSNam.Location = new System.Drawing.Point(58, 21);
            this.textBoxSSNam.Name = "textBoxSSNam";
            this.textBoxSSNam.Size = new System.Drawing.Size(47, 20);
            this.textBoxSSNam.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nam";
            // 
            // buttonThemSua
            // 
            this.buttonThemSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemSua.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonThemSua.Location = new System.Drawing.Point(108, 272);
            this.buttonThemSua.Name = "buttonThemSua";
            this.buttonThemSua.Size = new System.Drawing.Size(90, 23);
            this.buttonThemSua.TabIndex = 4;
            this.buttonThemSua.Text = "Thêm / Sửa";
            this.buttonThemSua.UseVisualStyleBackColor = true;
            this.buttonThemSua.Click += new System.EventHandler(this.buttonThemSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonXoa.Location = new System.Drawing.Point(204, 272);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 5;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // checkBoxNam
            // 
            this.checkBoxNam.AutoSize = true;
            this.checkBoxNam.Location = new System.Drawing.Point(96, 80);
            this.checkBoxNam.Name = "checkBoxNam";
            this.checkBoxNam.Size = new System.Drawing.Size(47, 17);
            this.checkBoxNam.TabIndex = 6;
            this.checkBoxNam.TabStop = true;
            this.checkBoxNam.Text = "Nam";
            this.checkBoxNam.UseVisualStyleBackColor = true;
            // 
            // checkBoxNu
            // 
            this.checkBoxNu.AutoSize = true;
            this.checkBoxNu.Location = new System.Drawing.Point(161, 80);
            this.checkBoxNu.Name = "checkBoxNu";
            this.checkBoxNu.Size = new System.Drawing.Size(39, 17);
            this.checkBoxNu.TabIndex = 11;
            this.checkBoxNu.TabStop = true;
            this.checkBoxNu.Text = "Nữ";
            this.checkBoxNu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonThemSua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewSV);
            this.Controls.Add(this.groupBoxTTSV);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTTSV.ResumeLayout(false);
            this.groupBoxTTSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxTTSV;
        private System.Windows.Forms.TextBox textBoxMSSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewSV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxCN;
        private System.Windows.Forms.TextBox textBoxDTB;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSSNu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSSNam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.Button buttonThemSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.RadioButton checkBoxNu;
        private System.Windows.Forms.RadioButton checkBoxNam;
    }
}

