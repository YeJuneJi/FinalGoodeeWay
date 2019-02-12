namespace GoodeeWay.SaleRecords
{
    partial class FrmSaleRecords
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
            this.salesRecordsGView = new System.Windows.Forms.DataGridView();
            this.dtpPeriodStart = new System.Windows.Forms.DateTimePicker();
            this.dtpPeriodEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSalesNo = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rdoSalesNo = new System.Windows.Forms.RadioButton();
            this.rdoDate = new System.Windows.Forms.RadioButton();
            this.rdoTotalSearch = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.salesRecordsGView)).BeginInit();
            this.SuspendLayout();
            // 
            // salesRecordsGView
            // 
            this.salesRecordsGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesRecordsGView.Location = new System.Drawing.Point(8, 121);
            this.salesRecordsGView.MultiSelect = false;
            this.salesRecordsGView.Name = "salesRecordsGView";
            this.salesRecordsGView.ReadOnly = true;
            this.salesRecordsGView.RowTemplate.Height = 23;
            this.salesRecordsGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesRecordsGView.Size = new System.Drawing.Size(693, 381);
            this.salesRecordsGView.TabIndex = 0;
            this.salesRecordsGView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesRecordsGView_CellClick);
            // 
            // dtpPeriodStart
            // 
            this.dtpPeriodStart.Location = new System.Drawing.Point(21, 61);
            this.dtpPeriodStart.Name = "dtpPeriodStart";
            this.dtpPeriodStart.Size = new System.Drawing.Size(200, 21);
            this.dtpPeriodStart.TabIndex = 10;
            // 
            // dtpPeriodEnd
            // 
            this.dtpPeriodEnd.Location = new System.Drawing.Point(246, 61);
            this.dtpPeriodEnd.Name = "dtpPeriodEnd";
            this.dtpPeriodEnd.Size = new System.Drawing.Size(200, 21);
            this.dtpPeriodEnd.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "~";
            // 
            // tbxSalesNo
            // 
            this.tbxSalesNo.Location = new System.Drawing.Point(21, 34);
            this.tbxSalesNo.Name = "tbxSalesNo";
            this.tbxSalesNo.Size = new System.Drawing.Size(425, 21);
            this.tbxSalesNo.TabIndex = 13;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(313, 92);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 18;
            this.btnExcel.Text = "엑셀";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(20, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(216, 92);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(119, 92);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rdoSalesNo
            // 
            this.rdoSalesNo.AutoSize = true;
            this.rdoSalesNo.Location = new System.Drawing.Point(107, 12);
            this.rdoSalesNo.Name = "rdoSalesNo";
            this.rdoSalesNo.Size = new System.Drawing.Size(87, 16);
            this.rdoSalesNo.TabIndex = 19;
            this.rdoSalesNo.Text = "번호별 검색";
            this.rdoSalesNo.UseVisualStyleBackColor = true;
            this.rdoSalesNo.CheckedChanged += new System.EventHandler(this.rdoCheck_CheckedChanged);
            // 
            // rdoDate
            // 
            this.rdoDate.AutoSize = true;
            this.rdoDate.Location = new System.Drawing.Point(216, 12);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(87, 16);
            this.rdoDate.TabIndex = 20;
            this.rdoDate.Text = "기간별 검색";
            this.rdoDate.UseVisualStyleBackColor = true;
            this.rdoDate.CheckedChanged += new System.EventHandler(this.rdoCheck_CheckedChanged);
            // 
            // rdoTotalSearch
            // 
            this.rdoTotalSearch.AutoSize = true;
            this.rdoTotalSearch.Checked = true;
            this.rdoTotalSearch.Location = new System.Drawing.Point(20, 12);
            this.rdoTotalSearch.Name = "rdoTotalSearch";
            this.rdoTotalSearch.Size = new System.Drawing.Size(71, 16);
            this.rdoTotalSearch.TabIndex = 21;
            this.rdoTotalSearch.TabStop = true;
            this.rdoTotalSearch.Text = "전체검색";
            this.rdoTotalSearch.UseVisualStyleBackColor = true;
            this.rdoTotalSearch.CheckedChanged += new System.EventHandler(this.rdoCheck_CheckedChanged);
            // 
            // FrmSaleRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 511);
            this.Controls.Add(this.rdoTotalSearch);
            this.Controls.Add(this.rdoDate);
            this.Controls.Add(this.rdoSalesNo);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbxSalesNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpPeriodEnd);
            this.Controls.Add(this.dtpPeriodStart);
            this.Controls.Add(this.salesRecordsGView);
            this.Name = "FrmSaleRecords";
            this.Text = "판매기록";
            this.Load += new System.EventHandler(this.FrmSaleRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesRecordsGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView salesRecordsGView;
        private System.Windows.Forms.DateTimePicker dtpPeriodStart;
        private System.Windows.Forms.DateTimePicker dtpPeriodEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSalesNo;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton rdoSalesNo;
        private System.Windows.Forms.RadioButton rdoDate;
        private System.Windows.Forms.RadioButton rdoTotalSearch;
    }
}