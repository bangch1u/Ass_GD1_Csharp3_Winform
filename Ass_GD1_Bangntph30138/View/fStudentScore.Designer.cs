namespace Ass_GD1_Bangntph30138.View
{
    partial class fStudentScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStudentScore));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchMSV = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgQuanLyDiemSV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPointAvg = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGDTC = new System.Windows.Forms.TextBox();
            this.txtTinHoc = new System.Windows.Forms.TextBox();
            this.txtTiengAnh = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuanLyDiemSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Điểm Sinh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã SV:";
            // 
            // txtSearchMSV
            // 
            this.txtSearchMSV.Location = new System.Drawing.Point(94, 40);
            this.txtSearchMSV.Name = "txtSearchMSV";
            this.txtSearchMSV.Size = new System.Drawing.Size(328, 27);
            this.txtSearchMSV.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.ImageIndex = 3;
            this.btnSearch.ImageList = this.imageList1;
            this.btnSearch.Location = new System.Drawing.Point(457, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 59);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "bin.png");
            this.imageList1.Images.SetKeyName(2, "diskette.png");
            this.imageList1.Images.SetKeyName(3, "loupe.png");
            this.imageList1.Images.SetKeyName(4, "update.png");
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.ImageIndex = 0;
            this.btnNew.ImageList = this.imageList1;
            this.btnNew.Location = new System.Drawing.Point(553, 202);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 49);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageIndex = 2;
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(553, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 49);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageKey = "bin.png";
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(553, 328);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 49);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.ImageIndex = 4;
            this.btnUpdate.ImageList = this.imageList1;
            this.btnUpdate.Location = new System.Drawing.Point(553, 391);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 49);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(22, 489);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "3 Sinh viên có điểm cao nhất";
            // 
            // dtgQuanLyDiemSV
            // 
            this.dtgQuanLyDiemSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgQuanLyDiemSV.Location = new System.Drawing.Point(22, 531);
            this.dtgQuanLyDiemSV.Name = "dtgQuanLyDiemSV";
            this.dtgQuanLyDiemSV.RowHeadersWidth = 51;
            this.dtgQuanLyDiemSV.RowTemplate.Height = 29;
            this.dtgQuanLyDiemSV.Size = new System.Drawing.Size(662, 188);
            this.dtgQuanLyDiemSV.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSearchMSV);
            this.groupBox1.Location = new System.Drawing.Point(96, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 99);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbName);
            this.groupBox2.Controls.Add(this.lbPointAvg);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtGDTC);
            this.groupBox2.Controls.Add(this.txtTinHoc);
            this.groupBox2.Controls.Add(this.txtTiengAnh);
            this.groupBox2.Controls.Add(this.txtMaSV);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(100, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 227);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(109, 25);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 20);
            this.lbName.TabIndex = 42;
            // 
            // lbPointAvg
            // 
            this.lbPointAvg.AutoSize = true;
            this.lbPointAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPointAvg.ForeColor = System.Drawing.Color.Blue;
            this.lbPointAvg.Location = new System.Drawing.Point(330, 132);
            this.lbPointAvg.Name = "lbPointAvg";
            this.lbPointAvg.Size = new System.Drawing.Size(42, 25);
            this.lbPointAvg.TabIndex = 27;
            this.lbPointAvg.Text = "0.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Điểm TB";
            // 
            // txtGDTC
            // 
            this.txtGDTC.Location = new System.Drawing.Point(111, 181);
            this.txtGDTC.Name = "txtGDTC";
            this.txtGDTC.Size = new System.Drawing.Size(156, 27);
            this.txtGDTC.TabIndex = 40;
            // 
            // txtTinHoc
            // 
            this.txtTinHoc.Location = new System.Drawing.Point(111, 143);
            this.txtTinHoc.Name = "txtTinHoc";
            this.txtTinHoc.Size = new System.Drawing.Size(156, 27);
            this.txtTinHoc.TabIndex = 39;
            // 
            // txtTiengAnh
            // 
            this.txtTiengAnh.Location = new System.Drawing.Point(111, 103);
            this.txtTiengAnh.Name = "txtTiengAnh";
            this.txtTiengAnh.Size = new System.Drawing.Size(156, 27);
            this.txtTiengAnh.TabIndex = 38;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(111, 59);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(156, 27);
            this.txtMaSV.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Giáo Dục TC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tin Học:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tiếng Anh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Mã SV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Họ tên SV:";
            // 
            // button6
            // 
            this.button6.ImageIndex = 2;
            this.button6.ImageList = this.imageList2;
            this.button6.Location = new System.Drawing.Point(112, 435);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 45);
            this.button6.TabIndex = 23;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "forward-button.png");
            this.imageList2.Images.SetKeyName(1, "next.png");
            this.imageList2.Images.SetKeyName(2, "previous.png");
            this.imageList2.Images.SetKeyName(3, "rewind-button.png");
            // 
            // button7
            // 
            this.button7.ImageIndex = 0;
            this.button7.ImageList = this.imageList2;
            this.button7.Location = new System.Drawing.Point(190, 435);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 45);
            this.button7.TabIndex = 24;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.ImageIndex = 3;
            this.button8.ImageList = this.imageList2;
            this.button8.Location = new System.Drawing.Point(271, 435);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 45);
            this.button8.TabIndex = 25;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.ImageIndex = 1;
            this.button9.ImageList = this.imageList2;
            this.button9.Location = new System.Drawing.Point(355, 435);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(54, 45);
            this.button9.TabIndex = 26;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // fStudentScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 731);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgQuanLyDiemSV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Name = "fStudentScore";
            this.Text = "Quản lý điểm sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuanLyDiemSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txtSearchMSV;
        private Button btnSearch;
        private Button btnNew;
        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label10;
        private DataGridView dtgQuanLyDiemSV;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label9;
        private TextBox txtGDTC;
        private TextBox txtTinHoc;
        private TextBox txtTiengAnh;
        private TextBox txtMaSV;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private ImageList imageList1;
        private ImageList imageList2;
        private Label lbName;
        private Label lbPointAvg;
    }
}