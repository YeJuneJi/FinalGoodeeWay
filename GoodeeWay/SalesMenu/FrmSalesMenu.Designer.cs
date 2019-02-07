namespace GoodeeWay.SalesMenu
{
    partial class FrmSalesMenu
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
            this.salesMenuGView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.msktbxMnuCode = new System.Windows.Forms.MaskedTextBox();
            this.tbxMnuName = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxKcal = new System.Windows.Forms.TextBox();
            this.cbxDivision = new System.Windows.Forms.ComboBox();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.tbxAddContxt = new System.Windows.Forms.TextBox();
            this.btnMnuInsert = new System.Windows.Forms.Button();
            this.btnMnuUpdate = new System.Windows.Forms.Button();
            this.btnMnuDelete = new System.Windows.Forms.Button();
            this.btnMnuSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.oFdialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.salesMenuGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // salesMenuGView
            // 
            this.salesMenuGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesMenuGView.Location = new System.Drawing.Point(12, 186);
            this.salesMenuGView.MultiSelect = false;
            this.salesMenuGView.Name = "salesMenuGView";
            this.salesMenuGView.ReadOnly = true;
            this.salesMenuGView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.salesMenuGView.RowTemplate.Height = 23;
            this.salesMenuGView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.salesMenuGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesMenuGView.Size = new System.Drawing.Size(724, 319);
            this.salesMenuGView.TabIndex = 0;
            this.salesMenuGView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesMenuGView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "메뉴코드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "메뉴명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "가격";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kcal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "사진";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "구분";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "부가설명";
            // 
            // msktbxMnuCode
            // 
            this.msktbxMnuCode.Location = new System.Drawing.Point(95, 26);
            this.msktbxMnuCode.Mask = "MNU0000000";
            this.msktbxMnuCode.Name = "msktbxMnuCode";
            this.msktbxMnuCode.Size = new System.Drawing.Size(164, 21);
            this.msktbxMnuCode.TabIndex = 8;
            // 
            // tbxMnuName
            // 
            this.tbxMnuName.Location = new System.Drawing.Point(95, 54);
            this.tbxMnuName.Name = "tbxMnuName";
            this.tbxMnuName.Size = new System.Drawing.Size(164, 21);
            this.tbxMnuName.TabIndex = 9;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(95, 82);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(164, 21);
            this.tbxPrice.TabIndex = 10;
            this.tbxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrice_KeyPress);
            this.tbxPrice.Leave += new System.EventHandler(this.tbxPrice_Leave);
            // 
            // tbxKcal
            // 
            this.tbxKcal.Location = new System.Drawing.Point(95, 109);
            this.tbxKcal.Name = "tbxKcal";
            this.tbxKcal.Size = new System.Drawing.Size(164, 21);
            this.tbxKcal.TabIndex = 11;
            // 
            // cbxDivision
            // 
            this.cbxDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDivision.FormattingEnabled = true;
            this.cbxDivision.Location = new System.Drawing.Point(389, 54);
            this.cbxDivision.Name = "cbxDivision";
            this.cbxDivision.Size = new System.Drawing.Size(121, 20);
            this.cbxDivision.TabIndex = 12;
            this.cbxDivision.SelectedIndexChanged += new System.EventHandler(this.cbxDivision_SelectedIndexChanged);
            // 
            // btnPhoto
            // 
            this.btnPhoto.Location = new System.Drawing.Point(389, 24);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(121, 23);
            this.btnPhoto.TabIndex = 13;
            this.btnPhoto.Text = "찾아보기...";
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.Location = new System.Drawing.Point(621, 24);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(115, 120);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPhoto.TabIndex = 14;
            this.pbxPhoto.TabStop = false;
            // 
            // tbxAddContxt
            // 
            this.tbxAddContxt.Location = new System.Drawing.Point(389, 80);
            this.tbxAddContxt.Multiline = true;
            this.tbxAddContxt.Name = "tbxAddContxt";
            this.tbxAddContxt.Size = new System.Drawing.Size(204, 66);
            this.tbxAddContxt.TabIndex = 15;
            // 
            // btnMnuInsert
            // 
            this.btnMnuInsert.Location = new System.Drawing.Point(25, 157);
            this.btnMnuInsert.Name = "btnMnuInsert";
            this.btnMnuInsert.Size = new System.Drawing.Size(100, 23);
            this.btnMnuInsert.TabIndex = 16;
            this.btnMnuInsert.Text = "등록";
            this.btnMnuInsert.UseVisualStyleBackColor = true;
            this.btnMnuInsert.Click += new System.EventHandler(this.btnMnuInsert_Click);
            // 
            // btnMnuUpdate
            // 
            this.btnMnuUpdate.Location = new System.Drawing.Point(142, 157);
            this.btnMnuUpdate.Name = "btnMnuUpdate";
            this.btnMnuUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnMnuUpdate.TabIndex = 17;
            this.btnMnuUpdate.Text = "수정";
            this.btnMnuUpdate.UseVisualStyleBackColor = true;
            this.btnMnuUpdate.Click += new System.EventHandler(this.btnMnuUpdate_Click);
            // 
            // btnMnuDelete
            // 
            this.btnMnuDelete.Location = new System.Drawing.Point(259, 157);
            this.btnMnuDelete.Name = "btnMnuDelete";
            this.btnMnuDelete.Size = new System.Drawing.Size(100, 23);
            this.btnMnuDelete.TabIndex = 18;
            this.btnMnuDelete.Text = "삭제";
            this.btnMnuDelete.UseVisualStyleBackColor = true;
            this.btnMnuDelete.Click += new System.EventHandler(this.btnMnuDelete_Click);
            // 
            // btnMnuSearch
            // 
            this.btnMnuSearch.Location = new System.Drawing.Point(376, 157);
            this.btnMnuSearch.Name = "btnMnuSearch";
            this.btnMnuSearch.Size = new System.Drawing.Size(100, 23);
            this.btnMnuSearch.TabIndex = 19;
            this.btnMnuSearch.Text = "검색";
            this.btnMnuSearch.UseVisualStyleBackColor = true;
            this.btnMnuSearch.Click += new System.EventHandler(this.btnMnuSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(493, 157);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(265, 24);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(51, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // oFdialogPhoto
            // 
            this.oFdialogPhoto.Filter = "jpg 파일|*.jpg|png 파일|*.png";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(902, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 32);
            this.label8.TabIndex = 24;
            this.label8.Text = "상세 레시피";
            // 
            // FlowPanel
            // 
            this.FlowPanel.AutoScroll = true;
            this.FlowPanel.Location = new System.Drawing.Point(755, 57);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(537, 448);
            this.FlowPanel.TabIndex = 25;
            // 
            // FrmSalesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 517);
            this.Controls.Add(this.FlowPanel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMnuSearch);
            this.Controls.Add(this.btnMnuDelete);
            this.Controls.Add(this.btnMnuUpdate);
            this.Controls.Add(this.btnMnuInsert);
            this.Controls.Add(this.tbxAddContxt);
            this.Controls.Add(this.pbxPhoto);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.cbxDivision);
            this.Controls.Add(this.tbxKcal);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxMnuName);
            this.Controls.Add(this.msktbxMnuCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salesMenuGView);
            this.Name = "FrmSalesMenu";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.FrmSalesMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesMenuGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView salesMenuGView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox msktbxMnuCode;
        private System.Windows.Forms.TextBox tbxMnuName;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxKcal;
        private System.Windows.Forms.ComboBox cbxDivision;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.TextBox tbxAddContxt;
        private System.Windows.Forms.Button btnMnuInsert;
        private System.Windows.Forms.Button btnMnuUpdate;
        private System.Windows.Forms.Button btnMnuDelete;
        private System.Windows.Forms.Button btnMnuSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.OpenFileDialog oFdialogPhoto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
    }
}