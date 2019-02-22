namespace GoodeeWay.Order
{
    partial class Order
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSale = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.cbReceipt = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.gbButton = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.gbWon = new System.Windows.Forms.GroupBox();
            this.btn50000 = new System.Windows.Forms.Button();
            this.btn10000 = new System.Windows.Forms.Button();
            this.btn5000 = new System.Windows.Forms.Button();
            this.btn1000 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbButton.SuspendLayout();
            this.gbWon.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(223, 394);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(271, 21);
            this.txtPrice.TabIndex = 0;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(120, 397);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 12);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "가격";
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Location = new System.Drawing.Point(120, 435);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(29, 12);
            this.lblSale.TabIndex = 2;
            this.lblSale.Text = "할인";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(120, 472);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(29, 12);
            this.lblTax.TabIndex = 3;
            this.lblTax.Text = "세금";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(120, 514);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(29, 12);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "합계";
            // 
            // txtSale
            // 
            this.txtSale.Location = new System.Drawing.Point(223, 432);
            this.txtSale.Name = "txtSale";
            this.txtSale.ReadOnly = true;
            this.txtSale.Size = new System.Drawing.Size(271, 21);
            this.txtSale.TabIndex = 5;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(223, 469);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(271, 21);
            this.txtTax.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(223, 511);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(271, 21);
            this.txtTotal.TabIndex = 7;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(120, 552);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(41, 12);
            this.lblPaid.TabIndex = 8;
            this.lblPaid.Text = "받은돈";
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(223, 549);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(271, 21);
            this.txtPaid.TabIndex = 9;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(120, 591);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(53, 12);
            this.lblChange.TabIndex = 10;
            this.lblChange.Text = "거스름돈";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(223, 588);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(271, 21);
            this.txtChange.TabIndex = 11;
            // 
            // cbReceipt
            // 
            this.cbReceipt.AutoSize = true;
            this.cbReceipt.Location = new System.Drawing.Point(406, 626);
            this.cbReceipt.Name = "cbReceipt";
            this.cbReceipt.Size = new System.Drawing.Size(88, 16);
            this.cbReceipt.TabIndex = 13;
            this.cbReceipt.Text = "영수증 발행";
            this.cbReceipt.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(331, 666);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "확인";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(419, 666);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(819, 363);
            this.dataGridView1.TabIndex = 16;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(14, 128);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(31, 38);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(51, 128);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(31, 38);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(88, 128);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(31, 38);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(14, 84);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(31, 38);
            this.btn4.TabIndex = 20;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(51, 84);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(31, 38);
            this.btn5.TabIndex = 21;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(88, 84);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(31, 38);
            this.btn6.TabIndex = 22;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(14, 40);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(31, 38);
            this.btn7.TabIndex = 23;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(51, 40);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(31, 38);
            this.btn8.TabIndex = 24;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(88, 40);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(31, 38);
            this.btn9.TabIndex = 25;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(51, 172);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(31, 38);
            this.btn0.TabIndex = 26;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // gbButton
            // 
            this.gbButton.Controls.Add(this.btnClear);
            this.gbButton.Controls.Add(this.btnBackSpace);
            this.gbButton.Controls.Add(this.btn5);
            this.gbButton.Controls.Add(this.btn0);
            this.gbButton.Controls.Add(this.btn1);
            this.gbButton.Controls.Add(this.btn9);
            this.gbButton.Controls.Add(this.btn2);
            this.gbButton.Controls.Add(this.btn8);
            this.gbButton.Controls.Add(this.btn3);
            this.gbButton.Controls.Add(this.btn7);
            this.gbButton.Controls.Add(this.btn4);
            this.gbButton.Controls.Add(this.btn6);
            this.gbButton.Location = new System.Drawing.Point(517, 394);
            this.gbButton.Name = "gbButton";
            this.gbButton.Size = new System.Drawing.Size(133, 244);
            this.gbButton.TabIndex = 27;
            this.gbButton.TabStop = false;
            this.gbButton.Text = "버튼";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(14, 172);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(31, 38);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.Location = new System.Drawing.Point(88, 174);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(31, 38);
            this.btnBackSpace.TabIndex = 27;
            this.btnBackSpace.Text = "<-";
            this.btnBackSpace.UseVisualStyleBackColor = true;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // gbWon
            // 
            this.gbWon.Controls.Add(this.btn50000);
            this.gbWon.Controls.Add(this.btn10000);
            this.gbWon.Controls.Add(this.btn5000);
            this.gbWon.Controls.Add(this.btn1000);
            this.gbWon.Controls.Add(this.btn500);
            this.gbWon.Controls.Add(this.btn100);
            this.gbWon.Controls.Add(this.btn50);
            this.gbWon.Controls.Add(this.btn10);
            this.gbWon.Location = new System.Drawing.Point(668, 393);
            this.gbWon.Name = "gbWon";
            this.gbWon.Size = new System.Drawing.Size(133, 245);
            this.gbWon.TabIndex = 28;
            this.gbWon.TabStop = false;
            this.gbWon.Text = "원";
            // 
            // btn50000
            // 
            this.btn50000.Location = new System.Drawing.Point(10, 22);
            this.btn50000.Name = "btn50000";
            this.btn50000.Size = new System.Drawing.Size(113, 25);
            this.btn50000.TabIndex = 27;
            this.btn50000.Text = "50000";
            this.btn50000.UseVisualStyleBackColor = true;
            this.btn50000.Click += new System.EventHandler(this.btnWon_Click);
            // 
            // btn10000
            // 
            this.btn10000.Location = new System.Drawing.Point(10, 49);
            this.btn10000.Name = "btn10000";
            this.btn10000.Size = new System.Drawing.Size(113, 25);
            this.btn10000.TabIndex = 26;
            this.btn10000.Text = "10000";
            this.btn10000.UseVisualStyleBackColor = true;
            this.btn10000.Click += new System.EventHandler(this.btnWon_Click);
            // 
            // btn5000
            // 
            this.btn5000.Location = new System.Drawing.Point(10, 76);
            this.btn5000.Name = "btn5000";
            this.btn5000.Size = new System.Drawing.Size(113, 25);
            this.btn5000.TabIndex = 25;
            this.btn5000.Text = "5000";
            this.btn5000.UseVisualStyleBackColor = true;
            this.btn5000.Click += new System.EventHandler(this.btnWon_Click);
            // 
            // btn1000
            // 
            this.btn1000.Location = new System.Drawing.Point(10, 101);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(113, 25);
            this.btn1000.TabIndex = 24;
            this.btn1000.Text = "1000";
            this.btn1000.UseVisualStyleBackColor = true;
            this.btn1000.Click += new System.EventHandler(this.btnWon_Click);
            // 
            // btn500
            // 
            this.btn500.Location = new System.Drawing.Point(10, 126);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(113, 25);
            this.btn500.TabIndex = 23;
            this.btn500.Text = "500";
            this.btn500.UseVisualStyleBackColor = true;
            this.btn500.Click += new System.EventHandler(this.btnWon_Click);
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(10, 152);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(113, 25);
            this.btn100.TabIndex = 22;
            this.btn100.Text = "100";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btnWon_Click);
            // 
            // btn50
            // 
            this.btn50.Location = new System.Drawing.Point(10, 179);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(113, 25);
            this.btn50.TabIndex = 21;
            this.btn50.Text = "50";
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.btnWon_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(10, 206);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(113, 25);
            this.btn10.TabIndex = 20;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btnWon_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 721);
            this.Controls.Add(this.gbWon);
            this.Controls.Add(this.gbButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbReceipt);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSale);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbButton.ResumeLayout(false);
            this.gbWon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.CheckBox cbReceipt;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.GroupBox gbButton;
        private System.Windows.Forms.GroupBox gbWon;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btn50000;
        private System.Windows.Forms.Button btn10000;
        private System.Windows.Forms.Button btn5000;
        private System.Windows.Forms.Button btn1000;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btnClear;
    }
}