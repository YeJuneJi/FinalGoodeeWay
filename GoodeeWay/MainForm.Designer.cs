﻿namespace GoodeeWay
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
            this.components = new System.ComponentModel.Container();
            this.mMenuStrip = new System.Windows.Forms.MenuStrip();
            this.주문ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재고ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.판매기록관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.비품관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인사관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매출관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.제조현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsLblTime = new System.Windows.Forms.ToolStripLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.mMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMenuStrip
            // 
            this.mMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.주문ToolStripMenuItem,
            this.재고ToolStripMenuItem,
            this.메뉴관리ToolStripMenuItem,
            this.판매기록관리ToolStripMenuItem,
            this.비품관리ToolStripMenuItem,
            this.인사관리ToolStripMenuItem,
            this.매출관리ToolStripMenuItem,
            this.제조현황ToolStripMenuItem});
            this.mMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mMenuStrip.Name = "mMenuStrip";
            this.mMenuStrip.Size = new System.Drawing.Size(1484, 24);
            this.mMenuStrip.TabIndex = 0;
            this.mMenuStrip.Text = "menuStrip1";
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
            // 제조현황ToolStripMenuItem
            // 
            this.제조현황ToolStripMenuItem.Name = "제조현황ToolStripMenuItem";
            this.제조현황ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.제조현황ToolStripMenuItem.Text = "제조현황";
            this.제조현황ToolStripMenuItem.Click += new System.EventHandler(this.제조현황ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsLblTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 936);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1484, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(91, 22);
            this.toolStripLabel1.Text = "(주)GoodeeWay";
            // 
            // tsLblTime
            // 
            this.tsLblTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLblTime.Name = "tsLblTime";
            this.tsLblTime.Size = new System.Drawing.Size(0, 22);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mMenuStrip);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mMenuStrip.ResumeLayout(false);
            this.mMenuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 재고ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주문ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 판매기록관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 비품관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 인사관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매출관리ToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel tsLblTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem 제조현황ToolStripMenuItem;
    }
}

