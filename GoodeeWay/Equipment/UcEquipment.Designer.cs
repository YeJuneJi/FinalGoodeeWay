namespace GoodeeWay.Equipment
{
    partial class UcEquipment
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnFrontPage = new System.Windows.Forms.Button();
            this.pnlPage = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.label12 = new System.Windows.Forms.Label();
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
            this.dgvEquipmentList = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFirstPage.Location = new System.Drawing.Point(415, 391);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(29, 21);
            this.btnFirstPage.TabIndex = 16;
            this.btnFirstPage.Text = "<<";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNextPage.Location = new System.Drawing.Point(666, 390);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(24, 21);
            this.btnNextPage.TabIndex = 15;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLastPage.Location = new System.Drawing.Point(696, 390);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(29, 21);
            this.btnLastPage.TabIndex = 14;
            this.btnLastPage.Text = ">>";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnFrontPage
            // 
            this.btnFrontPage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFrontPage.Location = new System.Drawing.Point(450, 391);
            this.btnFrontPage.Name = "btnFrontPage";
            this.btnFrontPage.Size = new System.Drawing.Size(24, 21);
            this.btnFrontPage.TabIndex = 13;
            this.btnFrontPage.Text = "<";
            this.btnFrontPage.UseVisualStyleBackColor = true;
            this.btnFrontPage.Click += new System.EventHandler(this.btnFrontPage_Click);
            // 
            // pnlPage
            // 
            this.pnlPage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlPage.Location = new System.Drawing.Point(480, 391);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.Size = new System.Drawing.Size(180, 20);
            this.pnlPage.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
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
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 430);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 273);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "품목정보";
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
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Location = new System.Drawing.Point(73, 120);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(200, 21);
            this.dtpPurchaseDate.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(332, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 38);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModification
            // 
            this.btnModification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.btnModification.Enabled = false;
            this.btnModification.FlatAppearance.BorderSize = 0;
            this.btnModification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModification.Location = new System.Drawing.Point(332, 173);
            this.btnModification.Name = "btnModification";
            this.btnModification.Size = new System.Drawing.Size(75, 38);
            this.btnModification.TabIndex = 13;
            this.btnModification.Text = "수정";
            this.btnModification.UseVisualStyleBackColor = false;
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
            this.groupBox2.BackColor = System.Drawing.Color.White;
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
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(446, 430);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 144);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "검색";
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
            this.txtSearchForLocation.Location = new System.Drawing.Point(321, 111);
            this.txtSearchForLocation.Name = "txtSearchForLocation";
            this.txtSearchForLocation.Size = new System.Drawing.Size(110, 21);
            this.txtSearchForLocation.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 114);
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
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(560, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbReplacementRequest);
            this.groupBox3.Controls.Add(this.rbDiscard);
            this.groupBox3.Controls.Add(this.rbUsing);
            this.groupBox3.Controls.Add(this.rbAll);
            this.groupBox3.Location = new System.Drawing.Point(6, 12);
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
            this.btnAddEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.btnAddEquipment.FlatAppearance.BorderSize = 0;
            this.btnAddEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEquipment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddEquipment.Location = new System.Drawing.Point(556, 606);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(173, 62);
            this.btnAddEquipment.TabIndex = 19;
            this.btnAddEquipment.Text = "등록하기";
            this.btnAddEquipment.UseVisualStyleBackColor = false;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // btnExportAsExcel
            // 
            this.btnExportAsExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.btnExportAsExcel.FlatAppearance.BorderSize = 0;
            this.btnExportAsExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportAsExcel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExportAsExcel.Location = new System.Drawing.Point(844, 606);
            this.btnExportAsExcel.Name = "btnExportAsExcel";
            this.btnExportAsExcel.Size = new System.Drawing.Size(173, 62);
            this.btnExportAsExcel.TabIndex = 20;
            this.btnExportAsExcel.Text = "엑셀 다운로드";
            this.btnExportAsExcel.UseVisualStyleBackColor = false;
            this.btnExportAsExcel.Click += new System.EventHandler(this.btnExportAsExcel_Click);
            // 
            // dgvEquipmentList
            // 
            this.dgvEquipmentList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquipmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipmentList.BackgroundColor = System.Drawing.Color.White;
            this.dgvEquipmentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEquipmentList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipmentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEquipmentList.ColumnHeadersHeight = 20;
            this.dgvEquipmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEquipmentList.EnableHeadersVisualStyles = false;
            this.dgvEquipmentList.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEquipmentList.Location = new System.Drawing.Point(0, 0);
            this.dgvEquipmentList.Name = "dgvEquipmentList";
            this.dgvEquipmentList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipmentList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEquipmentList.RowHeadersVisible = false;
            this.dgvEquipmentList.RowHeadersWidth = 21;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEquipmentList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEquipmentList.RowTemplate.Height = 23;
            this.dgvEquipmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipmentList.Size = new System.Drawing.Size(1200, 385);
            this.dgvEquipmentList.TabIndex = 37;
            this.dgvEquipmentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipmentList_CellClick);
            // 
            // UcEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvEquipmentList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.btnExportAsExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnFrontPage);
            this.Controls.Add(this.pnlPage);
            this.Name = "UcEquipment";
            this.Size = new System.Drawing.Size(1200, 730);
            this.Load += new System.EventHandler(this.UcEquipment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnFrontPage;
        private System.Windows.Forms.Panel pnlPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModification;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtDetailName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lavel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.SaveFileDialog sfdExcel;
        private System.Windows.Forms.DataGridView dgvEquipmentList;
    }
}
