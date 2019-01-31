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
            this.btn음료 = new System.Windows.Forms.Button();
            this.btn사이드 = new System.Windows.Forms.Button();
            this.btn샐러드 = new System.Windows.Forms.Button();
            this.btn샌드위치 = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCancelOne = new System.Windows.Forms.Button();
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
            this.gbCheckDivision.Controls.Add(this.btn음료);
            this.gbCheckDivision.Controls.Add(this.btn사이드);
            this.gbCheckDivision.Controls.Add(this.btn샐러드);
            this.gbCheckDivision.Controls.Add(this.btn샌드위치);
            this.gbCheckDivision.Controls.Add(this.btnAll);
            this.gbCheckDivision.Location = new System.Drawing.Point(12, 13);
            this.gbCheckDivision.Name = "gbCheckDivision";
            this.gbCheckDivision.Size = new System.Drawing.Size(673, 66);
            this.gbCheckDivision.TabIndex = 7;
            this.gbCheckDivision.TabStop = false;
            this.gbCheckDivision.Text = "구분";
            // 
            // btn음료
            // 
            this.btn음료.Location = new System.Drawing.Point(536, 20);
            this.btn음료.Name = "btn음료";
            this.btn음료.Size = new System.Drawing.Size(131, 46);
            this.btn음료.TabIndex = 4;
            this.btn음료.Text = "음료";
            this.btn음료.UseVisualStyleBackColor = true;
            this.btn음료.Click += new System.EventHandler(this.button_Click);
            // 
            // btn사이드
            // 
            this.btn사이드.Location = new System.Drawing.Point(403, 20);
            this.btn사이드.Name = "btn사이드";
            this.btn사이드.Size = new System.Drawing.Size(127, 46);
            this.btn사이드.TabIndex = 3;
            this.btn사이드.Text = "사이드";
            this.btn사이드.UseVisualStyleBackColor = true;
            this.btn사이드.Click += new System.EventHandler(this.button_Click);
            // 
            // btn샐러드
            // 
            this.btn샐러드.Location = new System.Drawing.Point(260, 20);
            this.btn샐러드.Name = "btn샐러드";
            this.btn샐러드.Size = new System.Drawing.Size(137, 46);
            this.btn샐러드.TabIndex = 2;
            this.btn샐러드.Text = "샐러드";
            this.btn샐러드.UseVisualStyleBackColor = true;
            this.btn샐러드.Click += new System.EventHandler(this.button_Click);
            // 
            // btn샌드위치
            // 
            this.btn샌드위치.Location = new System.Drawing.Point(129, 20);
            this.btn샌드위치.Name = "btn샌드위치";
            this.btn샌드위치.Size = new System.Drawing.Size(125, 46);
            this.btn샌드위치.TabIndex = 1;
            this.btn샌드위치.Text = "샌드위치";
            this.btn샌드위치.UseVisualStyleBackColor = true;
            this.btn샌드위치.Click += new System.EventHandler(this.button_Click);
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
            this.btnOK.Location = new System.Drawing.Point(460, 804);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "결제";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(541, 804);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "전체취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCancelOne
            // 
            this.btnCancelOne.Location = new System.Drawing.Point(622, 804);
            this.btnCancelOne.Name = "btnCancelOne";
            this.btnCancelOne.Size = new System.Drawing.Size(75, 23);
            this.btnCancelOne.TabIndex = 11;
            this.btnCancelOne.Text = "취소";
            this.btnCancelOne.UseVisualStyleBackColor = true;
            this.btnCancelOne.Click += new System.EventHandler(this.btnCancelOne_Click);
            // 
            // OderVIew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 876);
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
        private System.Windows.Forms.Button btn음료;
        private System.Windows.Forms.Button btn사이드;
        private System.Windows.Forms.Button btn샐러드;
        private System.Windows.Forms.Button btn샌드위치;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCancelOne;
    }
}