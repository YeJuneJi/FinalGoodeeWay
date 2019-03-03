namespace GoodeeWay.SaleRecords
{
    partial class FrmSaleRecord
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
            this.rdoTotalSearch = new System.Windows.Forms.RadioButton();
            this.rdoDate = new System.Windows.Forms.RadioButton();
            this.rdoSalesNo = new System.Windows.Forms.RadioButton();
            this.tbxSalesNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPeriodEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpPeriodStart = new System.Windows.Forms.DateTimePicker();
            this.salesRecordsGView = new System.Windows.Forms.DataGridView();
            this.excelSaveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesRecordsGView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoTotalSearch
            // 
            this.rdoTotalSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoTotalSearch.AutoSize = true;
            this.rdoTotalSearch.Checked = true;
            this.rdoTotalSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTotalSearch.ForeColor = System.Drawing.Color.White;
            this.rdoTotalSearch.Location = new System.Drawing.Point(37, 11);
            this.rdoTotalSearch.Name = "rdoTotalSearch";
            this.rdoTotalSearch.Size = new System.Drawing.Size(75, 24);
            this.rdoTotalSearch.TabIndex = 1;
            this.rdoTotalSearch.TabStop = true;
            this.rdoTotalSearch.Text = "전체검색";
            this.rdoTotalSearch.UseVisualStyleBackColor = true;
            this.rdoTotalSearch.CheckedChanged += new System.EventHandler(this.rdoCheck_CheckedChanged);
            // 
            // rdoDate
            // 
            this.rdoDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoDate.AutoSize = true;
            this.rdoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDate.ForeColor = System.Drawing.Color.White;
            this.rdoDate.Location = new System.Drawing.Point(311, 12);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(91, 24);
            this.rdoDate.TabIndex = 3;
            this.rdoDate.Text = "기간별 검색";
            this.rdoDate.UseVisualStyleBackColor = true;
            this.rdoDate.CheckedChanged += new System.EventHandler(this.rdoCheck_CheckedChanged);
            // 
            // rdoSalesNo
            // 
            this.rdoSalesNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoSalesNo.AutoSize = true;
            this.rdoSalesNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSalesNo.ForeColor = System.Drawing.Color.White;
            this.rdoSalesNo.Location = new System.Drawing.Point(171, 11);
            this.rdoSalesNo.Name = "rdoSalesNo";
            this.rdoSalesNo.Size = new System.Drawing.Size(91, 24);
            this.rdoSalesNo.TabIndex = 2;
            this.rdoSalesNo.Text = "번호별 검색";
            this.rdoSalesNo.UseVisualStyleBackColor = true;
            this.rdoSalesNo.CheckedChanged += new System.EventHandler(this.rdoCheck_CheckedChanged);
            // 
            // tbxSalesNo
            // 
            this.tbxSalesNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxSalesNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSalesNo.ForeColor = System.Drawing.Color.Black;
            this.tbxSalesNo.Location = new System.Drawing.Point(37, 44);
            this.tbxSalesNo.Name = "tbxSalesNo";
            this.tbxSalesNo.Size = new System.Drawing.Size(425, 26);
            this.tbxSalesNo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "~";
            // 
            // dtpPeriodEnd
            // 
            this.dtpPeriodEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpPeriodEnd.CalendarForeColor = System.Drawing.Color.White;
            this.dtpPeriodEnd.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpPeriodEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPeriodEnd.Location = new System.Drawing.Point(262, 77);
            this.dtpPeriodEnd.Name = "dtpPeriodEnd";
            this.dtpPeriodEnd.Size = new System.Drawing.Size(200, 26);
            this.dtpPeriodEnd.TabIndex = 6;
            // 
            // dtpPeriodStart
            // 
            this.dtpPeriodStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpPeriodStart.CalendarForeColor = System.Drawing.Color.White;
            this.dtpPeriodStart.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpPeriodStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPeriodStart.Location = new System.Drawing.Point(37, 77);
            this.dtpPeriodStart.Name = "dtpPeriodStart";
            this.dtpPeriodStart.Size = new System.Drawing.Size(200, 26);
            this.dtpPeriodStart.TabIndex = 5;
            // 
            // salesRecordsGView
            // 
            this.salesRecordsGView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesRecordsGView.BackgroundColor = System.Drawing.Color.White;
            this.salesRecordsGView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.salesRecordsGView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.salesRecordsGView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesRecordsGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.salesRecordsGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesRecordsGView.DefaultCellStyle = dataGridViewCellStyle2;
            this.salesRecordsGView.EnableHeadersVisualStyles = false;
            this.salesRecordsGView.GridColor = System.Drawing.Color.DarkGray;
            this.salesRecordsGView.Location = new System.Drawing.Point(12, 146);
            this.salesRecordsGView.MultiSelect = false;
            this.salesRecordsGView.Name = "salesRecordsGView";
            this.salesRecordsGView.ReadOnly = true;
            this.salesRecordsGView.RowHeadersVisible = false;
            this.salesRecordsGView.RowTemplate.Height = 23;
            this.salesRecordsGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesRecordsGView.Size = new System.Drawing.Size(1176, 562);
            this.salesRecordsGView.TabIndex = 22;
            this.salesRecordsGView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesRecordsGView_CellClick);
            this.salesRecordsGView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesRecordsGView_CellDoubleClick);
            // 
            // excelSaveFileDlg
            // 
            this.excelSaveFileDlg.Filter = "xls 파일|*.xls";
            this.excelSaveFileDlg.OverwritePrompt = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.rdoTotalSearch);
            this.panel1.Controls.Add(this.dtpPeriodStart);
            this.panel1.Controls.Add(this.rdoDate);
            this.panel1.Controls.Add(this.dtpPeriodEnd);
            this.panel1.Controls.Add(this.rdoSalesNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxSalesNo);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 120);
            this.panel1.TabIndex = 35;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::GoodeeWay.Properties.Resources.Cancel_64px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1165, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 91;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Image = global::GoodeeWay.Properties.Resources.Microsoft_Excel_52px;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(1004, 23);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(160, 70);
            this.btnExcel.TabIndex = 10;
            this.btnExcel.Text = "엑셀";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::GoodeeWay.Properties.Resources.Search_52px;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(496, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 70);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::GoodeeWay.Properties.Resources.Change_Theme_52px;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(665, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 70);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::GoodeeWay.Properties.Resources.Erase_50px;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(832, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 70);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 114);
            this.panel2.TabIndex = 36;
            // 
            // lblText
            // 
            this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblText.Location = new System.Drawing.Point(696, 122);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(14, 20);
            this.lblText.TabIndex = 36;
            this.lblText.Text = "-";
            // 
            // FrmSaleRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.salesRecordsGView);
            this.Name = "FrmSaleRecord";
            this.Size = new System.Drawing.Size(1200, 725);
            this.Load += new System.EventHandler(this.FrmSaleRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesRecordsGView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoTotalSearch;
        private System.Windows.Forms.RadioButton rdoDate;
        private System.Windows.Forms.RadioButton rdoSalesNo;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxSalesNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPeriodEnd;
        private System.Windows.Forms.DateTimePicker dtpPeriodStart;
        private System.Windows.Forms.DataGridView salesRecordsGView;
        private System.Windows.Forms.SaveFileDialog excelSaveFileDlg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnClose;
    }
}
