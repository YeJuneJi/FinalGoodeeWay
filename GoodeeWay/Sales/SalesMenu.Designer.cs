namespace GoodeeWay.Sales
{
    partial class SalesMenu
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
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.salesMenuGView = new System.Windows.Forms.DataGridView();
            this.oFdialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxDiscountRatio = new System.Windows.Forms.TextBox();
            this.할인율 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMnuSearch = new System.Windows.Forms.Button();
            this.btnMnuDelete = new System.Windows.Forms.Button();
            this.btnMnuUpdate = new System.Windows.Forms.Button();
            this.btnMnuInsert = new System.Windows.Forms.Button();
            this.tbxAddContxt = new System.Windows.Forms.TextBox();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.cbxDivision = new System.Windows.Forms.ComboBox();
            this.tbxKcal = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxMnuName = new System.Windows.Forms.TextBox();
            this.msktbxMnuCode = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesMenuGView)).BeginInit();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowPanel
            // 
            this.FlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowPanel.AutoScroll = true;
            this.FlowPanel.Location = new System.Drawing.Point(757, 178);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(500, 528);
            this.FlowPanel.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(536, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 32);
            this.label8.TabIndex = 53;
            this.label8.Text = "상세 레시피";
            // 
            // salesMenuGView
            // 
            this.salesMenuGView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.salesMenuGView.BackgroundColor = System.Drawing.Color.White;
            this.salesMenuGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesMenuGView.Location = new System.Drawing.Point(14, 260);
            this.salesMenuGView.MultiSelect = false;
            this.salesMenuGView.Name = "salesMenuGView";
            this.salesMenuGView.ReadOnly = true;
            this.salesMenuGView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.salesMenuGView.RowTemplate.Height = 23;
            this.salesMenuGView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.salesMenuGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesMenuGView.Size = new System.Drawing.Size(724, 452);
            this.salesMenuGView.TabIndex = 30;
            this.salesMenuGView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesMenuGView_CellClick);
            // 
            // oFdialogPhoto
            // 
            this.oFdialogPhoto.Filter = "jpg 파일|*.jpg|png 파일|*.png";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.MenuPanel.Controls.Add(this.label11);
            this.MenuPanel.Controls.Add(this.label10);
            this.MenuPanel.Controls.Add(this.label9);
            this.MenuPanel.Controls.Add(this.tbxDiscountRatio);
            this.MenuPanel.Controls.Add(this.할인율);
            this.MenuPanel.Controls.Add(this.btnClear);
            this.MenuPanel.Controls.Add(this.btnMnuSearch);
            this.MenuPanel.Controls.Add(this.btnMnuDelete);
            this.MenuPanel.Controls.Add(this.btnMnuUpdate);
            this.MenuPanel.Controls.Add(this.btnMnuInsert);
            this.MenuPanel.Controls.Add(this.tbxAddContxt);
            this.MenuPanel.Controls.Add(this.pbxPhoto);
            this.MenuPanel.Controls.Add(this.btnPhoto);
            this.MenuPanel.Controls.Add(this.cbxDivision);
            this.MenuPanel.Controls.Add(this.tbxKcal);
            this.MenuPanel.Controls.Add(this.tbxPrice);
            this.MenuPanel.Controls.Add(this.tbxMnuName);
            this.MenuPanel.Controls.Add(this.msktbxMnuCode);
            this.MenuPanel.Controls.Add(this.label7);
            this.MenuPanel.Controls.Add(this.label6);
            this.MenuPanel.Controls.Add(this.label5);
            this.MenuPanel.Controls.Add(this.label4);
            this.MenuPanel.Controls.Add(this.label3);
            this.MenuPanel.Controls.Add(this.label2);
            this.MenuPanel.Controls.Add(this.label1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1270, 172);
            this.MenuPanel.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(257, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 12);
            this.label11.TabIndex = 83;
            this.label11.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(257, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 12);
            this.label10.TabIndex = 82;
            this.label10.Text = "Kcal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 12);
            this.label9.TabIndex = 81;
            this.label9.Text = "\\";
            // 
            // tbxDiscountRatio
            // 
            this.tbxDiscountRatio.Location = new System.Drawing.Point(87, 118);
            this.tbxDiscountRatio.Name = "tbxDiscountRatio";
            this.tbxDiscountRatio.Size = new System.Drawing.Size(164, 21);
            this.tbxDiscountRatio.TabIndex = 70;
            // 
            // 할인율
            // 
            this.할인율.AutoSize = true;
            this.할인율.Location = new System.Drawing.Point(14, 122);
            this.할인율.Name = "할인율";
            this.할인율.Size = new System.Drawing.Size(41, 12);
            this.할인율.TabIndex = 80;
            this.할인율.Text = "할인율";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(257, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(51, 23);
            this.btnClear.TabIndex = 79;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnMnuSearch
            // 
            this.btnMnuSearch.Location = new System.Drawing.Point(368, 146);
            this.btnMnuSearch.Name = "btnMnuSearch";
            this.btnMnuSearch.Size = new System.Drawing.Size(100, 23);
            this.btnMnuSearch.TabIndex = 78;
            this.btnMnuSearch.Text = "검색";
            this.btnMnuSearch.UseVisualStyleBackColor = true;
            // 
            // btnMnuDelete
            // 
            this.btnMnuDelete.Location = new System.Drawing.Point(251, 146);
            this.btnMnuDelete.Name = "btnMnuDelete";
            this.btnMnuDelete.Size = new System.Drawing.Size(100, 23);
            this.btnMnuDelete.TabIndex = 77;
            this.btnMnuDelete.Text = "삭제";
            this.btnMnuDelete.UseVisualStyleBackColor = true;
            // 
            // btnMnuUpdate
            // 
            this.btnMnuUpdate.Location = new System.Drawing.Point(134, 146);
            this.btnMnuUpdate.Name = "btnMnuUpdate";
            this.btnMnuUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnMnuUpdate.TabIndex = 76;
            this.btnMnuUpdate.Text = "수정";
            this.btnMnuUpdate.UseVisualStyleBackColor = true;
            // 
            // btnMnuInsert
            // 
            this.btnMnuInsert.Location = new System.Drawing.Point(17, 146);
            this.btnMnuInsert.Name = "btnMnuInsert";
            this.btnMnuInsert.Size = new System.Drawing.Size(100, 23);
            this.btnMnuInsert.TabIndex = 75;
            this.btnMnuInsert.Text = "등록";
            this.btnMnuInsert.UseVisualStyleBackColor = true;
            // 
            // tbxAddContxt
            // 
            this.tbxAddContxt.Location = new System.Drawing.Point(381, 62);
            this.tbxAddContxt.Multiline = true;
            this.tbxAddContxt.Name = "tbxAddContxt";
            this.tbxAddContxt.Size = new System.Drawing.Size(204, 66);
            this.tbxAddContxt.TabIndex = 74;
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.Location = new System.Drawing.Point(591, 8);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(115, 120);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPhoto.TabIndex = 73;
            this.pbxPhoto.TabStop = false;
            // 
            // btnPhoto
            // 
            this.btnPhoto.Location = new System.Drawing.Point(381, 6);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(121, 23);
            this.btnPhoto.TabIndex = 71;
            this.btnPhoto.Text = "찾아보기...";
            this.btnPhoto.UseVisualStyleBackColor = true;
            // 
            // cbxDivision
            // 
            this.cbxDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDivision.FormattingEnabled = true;
            this.cbxDivision.Location = new System.Drawing.Point(381, 36);
            this.cbxDivision.Name = "cbxDivision";
            this.cbxDivision.Size = new System.Drawing.Size(121, 20);
            this.cbxDivision.TabIndex = 72;
            // 
            // tbxKcal
            // 
            this.tbxKcal.Location = new System.Drawing.Point(87, 91);
            this.tbxKcal.Name = "tbxKcal";
            this.tbxKcal.Size = new System.Drawing.Size(164, 21);
            this.tbxKcal.TabIndex = 69;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(87, 64);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(164, 21);
            this.tbxPrice.TabIndex = 68;
            // 
            // tbxMnuName
            // 
            this.tbxMnuName.Location = new System.Drawing.Point(87, 36);
            this.tbxMnuName.Name = "tbxMnuName";
            this.tbxMnuName.Size = new System.Drawing.Size(164, 21);
            this.tbxMnuName.TabIndex = 67;
            // 
            // msktbxMnuCode
            // 
            this.msktbxMnuCode.Location = new System.Drawing.Point(87, 8);
            this.msktbxMnuCode.Mask = "MNU0000000";
            this.msktbxMnuCode.Name = "msktbxMnuCode";
            this.msktbxMnuCode.Size = new System.Drawing.Size(164, 21);
            this.msktbxMnuCode.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 65;
            this.label7.Text = "부가설명";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 64;
            this.label6.Text = "구분";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 63;
            this.label5.Text = "사진";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 12);
            this.label4.TabIndex = 62;
            this.label4.Text = "Kcal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 61;
            this.label3.Text = "가격";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 60;
            this.label2.Text = "메뉴명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 59;
            this.label1.Text = "메뉴코드";
            // 
            // SalesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.FlowPanel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.salesMenuGView);
            this.Name = "SalesMenu";
            this.Size = new System.Drawing.Size(1270, 725);
            ((System.ComponentModel.ISupportInitialize)(this.salesMenuGView)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView salesMenuGView;
        private System.Windows.Forms.OpenFileDialog oFdialogPhoto;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxDiscountRatio;
        private System.Windows.Forms.Label 할인율;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMnuSearch;
        private System.Windows.Forms.Button btnMnuDelete;
        private System.Windows.Forms.Button btnMnuUpdate;
        private System.Windows.Forms.Button btnMnuInsert;
        private System.Windows.Forms.TextBox tbxAddContxt;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.ComboBox cbxDivision;
        private System.Windows.Forms.TextBox tbxKcal;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxMnuName;
        private System.Windows.Forms.MaskedTextBox msktbxMnuCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
