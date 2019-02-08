namespace GoodeeWay.Equipment
{
    partial class FrmEquipment
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
            this.dgvEquipmentList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModification = new System.Windows.Forms.Button();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtDetailName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lavel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchForLocation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchForPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.chbDate = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbReplacementRequest = new System.Windows.Forms.RadioButton();
            this.rbDiscard = new System.Windows.Forms.RadioButton();
            this.rbUsing = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.txtSearchForName = new System.Windows.Forms.TextBox();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnExportAsExcel = new System.Windows.Forms.Button();
            this.sfdExcel = new System.Windows.Forms.SaveFileDialog();
            this.pnlPage = new System.Windows.Forms.Panel();
            this.btnFrontPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEquipmentList
            // 
            this.dgvEquipmentList.AllowUserToDeleteRows = false;
            this.dgvEquipmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipmentList.Location = new System.Drawing.Point(0, 0);
            this.dgvEquipmentList.MultiSelect = false;
            this.dgvEquipmentList.Name = "dgvEquipmentList";
            this.dgvEquipmentList.ReadOnly = true;
            this.dgvEquipmentList.RowTemplate.Height = 23;
            this.dgvEquipmentList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEquipmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipmentList.ShowEditingIcon = false;
            this.dgvEquipmentList.Size = new System.Drawing.Size(1091, 362);
            this.dgvEquipmentList.TabIndex = 0;
            this.dgvEquipmentList.DataSourceChanged += new System.EventHandler(this.dgvEquipmentList_DataSourceChanged);
            this.dgvEquipmentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipmentList_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtpPurchaseDate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnModification);
            this.groupBox1.Controls.Add(this.cbState);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtLocation);
            this.groupBox1.Controls.Add(this.txtDetailName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lavel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-1, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 273);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "품목정보";
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Location = new System.Drawing.Point(73, 120);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(200, 21);
            this.dtpPurchaseDate.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(332, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 38);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModification
            // 
            this.btnModification.Enabled = false;
            this.btnModification.Location = new System.Drawing.Point(332, 173);
            this.btnModification.Name = "btnModification";
            this.btnModification.Size = new System.Drawing.Size(75, 38);
            this.btnModification.TabIndex = 13;
            this.btnModification.Text = "수정";
            this.btnModification.UseVisualStyleBackColor = true;
            this.btnModification.Click += new System.EventHandler(this.btnModification_Click);
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "사용중",
            "교체요망",
            "폐기"});
            this.cbState.Location = new System.Drawing.Point(73, 74);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(99, 20);
            this.cbState.TabIndex = 12;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(72, 173);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(236, 92);
            this.txtNote.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(263, 74);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPrice.TabIndex = 9;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(263, 29);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 21);
            this.txtLocation.TabIndex = 7;
            // 
            // txtDetailName
            // 
            this.txtDetailName.Location = new System.Drawing.Point(72, 29);
            this.txtDetailName.Name = "txtDetailName";
            this.txtDetailName.Size = new System.Drawing.Size(100, 21);
            this.txtDetailName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "비고";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "구매일자";
            // 
            // lavel
            // 
            this.lavel.AutoSize = true;
            this.lavel.Location = new System.Drawing.Point(204, 77);
            this.lavel.Name = "lavel";
            this.lavel.Size = new System.Drawing.Size(53, 12);
            this.lavel.TabIndex = 3;
            this.lavel.Text = "구매가격";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "제품상태";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "사용위치";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "품목명";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSearchForLocation);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSearchForPrice);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dtpEndDate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtpStartDate);
            this.groupBox2.Controls.Add(this.chbDate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtSearchForName);
            this.groupBox2.Location = new System.Drawing.Point(429, 395);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 144);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "검색";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "품목명";
            // 
            // txtSearchForLocation
            // 
            this.txtSearchForLocation.Location = new System.Drawing.Point(321, 114);
            this.txtSearchForLocation.Name = "txtSearchForLocation";
            this.txtSearchForLocation.Size = new System.Drawing.Size(110, 21);
            this.txtSearchForLocation.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "사용위치";
            // 
            // txtSearchForPrice
            // 
            this.txtSearchForPrice.Location = new System.Drawing.Point(69, 111);
            this.txtSearchForPrice.Name = "txtSearchForPrice";
            this.txtSearchForPrice.Size = new System.Drawing.Size(110, 21);
            this.txtSearchForPrice.TabIndex = 13;
            this.txtSearchForPrice.Text = "0";
            this.txtSearchForPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearchForPrice.Enter += new System.EventHandler(this.txtSearchForPrice_Enter);
            this.txtSearchForPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchForPrice_KeyPress);
            this.txtSearchForPrice.Leave += new System.EventHandler(this.txtSearchForPrice_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "구매가격";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Location = new System.Drawing.Point(300, 71);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 21);
            this.dtpEndDate.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "~";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Location = new System.Drawing.Point(71, 71);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 21);
            this.dtpStartDate.TabIndex = 18;
            // 
            // chbDate
            // 
            this.chbDate.AutoSize = true;
            this.chbDate.Location = new System.Drawing.Point(516, 74);
            this.chbDate.Name = "chbDate";
            this.chbDate.Size = new System.Drawing.Size(15, 14);
            this.chbDate.TabIndex = 17;
            this.chbDate.UseVisualStyleBackColor = true;
            this.chbDate.CheckedChanged += new System.EventHandler(this.chbDate_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "구매날짜";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(560, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbReplacementRequest);
            this.groupBox3.Controls.Add(this.rbDiscard);
            this.groupBox3.Controls.Add(this.rbUsing);
            this.groupBox3.Controls.Add(this.rbAll);
            this.groupBox3.Location = new System.Drawing.Point(6, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 41);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // rbReplacementRequest
            // 
            this.rbReplacementRequest.AutoSize = true;
            this.rbReplacementRequest.Location = new System.Drawing.Point(183, 15);
            this.rbReplacementRequest.Name = "rbReplacementRequest";
            this.rbReplacementRequest.Size = new System.Drawing.Size(71, 16);
            this.rbReplacementRequest.TabIndex = 3;
            this.rbReplacementRequest.Text = "교체요망";
            this.rbReplacementRequest.UseVisualStyleBackColor = true;
            // 
            // rbDiscard
            // 
            this.rbDiscard.AutoSize = true;
            this.rbDiscard.Location = new System.Drawing.Point(129, 14);
            this.rbDiscard.Name = "rbDiscard";
            this.rbDiscard.Size = new System.Drawing.Size(47, 16);
            this.rbDiscard.TabIndex = 2;
            this.rbDiscard.Text = "폐기";
            this.rbDiscard.UseVisualStyleBackColor = true;
            // 
            // rbUsing
            // 
            this.rbUsing.AutoSize = true;
            this.rbUsing.Location = new System.Drawing.Point(63, 15);
            this.rbUsing.Name = "rbUsing";
            this.rbUsing.Size = new System.Drawing.Size(59, 16);
            this.rbUsing.TabIndex = 1;
            this.rbUsing.Text = "사용중";
            this.rbUsing.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(8, 15);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(47, 16);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "전체";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // txtSearchForName
            // 
            this.txtSearchForName.Location = new System.Drawing.Point(321, 29);
            this.txtSearchForName.Name = "txtSearchForName";
            this.txtSearchForName.Size = new System.Drawing.Size(235, 21);
            this.txtSearchForName.TabIndex = 13;
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(539, 571);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(173, 62);
            this.btnAddEquipment.TabIndex = 3;
            this.btnAddEquipment.Text = "등록하기";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // btnExportAsExcel
            // 
            this.btnExportAsExcel.Location = new System.Drawing.Point(827, 571);
            this.btnExportAsExcel.Name = "btnExportAsExcel";
            this.btnExportAsExcel.Size = new System.Drawing.Size(173, 62);
            this.btnExportAsExcel.TabIndex = 4;
            this.btnExportAsExcel.Text = "엑셀 다운로드";
            this.btnExportAsExcel.UseVisualStyleBackColor = true;
            this.btnExportAsExcel.Click += new System.EventHandler(this.btnExportAsExcel_Click);
            // 
            // pnlPage
            // 
            this.pnlPage.Location = new System.Drawing.Point(471, 369);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.Size = new System.Drawing.Size(140, 20);
            this.pnlPage.TabIndex = 5;
            // 
            // btnFrontPage
            // 
            this.btnFrontPage.Location = new System.Drawing.Point(441, 368);
            this.btnFrontPage.Name = "btnFrontPage";
            this.btnFrontPage.Size = new System.Drawing.Size(24, 21);
            this.btnFrontPage.TabIndex = 7;
            this.btnFrontPage.Text = "<";
            this.btnFrontPage.UseVisualStyleBackColor = true;
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(648, 368);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(29, 21);
            this.btnLastPage.TabIndex = 9;
            this.btnLastPage.Text = ">>";
            this.btnLastPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(618, 368);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(24, 21);
            this.btnNextPage.TabIndex = 10;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(406, 368);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(29, 21);
            this.btnFirstPage.TabIndex = 11;
            this.btnFirstPage.Text = "<<";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(369, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "\\(원)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(183, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "\\(원)";
            // 
            // FrmEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1092, 678);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnFrontPage);
            this.Controls.Add(this.pnlPage);
            this.Controls.Add(this.btnExportAsExcel);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEquipmentList);
            this.Name = "FrmEquipment";
            this.Text = "비품관리";
            this.Load += new System.EventHandler(this.FrmEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEquipmentList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lavel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModification;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtDetailName;
        private System.Windows.Forms.TextBox txtSearchForLocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchForPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.CheckBox chbDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbReplacementRequest;
        private System.Windows.Forms.RadioButton rbDiscard;
        private System.Windows.Forms.RadioButton rbUsing;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.TextBox txtSearchForName;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnExportAsExcel;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog sfdExcel;
        private System.Windows.Forms.Panel pnlPage;
        private System.Windows.Forms.Button btnFrontPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}