namespace GoodeeWay.Order
{
    partial class OderVIew
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
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.listViewBasket = new System.Windows.Forms.ListView();
            this.gbCheckDivision = new System.Windows.Forms.GroupBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCancelOne = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblKcal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbCheckDivision.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewOrder
            // 
            this.listViewOrder.Location = new System.Drawing.Point(12, 85);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(685, 427);
            this.listViewOrder.TabIndex = 3;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.Click += new System.EventHandler(this.listViewOrder_Click);
            // 
            // listViewBasket
            // 
            this.listViewBasket.Location = new System.Drawing.Point(12, 518);
            this.listViewBasket.Name = "listViewBasket";
            this.listViewBasket.Size = new System.Drawing.Size(685, 280);
            this.listViewBasket.TabIndex = 6;
            this.listViewBasket.UseCompatibleStateImageBehavior = false;
            // 
            // gbCheckDivision
            // 
            this.gbCheckDivision.Controls.Add(this.btn3);
            this.gbCheckDivision.Controls.Add(this.btn2);
            this.gbCheckDivision.Controls.Add(this.btn1);
            this.gbCheckDivision.Controls.Add(this.btn0);
            this.gbCheckDivision.Controls.Add(this.btnAll);
            this.gbCheckDivision.Location = new System.Drawing.Point(12, 13);
            this.gbCheckDivision.Name = "gbCheckDivision";
            this.gbCheckDivision.Size = new System.Drawing.Size(673, 66);
            this.gbCheckDivision.TabIndex = 7;
            this.gbCheckDivision.TabStop = false;
            this.gbCheckDivision.Text = "구분";
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(536, 20);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(131, 46);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "음료";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(403, 20);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(127, 46);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "사이드";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(260, 20);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(137, 46);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "샐러드";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(129, 20);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(125, 46);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "샌드위치";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(6, 20);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(117, 46);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "전체";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(703, 85);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(147, 713);
            this.textBox1.TabIndex = 8;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(460, 846);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "결제";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(541, 846);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "전체취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCancelOne
            // 
            this.btnCancelOne.Location = new System.Drawing.Point(622, 846);
            this.btnCancelOne.Name = "btnCancelOne";
            this.btnCancelOne.Size = new System.Drawing.Size(75, 23);
            this.btnCancelOne.TabIndex = 11;
            this.btnCancelOne.Text = "취소";
            this.btnCancelOne.UseVisualStyleBackColor = true;
            this.btnCancelOne.Click += new System.EventHandler(this.btnCancelOne_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPrice.Location = new System.Drawing.Point(12, 813);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 20);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "가격 : ";
            // 
            // lblKcal
            // 
            this.lblKcal.AutoSize = true;
            this.lblKcal.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblKcal.Location = new System.Drawing.Point(270, 813);
            this.lblKcal.Name = "lblKcal";
            this.lblKcal.Size = new System.Drawing.Size(58, 20);
            this.lblKcal.TabIndex = 13;
            this.lblKcal.Text = "Kcal :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(732, 815);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OderVIew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 876);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblKcal);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnCancelOne);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbCheckDivision);
            this.Controls.Add(this.listViewBasket);
            this.Controls.Add(this.listViewOrder);
            this.Name = "OderVIew";
            this.Text = "OderVIew";
            this.Load += new System.EventHandler(this.OderVIew_Load);
            this.gbCheckDivision.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ListView listViewBasket;
        private System.Windows.Forms.GroupBox gbCheckDivision;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCancelOne;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblKcal;
        private System.Windows.Forms.Button button1;
    }
}