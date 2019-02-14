namespace GoodeeWay.BUS
{
    partial class ResourceManagemanet
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
            this.resourceMenuStrip = new System.Windows.Forms.MenuStrip();
            this.메뉴별판매량ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재고별판매량ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.비품구매통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourceMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // resourceMenuStrip
            // 
            this.resourceMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴별판매량ToolStripMenuItem,
            this.재고별판매량ToolStripMenuItem,
            this.인사ToolStripMenuItem,
            this.비품구매통계ToolStripMenuItem});
            this.resourceMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.resourceMenuStrip.Name = "resourceMenuStrip";
            this.resourceMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.resourceMenuStrip.TabIndex = 0;
            this.resourceMenuStrip.Text = "resourceMenuStrip";
            // 
            // 메뉴별판매량ToolStripMenuItem
            // 
            this.메뉴별판매량ToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.메뉴별판매량ToolStripMenuItem.Name = "메뉴별판매량ToolStripMenuItem";
            this.메뉴별판매량ToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.메뉴별판매량ToolStripMenuItem.Text = "메뉴별 판매량";
            // 
            // 재고별판매량ToolStripMenuItem
            // 
            this.재고별판매량ToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.재고별판매량ToolStripMenuItem.Name = "재고별판매량ToolStripMenuItem";
            this.재고별판매량ToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.재고별판매량ToolStripMenuItem.Text = "재고별 판매량";
            // 
            // 인사ToolStripMenuItem
            // 
            this.인사ToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.인사ToolStripMenuItem.Name = "인사ToolStripMenuItem";
            this.인사ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.인사ToolStripMenuItem.Text = "인사";
            // 
            // 비품구매통계ToolStripMenuItem
            // 
            this.비품구매통계ToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.비품구매통계ToolStripMenuItem.Name = "비품구매통계ToolStripMenuItem";
            this.비품구매통계ToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.비품구매통계ToolStripMenuItem.Text = "비품 구매 통계";
            // 
            // ResourceManagemanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resourceMenuStrip);
            this.MainMenuStrip = this.resourceMenuStrip;
            this.Name = "ResourceManagemanet";
            this.Text = "매출관리";
            this.resourceMenuStrip.ResumeLayout(false);
            this.resourceMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip resourceMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 메뉴별판매량ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재고별판매량ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 인사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 비품구매통계ToolStripMenuItem;
    }
}