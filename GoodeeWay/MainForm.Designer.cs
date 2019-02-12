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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.재고ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재고ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBiPoom = new System.Windows.Forms.Button();
            this.btnInsa = new System.Windows.Forms.Button();
            this.btnJoomoon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalesMenu
            // 
            this.btnSalesMenu.Location = new System.Drawing.Point(18, 47);
            this.btnSalesMenu.Name = "btnSalesMenu";
            this.btnSalesMenu.Size = new System.Drawing.Size(75, 23);
            this.btnSalesMenu.TabIndex = 0;
            this.btnSalesMenu.Text = "메뉴관리";
            this.btnSalesMenu.UseVisualStyleBackColor = true;
            this.btnSalesMenu.Click += new System.EventHandler(this.btnSalesMenu_Click);
            // 
            // btnSaleRecords
            // 
            this.btnSaleRecords.Location = new System.Drawing.Point(99, 47);
            this.btnSaleRecords.Name = "btnSaleRecords";
            this.btnSaleRecords.Size = new System.Drawing.Size(86, 23);
            this.btnSaleRecords.TabIndex = 1;
            this.btnSaleRecords.Text = "판매기록관리";
            this.btnSaleRecords.UseVisualStyleBackColor = true;
            this.btnSaleRecords.Click += new System.EventHandler(this.btnSaleRecords_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.재고ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1169, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 재고ToolStripMenuItem
            // 
            this.재고ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.재고ToolStripMenuItem1});
            this.재고ToolStripMenuItem.Name = "재고ToolStripMenuItem";
            this.재고ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.재고ToolStripMenuItem.Text = "재고";
            // 
            // 재고ToolStripMenuItem1
            // 
            this.재고ToolStripMenuItem1.Name = "재고ToolStripMenuItem1";
            this.재고ToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.재고ToolStripMenuItem1.Text = "재고";
            this.재고ToolStripMenuItem1.Click += new System.EventHandler(this.재고ToolStripMenuItem1_Click);
            // 
            // btnBiPoom
            // 
            this.btnBiPoom.Location = new System.Drawing.Point(191, 47);
            this.btnBiPoom.Name = "btnBiPoom";
            this.btnBiPoom.Size = new System.Drawing.Size(75, 23);
            this.btnBiPoom.TabIndex = 2;
            this.btnBiPoom.Text = "비품관리";
            this.btnBiPoom.UseVisualStyleBackColor = true;
            this.btnBiPoom.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInsa
            // 
            this.btnInsa.Location = new System.Drawing.Point(272, 47);
            this.btnInsa.Name = "btnInsa";
            this.btnInsa.Size = new System.Drawing.Size(75, 23);
            this.btnInsa.TabIndex = 3;
            this.btnInsa.Text = "인사관리";
            this.btnInsa.UseVisualStyleBackColor = true;
            this.btnInsa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnJoomoon
            // 
            this.btnJoomoon.Location = new System.Drawing.Point(353, 47);
            this.btnJoomoon.Name = "btnJoomoon";
            this.btnJoomoon.Size = new System.Drawing.Size(75, 23);
            this.btnJoomoon.TabIndex = 4;
            this.btnJoomoon.Text = "주문관리";
            this.btnJoomoon.UseVisualStyleBackColor = true;
            this.btnJoomoon.Click += new System.EventHandler(this.btnJoomoon_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "매출관리";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 549);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnJoomoon);
            this.Controls.Add(this.btnInsa);
            this.Controls.Add(this.btnBiPoom);
            this.Controls.Add(this.btnSaleRecords);
            this.Controls.Add(this.btnSalesMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalesMenu;
        private System.Windows.Forms.Button btnSaleRecords;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 재고ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재고ToolStripMenuItem1;
        private System.Windows.Forms.Button btnBiPoom;
        private System.Windows.Forms.Button btnInsa;
        private System.Windows.Forms.Button btnJoomoon;
        private System.Windows.Forms.Button button1;
    }
}

