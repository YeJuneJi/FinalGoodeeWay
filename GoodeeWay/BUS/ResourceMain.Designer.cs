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
            this.tbxResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resourceDataGView)).BeginInit();
            this.SuspendLayout();
            // 
            // resourceStart
            // 
            this.resourceStart.Location = new System.Drawing.Point(92, 126);
            this.resourceStart.Name = "resourceStart";
            this.resourceStart.Size = new System.Drawing.Size(200, 21);
            this.resourceStart.TabIndex = 0;
            // 
            // resourceEnd
            // 
            this.resourceEnd.Location = new System.Drawing.Point(319, 126);
            this.resourceEnd.Name = "resourceEnd";
            this.resourceEnd.Size = new System.Drawing.Size(200, 21);
            this.resourceEnd.TabIndex = 1;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(57, 130);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(29, 12);
            this.lblPeriod.TabIndex = 2;
            this.lblPeriod.Text = "기간";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(299, 130);
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
            this.rdoDate.Location = new System.Drawing.Point(59, 188);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(47, 16);
            this.rdoDate.TabIndex = 8;
            this.rdoDate.TabStop = true;
            this.rdoDate.Text = "일별";
            this.rdoDate.UseVisualStyleBackColor = true;
            // 
            // rdoMonth
            // 
            this.rdoMonth.AutoSize = true;
            this.rdoMonth.Location = new System.Drawing.Point(130, 188);
            this.rdoMonth.Name = "rdoMonth";
            this.rdoMonth.Size = new System.Drawing.Size(47, 16);
            this.rdoMonth.TabIndex = 9;
            this.rdoMonth.TabStop = true;
            this.rdoMonth.Text = "월별";
            this.rdoMonth.UseVisualStyleBackColor = true;
            // 
            // rdoYear
            // 
            this.rdoYear.AutoSize = true;
            this.rdoYear.Location = new System.Drawing.Point(212, 188);
            this.rdoYear.Name = "rdoYear";
            this.rdoYear.Size = new System.Drawing.Size(47, 16);
            this.rdoYear.TabIndex = 10;
            this.rdoYear.TabStop = true;
            this.rdoYear.Text = "연별";
            this.rdoYear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(280, 185);
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
            this.resourceDataGView.Location = new System.Drawing.Point(16, 214);
            this.resourceDataGView.Name = "resourceDataGView";
            this.resourceDataGView.RowTemplate.Height = 23;
            this.resourceDataGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resourceDataGView.Size = new System.Drawing.Size(531, 279);
            this.resourceDataGView.TabIndex = 12;
            // 
            // lblbeppr
            // 
            this.lblbeppr.AutoSize = true;
            this.lblbeppr.Location = new System.Drawing.Point(317, 47);
            this.lblbeppr.Name = "lblbeppr";
            this.lblbeppr.Size = new System.Drawing.Size(117, 12);
            this.lblbeppr.TabIndex = 13;
            this.lblbeppr.Text = "손익분기 예상금액 : ";
            // 
            // lblBEPpredict
            // 
            this.lblBEPpredict.AutoSize = true;
            this.lblBEPpredict.Location = new System.Drawing.Point(440, 47);
            this.lblBEPpredict.Name = "lblBEPpredict";
            this.lblBEPpredict.Size = new System.Drawing.Size(11, 12);
            this.lblBEPpredict.TabIndex = 14;
            this.lblBEPpredict.Text = "-";
            // 
            // tbxResult
            // 
            this.tbxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxResult.Location = new System.Drawing.Point(579, 19);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxResult.Size = new System.Drawing.Size(480, 515);
            this.tbxResult.TabIndex = 15;
            // 
            // ResourceMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.tbxResult);
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
            this.Size = new System.Drawing.Size(1080, 559);
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
        private System.Windows.Forms.TextBox tbxResult;
    }
}
