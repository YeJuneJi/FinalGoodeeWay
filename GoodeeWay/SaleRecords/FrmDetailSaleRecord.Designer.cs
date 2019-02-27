namespace GoodeeWay.SaleRecords
{
    partial class FrmDetailSaleRecord
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
            this.components = new System.ComponentModel.Container();
            this.tbxMenus = new System.Windows.Forms.TextBox();
            this.btnRefund = new System.Windows.Forms.Button();
            this.lblSalesNo = new System.Windows.Forms.Label();
            this.lblSalesDate = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblRefund = new System.Windows.Forms.Label();
            this.movePanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbxImages = new System.Windows.Forms.PictureBox();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.movePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImages)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxMenus
            // 
            this.tbxMenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxMenus.Location = new System.Drawing.Point(12, 161);
            this.tbxMenus.Multiline = true;
            this.tbxMenus.Name = "tbxMenus";
            this.tbxMenus.ReadOnly = true;
            this.tbxMenus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxMenus.Size = new System.Drawing.Size(695, 452);
            this.tbxMenus.TabIndex = 0;
            // 
            // btnRefund
            // 
            this.btnRefund.BackgroundImage = global::GoodeeWay.Properties.Resources.Refund_50px;
            this.btnRefund.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefund.FlatAppearance.BorderSize = 0;
            this.btnRefund.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefund.Location = new System.Drawing.Point(19, 622);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(35, 35);
            this.btnRefund.TabIndex = 1;
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // lblSalesNo
            // 
            this.lblSalesNo.AutoSize = true;
            this.lblSalesNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSalesNo.Location = new System.Drawing.Point(21, 68);
            this.lblSalesNo.Name = "lblSalesNo";
            this.lblSalesNo.Size = new System.Drawing.Size(57, 20);
            this.lblSalesNo.TabIndex = 2;
            this.lblSalesNo.Text = "주문번호";
            // 
            // lblSalesDate
            // 
            this.lblSalesDate.AutoSize = true;
            this.lblSalesDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSalesDate.Location = new System.Drawing.Point(21, 95);
            this.lblSalesDate.Name = "lblSalesDate";
            this.lblSalesDate.Size = new System.Drawing.Size(57, 20);
            this.lblSalesDate.TabIndex = 3;
            this.lblSalesDate.Text = "판매날짜";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalPrice.Location = new System.Drawing.Point(21, 122);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(33, 20);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "가격";
            // 
            // lblRefund
            // 
            this.lblRefund.AutoSize = true;
            this.lblRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRefund.Location = new System.Drawing.Point(101, 629);
            this.lblRefund.Name = "lblRefund";
            this.lblRefund.Size = new System.Drawing.Size(61, 20);
            this.lblRefund.TabIndex = 5;
            this.lblRefund.Text = "제조 상태";
            // 
            // movePanel
            // 
            this.movePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(188)))), ((int)(((byte)(204)))));
            this.movePanel.Controls.Add(this.btnClose);
            this.movePanel.Controls.Add(this.pbxImages);
            this.movePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.movePanel.Location = new System.Drawing.Point(0, 0);
            this.movePanel.Name = "movePanel";
            this.movePanel.Size = new System.Drawing.Size(719, 52);
            this.movePanel.TabIndex = 18;
            this.movePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movePanel_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::GoodeeWay.Properties.Resources.Cancel_64px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(677, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 91;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbxImages
            // 
            this.pbxImages.BackColor = System.Drawing.Color.Transparent;
            this.pbxImages.Location = new System.Drawing.Point(0, 0);
            this.pbxImages.Name = "pbxImages";
            this.pbxImages.Size = new System.Drawing.Size(176, 52);
            this.pbxImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImages.TabIndex = 8;
            this.pbxImages.TabStop = false;
            // 
            // FrmDetailSaleRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 669);
            this.Controls.Add(this.movePanel);
            this.Controls.Add(this.lblRefund);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblSalesDate);
            this.Controls.Add(this.lblSalesNo);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.tbxMenus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetailSaleRecord";
            this.Text = "FrmDetailSaleRecord";
            this.Load += new System.EventHandler(this.FrmDetailSaleRecord_Load);
            this.movePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMenus;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Label lblSalesNo;
        private System.Windows.Forms.Label lblSalesDate;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblRefund;
        private System.Windows.Forms.Panel movePanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbxImages;
        private System.Windows.Forms.ToolTip myToolTip;
    }
}