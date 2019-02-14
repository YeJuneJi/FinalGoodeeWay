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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.주문ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재고ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.판매기록관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.비품관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인사관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매출관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.godnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.주문ToolStripMenuItem,
            this.재고ToolStripMenuItem,
            this.메뉴관리ToolStripMenuItem,
            this.판매기록관리ToolStripMenuItem,
            this.비품관리ToolStripMenuItem,
            this.인사관리ToolStripMenuItem,
            this.매출관리ToolStripMenuItem,
            this.godnsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 주문ToolStripMenuItem
            // 
            this.주문ToolStripMenuItem.Name = "주문ToolStripMenuItem";
            this.주문ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.주문ToolStripMenuItem.Text = "주문";
            this.주문ToolStripMenuItem.Click += new System.EventHandler(this.주문ToolStripMenuItem_Click);
            // 
            // 재고ToolStripMenuItem
            // 
            this.재고ToolStripMenuItem.Name = "재고ToolStripMenuItem";
            this.재고ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.재고ToolStripMenuItem.Text = "재고관리";
            this.재고ToolStripMenuItem.Click += new System.EventHandler(this.재고ToolStripMenuItem_Click);
            // 
            // 메뉴관리ToolStripMenuItem
            // 
            this.메뉴관리ToolStripMenuItem.Name = "메뉴관리ToolStripMenuItem";
            this.메뉴관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.메뉴관리ToolStripMenuItem.Text = "메뉴관리";
            this.메뉴관리ToolStripMenuItem.Click += new System.EventHandler(this.메뉴관리ToolStripMenuItem_Click);
            // 
            // 판매기록관리ToolStripMenuItem
            // 
            this.판매기록관리ToolStripMenuItem.Name = "판매기록관리ToolStripMenuItem";
            this.판매기록관리ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.판매기록관리ToolStripMenuItem.Text = "판매기록관리";
            this.판매기록관리ToolStripMenuItem.Click += new System.EventHandler(this.판매기록관리ToolStripMenuItem_Click);
            // 
            // 비품관리ToolStripMenuItem
            // 
            this.비품관리ToolStripMenuItem.Name = "비품관리ToolStripMenuItem";
            this.비품관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.비품관리ToolStripMenuItem.Text = "비품관리";
            this.비품관리ToolStripMenuItem.Click += new System.EventHandler(this.비품관리ToolStripMenuItem_Click);
            // 
            // 인사관리ToolStripMenuItem
            // 
            this.인사관리ToolStripMenuItem.Name = "인사관리ToolStripMenuItem";
            this.인사관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.인사관리ToolStripMenuItem.Text = "인사관리";
            this.인사관리ToolStripMenuItem.Click += new System.EventHandler(this.인사관리ToolStripMenuItem_Click);
            // 
            // 매출관리ToolStripMenuItem
            // 
            this.매출관리ToolStripMenuItem.Name = "매출관리ToolStripMenuItem";
            this.매출관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.매출관리ToolStripMenuItem.Text = "매출관리";
            this.매출관리ToolStripMenuItem.Click += new System.EventHandler(this.매출관리ToolStripMenuItem_Click);
            // 
            // godnsToolStripMenuItem
            // 
            this.godnsToolStripMenuItem.Name = "godnsToolStripMenuItem";
            this.godnsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.godnsToolStripMenuItem.Text = "godns";
            this.godnsToolStripMenuItem.Click += new System.EventHandler(this.godnsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 재고ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주문ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 판매기록관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 비품관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 인사관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매출관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem godnsToolStripMenuItem;
    }
}

