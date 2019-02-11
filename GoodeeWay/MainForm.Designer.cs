namespace GoodeeWay
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalesMenu = new System.Windows.Forms.Button();
            this.btnSaleRecords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalesMenu
            // 
            this.btnSalesMenu.Location = new System.Drawing.Point(12, 12);
            this.btnSalesMenu.Name = "btnSalesMenu";
            this.btnSalesMenu.Size = new System.Drawing.Size(75, 23);
            this.btnSalesMenu.TabIndex = 0;
            this.btnSalesMenu.Text = "메뉴관리";
            this.btnSalesMenu.UseVisualStyleBackColor = true;
            this.btnSalesMenu.Click += new System.EventHandler(this.btnSalesMenu_Click);
            // 
            // btnSaleRecords
            // 
            this.btnSaleRecords.Location = new System.Drawing.Point(93, 12);
            this.btnSaleRecords.Name = "btnSaleRecords";
            this.btnSaleRecords.Size = new System.Drawing.Size(75, 23);
            this.btnSaleRecords.TabIndex = 1;
            this.btnSaleRecords.Text = "판매기록관리";
            this.btnSaleRecords.UseVisualStyleBackColor = true;
            this.btnSaleRecords.Click += new System.EventHandler(this.btnSaleRecords_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaleRecords);
            this.Controls.Add(this.btnSalesMenu);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalesMenu;
        private System.Windows.Forms.Button btnSaleRecords;
    }
}

