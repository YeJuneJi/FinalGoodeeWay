namespace GoodeeWay.BUS
{
    partial class ResourceMain
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
            this.resourceStart = new System.Windows.Forms.DateTimePicker();
            this.resourceEnd = new System.Windows.Forms.DateTimePicker();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.rdoDate = new System.Windows.Forms.RadioButton();
            this.rdoMonth = new System.Windows.Forms.RadioButton();
            this.rdoYear = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.resourceDataGView = new System.Windows.Forms.DataGridView();
            this.lbltotalInvesetPrice = new System.Windows.Forms.Label();
            this.lblEquipPrice = new System.Windows.Forms.Label();
            this.lblRawMaterialCost = new System.Windows.Forms.Label();
            this.lblEmployeeCost = new System.Windows.Forms.Label();
            this.btnChart = new System.Windows.Forms.Button();
            this.lbltotnetProfit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.resourceDataGView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resourceStart
            // 
            this.resourceStart.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceStart.Location = new System.Drawing.Point(41, 81);
            this.resourceStart.Name = "resourceStart";
            this.resourceStart.Size = new System.Drawing.Size(200, 22);
            this.resourceStart.TabIndex = 0;
            // 
            // resourceEnd
            // 
            this.resourceEnd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceEnd.Location = new System.Drawing.Point(268, 81);
            this.resourceEnd.Name = "resourceEnd";
            this.resourceEnd.Size = new System.Drawing.Size(200, 22);
            this.resourceEnd.TabIndex = 1;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(6, 85);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(32, 17);
            this.lblPeriod.TabIndex = 2;
            this.lblPeriod.Text = "기간";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(248, 85);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(15, 17);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "~";
            // 
            // rdoDate
            // 
            this.rdoDate.AutoSize = true;
            this.rdoDate.Checked = true;
            this.rdoDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDate.Location = new System.Drawing.Point(37, 20);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(50, 21);
            this.rdoDate.TabIndex = 8;
            this.rdoDate.TabStop = true;
            this.rdoDate.Text = "일별";
            this.rdoDate.UseVisualStyleBackColor = true;
            this.rdoDate.CheckedChanged += new System.EventHandler(this.rdobtn_CheckedChanged);
            // 
            // rdoMonth
            // 
            this.rdoMonth.AutoSize = true;
            this.rdoMonth.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMonth.Location = new System.Drawing.Point(112, 20);
            this.rdoMonth.Name = "rdoMonth";
            this.rdoMonth.Size = new System.Drawing.Size(50, 21);
            this.rdoMonth.TabIndex = 9;
            this.rdoMonth.Text = "월별";
            this.rdoMonth.UseVisualStyleBackColor = true;
            this.rdoMonth.CheckedChanged += new System.EventHandler(this.rdobtn_CheckedChanged);
            // 
            // rdoYear
            // 
            this.rdoYear.AutoSize = true;
            this.rdoYear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoYear.Location = new System.Drawing.Point(187, 20);
            this.rdoYear.Name = "rdoYear";
            this.rdoYear.Size = new System.Drawing.Size(50, 21);
            this.rdoYear.TabIndex = 10;
            this.rdoYear.Text = "연별";
            this.rdoYear.UseVisualStyleBackColor = true;
            this.rdoYear.CheckedChanged += new System.EventHandler(this.rdobtn_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(204)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(475, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // resourceDataGView
            // 
            this.resourceDataGView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resourceDataGView.BackgroundColor = System.Drawing.Color.White;
            this.resourceDataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resourceDataGView.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceDataGView.Location = new System.Drawing.Point(3, 135);
            this.resourceDataGView.Name = "resourceDataGView";
            this.resourceDataGView.RowTemplate.Height = 23;
            this.resourceDataGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resourceDataGView.Size = new System.Drawing.Size(777, 287);
            this.resourceDataGView.TabIndex = 12;
            // 
            // lbltotalInvesetPrice
            // 
            this.lbltotalInvesetPrice.AutoSize = true;
            this.lbltotalInvesetPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalInvesetPrice.Location = new System.Drawing.Point(568, 13);
            this.lbltotalInvesetPrice.Name = "lbltotalInvesetPrice";
            this.lbltotalInvesetPrice.Size = new System.Drawing.Size(53, 17);
            this.lbltotalInvesetPrice.TabIndex = 17;
            this.lbltotalInvesetPrice.Text = "총매출 : ";
            // 
            // lblEquipPrice
            // 
            this.lblEquipPrice.AutoSize = true;
            this.lblEquipPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipPrice.Location = new System.Drawing.Point(568, 55);
            this.lblEquipPrice.Name = "lblEquipPrice";
            this.lblEquipPrice.Size = new System.Drawing.Size(68, 17);
            this.lblEquipPrice.TabIndex = 18;
            this.lblEquipPrice.Text = "총 비품비 : ";
            // 
            // lblRawMaterialCost
            // 
            this.lblRawMaterialCost.AutoSize = true;
            this.lblRawMaterialCost.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRawMaterialCost.Location = new System.Drawing.Point(568, 34);
            this.lblRawMaterialCost.Name = "lblRawMaterialCost";
            this.lblRawMaterialCost.Size = new System.Drawing.Size(80, 17);
            this.lblRawMaterialCost.TabIndex = 19;
            this.lblRawMaterialCost.Text = "총 원재료비 : ";
            // 
            // lblEmployeeCost
            // 
            this.lblEmployeeCost.AutoSize = true;
            this.lblEmployeeCost.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeCost.Location = new System.Drawing.Point(568, 76);
            this.lblEmployeeCost.Name = "lblEmployeeCost";
            this.lblEmployeeCost.Size = new System.Drawing.Size(68, 17);
            this.lblEmployeeCost.TabIndex = 20;
            this.lblEmployeeCost.Text = "총 인사비 : ";
            // 
            // btnChart
            // 
            this.btnChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(204)))));
            this.btnChart.FlatAppearance.BorderSize = 0;
            this.btnChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.ForeColor = System.Drawing.Color.White;
            this.btnChart.Location = new System.Drawing.Point(649, 447);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(131, 23);
            this.btnChart.TabIndex = 21;
            this.btnChart.Text = "차트로 보기";
            this.btnChart.UseVisualStyleBackColor = false;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // lbltotnetProfit
            // 
            this.lbltotnetProfit.AutoSize = true;
            this.lbltotnetProfit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotnetProfit.Location = new System.Drawing.Point(568, 99);
            this.lbltotnetProfit.Name = "lbltotnetProfit";
            this.lbltotnetProfit.Size = new System.Drawing.Size(63, 17);
            this.lbltotnetProfit.TabIndex = 22;
            this.lbltotnetProfit.Text = "총 손익 : ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdoDate);
            this.panel1.Controls.Add(this.rdoMonth);
            this.panel1.Controls.Add(this.rdoYear);
            this.panel1.Location = new System.Drawing.Point(3, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 116);
            this.panel1.TabIndex = 23;
            // 
            // ResourceMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbltotnetProfit);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.lblEmployeeCost);
            this.Controls.Add(this.lblRawMaterialCost);
            this.Controls.Add(this.lblEquipPrice);
            this.Controls.Add(this.lbltotalInvesetPrice);
            this.Controls.Add(this.resourceDataGView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.resourceEnd);
            this.Controls.Add(this.resourceStart);
            this.Controls.Add(this.panel1);
            this.Name = "ResourceMain";
            this.Size = new System.Drawing.Size(799, 493);
            ((System.ComponentModel.ISupportInitialize)(this.resourceDataGView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker resourceStart;
        private System.Windows.Forms.DateTimePicker resourceEnd;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.RadioButton rdoDate;
        private System.Windows.Forms.RadioButton rdoMonth;
        private System.Windows.Forms.RadioButton rdoYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView resourceDataGView;
        private System.Windows.Forms.Label lbltotalInvesetPrice;
        private System.Windows.Forms.Label lblEquipPrice;
        private System.Windows.Forms.Label lblRawMaterialCost;
        private System.Windows.Forms.Label lblEmployeeCost;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Label lbltotnetProfit;
        private System.Windows.Forms.Panel panel1;
    }
}
