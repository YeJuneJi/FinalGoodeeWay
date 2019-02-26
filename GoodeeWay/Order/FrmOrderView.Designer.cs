namespace GoodeeWay.Order
{
    partial class FrmOrderView
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.listViewBasket = new System.Windows.Forms.ListView();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblKcal = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelOne = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.MenuPanel.Controls.Add(this.btn3);
            this.MenuPanel.Controls.Add(this.btnAll);
            this.MenuPanel.Controls.Add(this.btn0);
            this.MenuPanel.Controls.Add(this.btn1);
            this.MenuPanel.Controls.Add(this.btn2);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1200, 70);
            this.MenuPanel.TabIndex = 18;
            // 
            // listViewBasket
            // 
            this.listViewBasket.Location = new System.Drawing.Point(12, 458);
            this.listViewBasket.Name = "listViewBasket";
            this.listViewBasket.Size = new System.Drawing.Size(1175, 191);
            this.listViewBasket.TabIndex = 17;
            this.listViewBasket.UseCompatibleStateImageBehavior = false;
            // 
            // listViewOrder
            // 
            this.listViewOrder.Location = new System.Drawing.Point(12, 86);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(1175, 366);
            this.listViewOrder.TabIndex = 16;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.Click += new System.EventHandler(this.listViewOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1057, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 65);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "전체취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblKcal
            // 
            this.lblKcal.AutoSize = true;
            this.lblKcal.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblKcal.ForeColor = System.Drawing.Color.White;
            this.lblKcal.Location = new System.Drawing.Point(353, 24);
            this.lblKcal.Name = "lblKcal";
            this.lblKcal.Size = new System.Drawing.Size(58, 20);
            this.lblKcal.TabIndex = 13;
            this.lblKcal.Text = "Kcal :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(22, 24);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 20);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "가격 : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.lblKcal);
            this.panel1.Controls.Add(this.btnCancelOne);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 655);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 70);
            this.panel1.TabIndex = 19;
            // 
            // btnCancelOne
            // 
            this.btnCancelOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCancelOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelOne.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOne.ForeColor = System.Drawing.Color.White;
            this.btnCancelOne.Location = new System.Drawing.Point(921, 2);
            this.btnCancelOne.Name = "btnCancelOne";
            this.btnCancelOne.Size = new System.Drawing.Size(130, 65);
            this.btnCancelOne.TabIndex = 11;
            this.btnCancelOne.Text = "선택취소";
            this.btnCancelOne.UseVisualStyleBackColor = true;
            this.btnCancelOne.Click += new System.EventHandler(this.btnCancelOne_Click);
            // 
            // btn3
            // 
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Image = global::GoodeeWay.Properties.Resources.Milkshake_64px;
            this.btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3.Location = new System.Drawing.Point(987, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(200, 65);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "음료";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button_Click);
            // 
            // btnAll
            // 
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Image = global::GoodeeWay.Properties.Resources.Restaurant_50px;
            this.btnAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.Location = new System.Drawing.Point(12, 3);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(200, 65);
            this.btnAll.TabIndex = 5;
            this.btnAll.Text = "전체";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.button_Click);
            // 
            // btn0
            // 
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Image = global::GoodeeWay.Properties.Resources.Sandwich_50px;
            this.btn0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn0.Location = new System.Drawing.Point(246, 3);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(200, 65);
            this.btn0.TabIndex = 6;
            this.btn0.Text = "샌드위치";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button_Click);
            // 
            // btn1
            // 
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Image = global::GoodeeWay.Properties.Resources.Salad_50px;
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1.Location = new System.Drawing.Point(501, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(200, 65);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "샐러드";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button_Click);
            // 
            // btn2
            // 
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Image = global::GoodeeWay.Properties.Resources.Cookie_50px;
            this.btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2.Location = new System.Drawing.Point(747, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(200, 65);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "사이드";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button_Click);
            // 
            // btnOK
            // 
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Image = global::GoodeeWay.Properties.Resources.Card_Payment_50px;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(785, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(130, 65);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "결제";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.listViewBasket);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.panel1);
            this.Name = "FrmOrderView";
            this.Size = new System.Drawing.Size(1200, 725);
            this.Load += new System.EventHandler(this.FrmOrderView_Load);
            this.MenuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.ListView listViewBasket;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblKcal;
        private System.Windows.Forms.Button btnCancelOne;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
    }
}
