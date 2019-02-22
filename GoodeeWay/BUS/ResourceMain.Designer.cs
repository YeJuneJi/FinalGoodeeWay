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
            this.tbxTotInvest = new System.Windows.Forms.TextBox();
            this.lblTotInvest = new System.Windows.Forms.Label();
            this.periodBEP = new System.Windows.Forms.Label();
            this.tbxBEP = new System.Windows.Forms.TextBox();
            this.rdoDate = new System.Windows.Forms.RadioButton();
            this.rdoMonth = new System.Windows.Forms.RadioButton();
            this.rdoYear = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.resourceDataGView = new System.Windows.Forms.DataGridView();
            this.lblbeppr = new System.Windows.Forms.Label();
            this.lblBEPpredict = new System.Windows.Forms.Label();
            this.btnNetIncome = new System.Windows.Forms.Button();
            this.lblNetIncome = new System.Windows.Forms.Label();
            this.lbltotalInvesetPrice = new System.Windows.Forms.Label();
            this.lblEquipPrice = new System.Windows.Forms.Label();
            this.lblRawMaterialCost = new System.Windows.Forms.Label();
            this.lblEmployeeCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resourceDataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // resourceStart
            // 
            this.resourceStart.Location = new System.Drawing.Point(47, 140);
            this.resourceStart.Name = "resourceStart";
            this.resourceStart.Size = new System.Drawing.Size(200, 21);
            this.resourceStart.TabIndex = 0;
            // 
            // resourceEnd
            // 
            this.resourceEnd.Location = new System.Drawing.Point(274, 140);
            this.resourceEnd.Name = "resourceEnd";
            this.resourceEnd.Size = new System.Drawing.Size(200, 21);
            this.resourceEnd.TabIndex = 1;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(12, 144);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(29, 12);
            this.lblPeriod.TabIndex = 2;
            this.lblPeriod.Text = "기간";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(254, 144);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(14, 12);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "~";
            // 
            // tbxTotInvest
            // 
            this.tbxTotInvest.Location = new System.Drawing.Point(174, 38);
            this.tbxTotInvest.Name = "tbxTotInvest";
            this.tbxTotInvest.Size = new System.Drawing.Size(100, 21);
            this.tbxTotInvest.TabIndex = 4;
            // 
            // lblTotInvest
            // 
            this.lblTotInvest.AutoSize = true;
            this.lblTotInvest.Location = new System.Drawing.Point(57, 41);
            this.lblTotInvest.Name = "lblTotInvest";
            this.lblTotInvest.Size = new System.Drawing.Size(69, 12);
            this.lblTotInvest.TabIndex = 5;
            this.lblTotInvest.Text = "총 투자금액";
            // 
            // periodBEP
            // 
            this.periodBEP.AutoSize = true;
            this.periodBEP.Location = new System.Drawing.Point(57, 77);
            this.periodBEP.Name = "periodBEP";
            this.periodBEP.Size = new System.Drawing.Size(111, 12);
            this.periodBEP.TabIndex = 7;
            this.periodBEP.Text = "손익분기기간(개월)";
            // 
            // tbxBEP
            // 
            this.tbxBEP.Location = new System.Drawing.Point(174, 74);
            this.tbxBEP.Name = "tbxBEP";
            this.tbxBEP.Size = new System.Drawing.Size(100, 21);
            this.tbxBEP.TabIndex = 6;
            // 
            // rdoDate
            // 
            this.rdoDate.AutoSize = true;
            this.rdoDate.Checked = true;
            this.rdoDate.Location = new System.Drawing.Point(74, 108);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(47, 16);
            this.rdoDate.TabIndex = 8;
            this.rdoDate.TabStop = true;
            this.rdoDate.Text = "일별";
            this.rdoDate.UseVisualStyleBackColor = true;
            this.rdoDate.CheckedChanged += new System.EventHandler(this.rdobtn_CheckedChanged);
            // 
            // rdoMonth
            // 
            this.rdoMonth.AutoSize = true;
            this.rdoMonth.Location = new System.Drawing.Point(149, 108);
            this.rdoMonth.Name = "rdoMonth";
            this.rdoMonth.Size = new System.Drawing.Size(47, 16);
            this.rdoMonth.TabIndex = 9;
            this.rdoMonth.Text = "월별";
            this.rdoMonth.UseVisualStyleBackColor = true;
            this.rdoMonth.CheckedChanged += new System.EventHandler(this.rdobtn_CheckedChanged);
            // 
            // rdoYear
            // 
            this.rdoYear.AutoSize = true;
            this.rdoYear.Location = new System.Drawing.Point(227, 108);
            this.rdoYear.Name = "rdoYear";
            this.rdoYear.Size = new System.Drawing.Size(47, 16);
            this.rdoYear.TabIndex = 10;
            this.rdoYear.Text = "연별";
            this.rdoYear.UseVisualStyleBackColor = true;
            this.rdoYear.CheckedChanged += new System.EventHandler(this.rdobtn_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(481, 139);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // resourceDataGView
            // 
            this.resourceDataGView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resourceDataGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resourceDataGView.Location = new System.Drawing.Point(16, 181);
            this.resourceDataGView.Name = "resourceDataGView";
            this.resourceDataGView.RowTemplate.Height = 23;
            this.resourceDataGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resourceDataGView.Size = new System.Drawing.Size(523, 154);
            this.resourceDataGView.TabIndex = 12;
            // 
            // lblbeppr
            // 
            this.lblbeppr.AutoSize = true;
            this.lblbeppr.Location = new System.Drawing.Point(299, 41);
            this.lblbeppr.Name = "lblbeppr";
            this.lblbeppr.Size = new System.Drawing.Size(117, 12);
            this.lblbeppr.TabIndex = 13;
            this.lblbeppr.Text = "손익분기 예상금액 : ";
            // 
            // lblBEPpredict
            // 
            this.lblBEPpredict.AutoSize = true;
            this.lblBEPpredict.Location = new System.Drawing.Point(422, 41);
            this.lblBEPpredict.Name = "lblBEPpredict";
            this.lblBEPpredict.Size = new System.Drawing.Size(11, 12);
            this.lblBEPpredict.TabIndex = 14;
            this.lblBEPpredict.Text = "-";
            // 
            // btnNetIncome
            // 
            this.btnNetIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNetIncome.Location = new System.Drawing.Point(16, 352);
            this.btnNetIncome.Name = "btnNetIncome";
            this.btnNetIncome.Size = new System.Drawing.Size(131, 23);
            this.btnNetIncome.TabIndex = 15;
            this.btnNetIncome.Text = "손익분기매출액";
            this.btnNetIncome.UseVisualStyleBackColor = true;
            this.btnNetIncome.Click += new System.EventHandler(this.btnNetIncome_Click);
            // 
            // lblNetIncome
            // 
            this.lblNetIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNetIncome.AutoSize = true;
            this.lblNetIncome.Location = new System.Drawing.Point(157, 357);
            this.lblNetIncome.Name = "lblNetIncome";
            this.lblNetIncome.Size = new System.Drawing.Size(11, 12);
            this.lblNetIncome.TabIndex = 16;
            this.lblNetIncome.Text = "-";
            // 
            // lbltotalInvesetPrice
            // 
            this.lbltotalInvesetPrice.AutoSize = true;
            this.lbltotalInvesetPrice.Location = new System.Drawing.Point(299, 60);
            this.lbltotalInvesetPrice.Name = "lbltotalInvesetPrice";
            this.lbltotalInvesetPrice.Size = new System.Drawing.Size(53, 12);
            this.lbltotalInvesetPrice.TabIndex = 17;
            this.lbltotalInvesetPrice.Text = "총매출 : ";
            // 
            // lblEquipPrice
            // 
            this.lblEquipPrice.AutoSize = true;
            this.lblEquipPrice.Location = new System.Drawing.Point(299, 98);
            this.lblEquipPrice.Name = "lblEquipPrice";
            this.lblEquipPrice.Size = new System.Drawing.Size(69, 12);
            this.lblEquipPrice.TabIndex = 18;
            this.lblEquipPrice.Text = "총 비품비 : ";
            // 
            // lblRawMaterialCost
            // 
            this.lblRawMaterialCost.AutoSize = true;
            this.lblRawMaterialCost.Location = new System.Drawing.Point(299, 79);
            this.lblRawMaterialCost.Name = "lblRawMaterialCost";
            this.lblRawMaterialCost.Size = new System.Drawing.Size(81, 12);
            this.lblRawMaterialCost.TabIndex = 19;
            this.lblRawMaterialCost.Text = "총 원재료비 : ";
            // 
            // lblEmployeeCost
            // 
            this.lblEmployeeCost.AutoSize = true;
            this.lblEmployeeCost.Location = new System.Drawing.Point(299, 117);
            this.lblEmployeeCost.Name = "lblEmployeeCost";
            this.lblEmployeeCost.Size = new System.Drawing.Size(69, 12);
            this.lblEmployeeCost.TabIndex = 20;
            this.lblEmployeeCost.Text = "총 인사비 : ";
            // 
            // ResourceMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.lblEmployeeCost);
            this.Controls.Add(this.lblRawMaterialCost);
            this.Controls.Add(this.lblEquipPrice);
            this.Controls.Add(this.lbltotalInvesetPrice);
            this.Controls.Add(this.lblNetIncome);
            this.Controls.Add(this.btnNetIncome);
            this.Controls.Add(this.lblBEPpredict);
            this.Controls.Add(this.lblbeppr);
            this.Controls.Add(this.resourceDataGView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rdoYear);
            this.Controls.Add(this.rdoMonth);
            this.Controls.Add(this.rdoDate);
            this.Controls.Add(this.periodBEP);
            this.Controls.Add(this.tbxBEP);
            this.Controls.Add(this.lblTotInvest);
            this.Controls.Add(this.tbxTotInvest);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.resourceEnd);
            this.Controls.Add(this.resourceStart);
            this.Name = "ResourceMain";
            this.Size = new System.Drawing.Size(588, 406);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResourceMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResourceMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ResourceMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.resourceDataGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker resourceStart;
        private System.Windows.Forms.DateTimePicker resourceEnd;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox tbxTotInvest;
        private System.Windows.Forms.Label lblTotInvest;
        private System.Windows.Forms.Label periodBEP;
        private System.Windows.Forms.TextBox tbxBEP;
        private System.Windows.Forms.RadioButton rdoDate;
        private System.Windows.Forms.RadioButton rdoMonth;
        private System.Windows.Forms.RadioButton rdoYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView resourceDataGView;
        private System.Windows.Forms.Label lblbeppr;
        private System.Windows.Forms.Label lblBEPpredict;
        private System.Windows.Forms.Button btnNetIncome;
        private System.Windows.Forms.Label lblNetIncome;
        private System.Windows.Forms.Label lbltotalInvesetPrice;
        private System.Windows.Forms.Label lblEquipPrice;
        private System.Windows.Forms.Label lblRawMaterialCost;
        private System.Windows.Forms.Label lblEmployeeCost;
    }
}
