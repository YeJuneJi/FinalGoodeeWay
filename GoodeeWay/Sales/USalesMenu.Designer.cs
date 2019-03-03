namespace GoodeeWay.Sales
{
    partial class USalesMenu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.salesMenuGView = new System.Windows.Forms.DataGridView();
            this.oFdialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSearh = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxDiscountRatio = new System.Windows.Forms.TextBox();
            this.할인율 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDivisionExplain = new System.Windows.Forms.Label();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblRecipeQues = new System.Windows.Forms.Label();
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
            this.FlowPanel.Location = new System.Drawing.Point(679, 202);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(578, 510);
            this.FlowPanel.TabIndex = 54;
            // 
            // salesMenuGView
            // 
            this.salesMenuGView.AllowUserToAddRows = false;
            this.salesMenuGView.AllowUserToDeleteRows = false;
            this.salesMenuGView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.salesMenuGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesMenuGView.BackgroundColor = System.Drawing.Color.White;
            this.salesMenuGView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.salesMenuGView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.salesMenuGView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesMenuGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.salesMenuGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesMenuGView.DefaultCellStyle = dataGridViewCellStyle2;
            this.salesMenuGView.EnableHeadersVisualStyles = false;
            this.salesMenuGView.Location = new System.Drawing.Point(14, 202);
            this.salesMenuGView.MultiSelect = false;
            this.salesMenuGView.Name = "salesMenuGView";
            this.salesMenuGView.ReadOnly = true;
            this.salesMenuGView.RowHeadersVisible = false;
            this.salesMenuGView.RowTemplate.Height = 23;
            this.salesMenuGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesMenuGView.Size = new System.Drawing.Size(659, 510);
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
            this.MenuPanel.Controls.Add(this.btnClose);
            this.MenuPanel.Controls.Add(this.label12);
            this.MenuPanel.Controls.Add(this.btnSearh);
            this.MenuPanel.Controls.Add(this.btnInsert);
            this.MenuPanel.Controls.Add(this.btnUpdate);
            this.MenuPanel.Controls.Add(this.btnDelete);
            this.MenuPanel.Controls.Add(this.label11);
            this.MenuPanel.Controls.Add(this.label10);
            this.MenuPanel.Controls.Add(this.label9);
            this.MenuPanel.Controls.Add(this.tbxDiscountRatio);
            this.MenuPanel.Controls.Add(this.할인율);
            this.MenuPanel.Controls.Add(this.btnClear);
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
            this.MenuPanel.Controls.Add(this.panel1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPanel.ForeColor = System.Drawing.Color.White;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1270, 172);
            this.MenuPanel.TabIndex = 59;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::GoodeeWay.Properties.Resources.Cancel_64px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1235, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 90;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(448, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 18);
            this.label12.TabIndex = 88;
            this.label12.Text = "초기화";
            // 
            // btnSearh
            // 
            this.btnSearh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearh.FlatAppearance.BorderSize = 0;
            this.btnSearh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSearh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearh.ForeColor = System.Drawing.Color.White;
            this.btnSearh.Image = global::GoodeeWay.Properties.Resources.Search_52px;
            this.btnSearh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearh.Location = new System.Drawing.Point(1023, 89);
            this.btnSearh.Name = "btnSearh";
            this.btnSearh.Size = new System.Drawing.Size(190, 80);
            this.btnSearh.TabIndex = 13;
            this.btnSearh.Text = "검색";
            this.btnSearh.UseVisualStyleBackColor = true;
            this.btnSearh.Click += new System.EventHandler(this.btnMnuSearch_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Image = global::GoodeeWay.Properties.Resources.In_50px;
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(822, 6);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(190, 80);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "등록";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnMnuInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::GoodeeWay.Properties.Resources.Change_Theme_52px;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(1023, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(190, 80);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnMnuUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::GoodeeWay.Properties.Resources.Erase_50px;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(822, 89);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(190, 80);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnMnuDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(264, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 18);
            this.label11.TabIndex = 83;
            this.label11.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(264, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 18);
            this.label10.TabIndex = 82;
            this.label10.Text = "Kcal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(264, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 18);
            this.label9.TabIndex = 81;
            this.label9.Text = "원";
            // 
            // tbxDiscountRatio
            // 
            this.tbxDiscountRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxDiscountRatio.Location = new System.Drawing.Point(94, 127);
            this.tbxDiscountRatio.Name = "tbxDiscountRatio";
            this.tbxDiscountRatio.Size = new System.Drawing.Size(164, 26);
            this.tbxDiscountRatio.TabIndex = 5;
            // 
            // 할인율
            // 
            this.할인율.AutoSize = true;
            this.할인율.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.할인율.ForeColor = System.Drawing.Color.White;
            this.할인율.Location = new System.Drawing.Point(14, 130);
            this.할인율.Name = "할인율";
            this.할인율.Size = new System.Drawing.Size(47, 18);
            this.할인율.TabIndex = 80;
            this.할인율.Text = "할인율";
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClear.Location = new System.Drawing.Point(519, 124);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(35, 35);
            this.btnClear.TabIndex = 9;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbxAddContxt
            // 
            this.tbxAddContxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxAddContxt.Location = new System.Drawing.Point(400, 47);
            this.tbxAddContxt.Multiline = true;
            this.tbxAddContxt.Name = "tbxAddContxt";
            this.tbxAddContxt.Size = new System.Drawing.Size(166, 66);
            this.tbxAddContxt.TabIndex = 7;
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.Location = new System.Drawing.Point(597, 14);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(115, 145);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPhoto.TabIndex = 73;
            this.pbxPhoto.TabStop = false;
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhoto.FlatAppearance.BorderSize = 0;
            this.btnPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPhoto.Location = new System.Drawing.Point(388, 124);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(35, 35);
            this.btnPhoto.TabIndex = 8;
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // cbxDivision
            // 
            this.cbxDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxDivision.FormattingEnabled = true;
            this.cbxDivision.Location = new System.Drawing.Point(400, 17);
            this.cbxDivision.Name = "cbxDivision";
            this.cbxDivision.Size = new System.Drawing.Size(121, 28);
            this.cbxDivision.TabIndex = 6;
            this.cbxDivision.SelectedIndexChanged += new System.EventHandler(this.cbxDivision_SelectedIndexChanged);
            // 
            // tbxKcal
            // 
            this.tbxKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxKcal.Location = new System.Drawing.Point(94, 100);
            this.tbxKcal.Name = "tbxKcal";
            this.tbxKcal.Size = new System.Drawing.Size(164, 26);
            this.tbxKcal.TabIndex = 4;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxPrice.Location = new System.Drawing.Point(94, 73);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(164, 26);
            this.tbxPrice.TabIndex = 3;
            // 
            // tbxMnuName
            // 
            this.tbxMnuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxMnuName.Location = new System.Drawing.Point(94, 45);
            this.tbxMnuName.Name = "tbxMnuName";
            this.tbxMnuName.Size = new System.Drawing.Size(164, 26);
            this.tbxMnuName.TabIndex = 2;
            // 
            // msktbxMnuCode
            // 
            this.msktbxMnuCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.msktbxMnuCode.Location = new System.Drawing.Point(94, 17);
            this.msktbxMnuCode.Mask = "MNU0000000";
            this.msktbxMnuCode.Name = "msktbxMnuCode";
            this.msktbxMnuCode.Size = new System.Drawing.Size(164, 26);
            this.msktbxMnuCode.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(329, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 65;
            this.label7.Text = "부가설명";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(331, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 18);
            this.label6.TabIndex = 64;
            this.label6.Text = "구분";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(329, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 63;
            this.label5.Text = "사진";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 62;
            this.label4.Text = "Kcal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "가격";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "메뉴명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 59;
            this.label1.Text = "메뉴코드";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(7, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 157);
            this.panel1.TabIndex = 91;
            // 
            // lblDivisionExplain
            // 
            this.lblDivisionExplain.AutoSize = true;
            this.lblDivisionExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisionExplain.ForeColor = System.Drawing.Color.Black;
            this.lblDivisionExplain.Location = new System.Drawing.Point(14, 178);
            this.lblDivisionExplain.Name = "lblDivisionExplain";
            this.lblDivisionExplain.Size = new System.Drawing.Size(327, 18);
            this.lblDivisionExplain.TabIndex = 92;
            this.lblDivisionExplain.Text = "구분칸의 숫자가 궁금하다면 이곳에 마우스를 올리세요";
            // 
            // lblRecipeQues
            // 
            this.lblRecipeQues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecipeQues.AutoSize = true;
            this.lblRecipeQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeQues.ForeColor = System.Drawing.Color.Black;
            this.lblRecipeQues.Location = new System.Drawing.Point(1063, 178);
            this.lblRecipeQues.Name = "lblRecipeQues";
            this.lblRecipeQues.Size = new System.Drawing.Size(194, 18);
            this.lblRecipeQues.TabIndex = 93;
            this.lblRecipeQues.Text = "사용량의 단위는 그램(g)입니다.";
            // 
            // USalesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRecipeQues);
            this.Controls.Add(this.lblDivisionExplain);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.FlowPanel);
            this.Controls.Add(this.salesMenuGView);
            this.Name = "USalesMenu";
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
        private System.Windows.Forms.DataGridView salesMenuGView;
        private System.Windows.Forms.OpenFileDialog oFdialogPhoto;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxDiscountRatio;
        private System.Windows.Forms.Label 할인율;
        private System.Windows.Forms.Button btnClear;
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
        private System.Windows.Forms.Button btnSearh;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDivisionExplain;
        private System.Windows.Forms.ToolTip myToolTip;
        private System.Windows.Forms.Label lblRecipeQues;
    }
}
