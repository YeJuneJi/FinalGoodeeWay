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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRefund = new System.Windows.Forms.Button();
            this.lblSalesNo = new System.Windows.Forms.Label();
            this.lblSalesDate = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblRefund = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 125);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(695, 452);
            this.textBox1.TabIndex = 0;
            // 
            // btnRefund
            // 
            this.btnRefund.Location = new System.Drawing.Point(13, 598);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(75, 23);
            this.btnRefund.TabIndex = 1;
            this.btnRefund.Text = "환불";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // lblSalesNo
            // 
            this.lblSalesNo.AutoSize = true;
            this.lblSalesNo.Location = new System.Drawing.Point(21, 22);
            this.lblSalesNo.Name = "lblSalesNo";
            this.lblSalesNo.Size = new System.Drawing.Size(53, 12);
            this.lblSalesNo.TabIndex = 2;
            this.lblSalesNo.Text = "주문번호";
            // 
            // lblSalesDate
            // 
            this.lblSalesDate.AutoSize = true;
            this.lblSalesDate.Location = new System.Drawing.Point(21, 57);
            this.lblSalesDate.Name = "lblSalesDate";
            this.lblSalesDate.Size = new System.Drawing.Size(53, 12);
            this.lblSalesDate.TabIndex = 3;
            this.lblSalesDate.Text = "판매날짜";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(21, 87);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(29, 12);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "가격";
            // 
            // lblRefund
            // 
            this.lblRefund.AutoSize = true;
            this.lblRefund.Location = new System.Drawing.Point(94, 603);
            this.lblRefund.Name = "lblRefund";
            this.lblRefund.Size = new System.Drawing.Size(57, 12);
            this.lblRefund.TabIndex = 5;
            this.lblRefund.Text = "제조 상태";
            // 
            // FrmDetailSaleRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 669);
            this.Controls.Add(this.lblRefund);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblSalesDate);
            this.Controls.Add(this.lblSalesNo);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmDetailSaleRecord";
            this.Text = "FrmDetailSaleRecord";
            this.Load += new System.EventHandler(this.FrmDetailSaleRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Label lblSalesNo;
        private System.Windows.Forms.Label lblSalesDate;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblRefund;
    }
}