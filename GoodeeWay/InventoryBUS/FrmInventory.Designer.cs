namespace GoodeeWay.InventoryBUS
{
    partial class FrmInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnOrderDisplay = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnReturnAdd = new System.Windows.Forms.Button();
            this.btnReceiving = new System.Windows.Forms.Button();
            this.pnbReceiving = new System.Windows.Forms.Panel();
            this.btnReceivingDetailsSave = new System.Windows.Forms.Button();
            this.btnLoadingFile = new System.Windows.Forms.Button();
            this.pnmReceiving = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvReceivingDetailsList = new System.Windows.Forms.DataGridView();
            this.dgvReceivingDetails = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvOrderDetailsList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNeedInventoryDetailView = new System.Windows.Forms.DataGridView();
            this.pnmInventory = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvInventoryTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInventoryType = new System.Windows.Forms.DataGridView();
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInventoryTypeAdd = new System.Windows.Forms.Button();
            this.btnInventoryNewSelect = new System.Windows.Forms.Button();
            this.btnNewTable = new System.Windows.Forms.Button();
            this.pnmOrder = new System.Windows.Forms.Panel();
            this.btnSaveOrderDetails = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.pnbReceiving.SuspendLayout();
            this.pnmReceiving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivingDetailsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivingDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeedInventoryDetailView)).BeginInit();
            this.pnmInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryType)).BeginInit();
            this.pnmOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.MenuPanel.Controls.Add(this.btnReturnAdd);
            this.MenuPanel.Controls.Add(this.btnOrder);
            this.MenuPanel.Controls.Add(this.btnInventory);
            this.MenuPanel.Controls.Add(this.btnReceiving);
            this.MenuPanel.Controls.Add(this.btnOrderDisplay);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1100, 70);
            this.MenuPanel.TabIndex = 19;
            // 
            // btnOrderDisplay
            // 
            this.btnOrderDisplay.FlatAppearance.BorderSize = 0;
            this.btnOrderDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnOrderDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderDisplay.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDisplay.ForeColor = System.Drawing.Color.White;
            this.btnOrderDisplay.Image = global::GoodeeWay.Properties.Resources.산출;
            this.btnOrderDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderDisplay.Location = new System.Drawing.Point(897, 0);
            this.btnOrderDisplay.Name = "btnOrderDisplay";
            this.btnOrderDisplay.Size = new System.Drawing.Size(203, 70);
            this.btnOrderDisplay.TabIndex = 13;
            this.btnOrderDisplay.Text = "발주내역산출";
            this.btnOrderDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderDisplay.UseVisualStyleBackColor = true;
            this.btnOrderDisplay.Click += new System.EventHandler(this.btnOrderDisplay_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Image = global::GoodeeWay.Properties.Resources.발주1;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(290, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(129, 65);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "발주";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = global::GoodeeWay.Properties.Resources.재고2;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(147, 3);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(129, 65);
            this.btnInventory.TabIndex = 10;
            this.btnInventory.Text = "재고";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnReturnAdd
            // 
            this.btnReturnAdd.FlatAppearance.BorderSize = 0;
            this.btnReturnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnReturnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnAdd.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnAdd.ForeColor = System.Drawing.Color.White;
            this.btnReturnAdd.Image = global::GoodeeWay.Properties.Resources.반품;
            this.btnReturnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnAdd.Location = new System.Drawing.Point(900, 2);
            this.btnReturnAdd.Name = "btnReturnAdd";
            this.btnReturnAdd.Size = new System.Drawing.Size(200, 65);
            this.btnReturnAdd.TabIndex = 9;
            this.btnReturnAdd.Text = "반품추가";
            this.btnReturnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnAdd.UseVisualStyleBackColor = true;
            this.btnReturnAdd.Click += new System.EventHandler(this.btnReturnAdd_Click);
            // 
            // btnReceiving
            // 
            this.btnReceiving.FlatAppearance.BorderSize = 0;
            this.btnReceiving.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnReceiving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiving.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiving.ForeColor = System.Drawing.Color.White;
            this.btnReceiving.Image = global::GoodeeWay.Properties.Resources.입고11;
            this.btnReceiving.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceiving.Location = new System.Drawing.Point(4, 2);
            this.btnReceiving.Name = "btnReceiving";
            this.btnReceiving.Size = new System.Drawing.Size(129, 65);
            this.btnReceiving.TabIndex = 5;
            this.btnReceiving.Text = "입고";
            this.btnReceiving.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceiving.UseVisualStyleBackColor = true;
            this.btnReceiving.Click += new System.EventHandler(this.btnReceiving_Click);
            // 
            // pnbReceiving
            // 
            this.pnbReceiving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.pnbReceiving.Controls.Add(this.btnSaveOrderDetails);
            this.pnbReceiving.Controls.Add(this.btnExcelExport);
            this.pnbReceiving.Controls.Add(this.btnDelete);
            this.pnbReceiving.Controls.Add(this.btnUpdateOrder);
            this.pnbReceiving.Controls.Add(this.btnRelease);
            this.pnbReceiving.Controls.Add(this.btnUpdate);
            this.pnbReceiving.Controls.Add(this.btnAddOrder);
            this.pnbReceiving.Controls.Add(this.btnInventoryTypeAdd);
            this.pnbReceiving.Controls.Add(this.btnNewTable);
            this.pnbReceiving.Controls.Add(this.btnInventoryNewSelect);
            this.pnbReceiving.Controls.Add(this.btnLoadingFile);
            this.pnbReceiving.Controls.Add(this.btnReceivingDetailsSave);
            this.pnbReceiving.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnbReceiving.Location = new System.Drawing.Point(0, 660);
            this.pnbReceiving.Name = "pnbReceiving";
            this.pnbReceiving.Size = new System.Drawing.Size(1100, 70);
            this.pnbReceiving.TabIndex = 20;
            // 
            // btnReceivingDetailsSave
            // 
            this.btnReceivingDetailsSave.FlatAppearance.BorderSize = 0;
            this.btnReceivingDetailsSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnReceivingDetailsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceivingDetailsSave.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceivingDetailsSave.ForeColor = System.Drawing.Color.White;
            this.btnReceivingDetailsSave.Image = global::GoodeeWay.Properties.Resources.저장;
            this.btnReceivingDetailsSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceivingDetailsSave.Location = new System.Drawing.Point(841, 3);
            this.btnReceivingDetailsSave.Name = "btnReceivingDetailsSave";
            this.btnReceivingDetailsSave.Size = new System.Drawing.Size(260, 65);
            this.btnReceivingDetailsSave.TabIndex = 10;
            this.btnReceivingDetailsSave.Text = "입고내역 저장";
            this.btnReceivingDetailsSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceivingDetailsSave.UseVisualStyleBackColor = true;
            this.btnReceivingDetailsSave.Click += new System.EventHandler(this.btnReceivingDetailsSave_Click);
            // 
            // btnLoadingFile
            // 
            this.btnLoadingFile.FlatAppearance.BorderSize = 0;
            this.btnLoadingFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLoadingFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadingFile.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadingFile.ForeColor = System.Drawing.Color.White;
            this.btnLoadingFile.Image = global::GoodeeWay.Properties.Resources.가져오기;
            this.btnLoadingFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadingFile.Location = new System.Drawing.Point(5, 3);
            this.btnLoadingFile.Name = "btnLoadingFile";
            this.btnLoadingFile.Size = new System.Drawing.Size(189, 65);
            this.btnLoadingFile.TabIndex = 6;
            this.btnLoadingFile.Text = "가져오기";
            this.btnLoadingFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadingFile.UseVisualStyleBackColor = true;
            this.btnLoadingFile.Click += new System.EventHandler(this.btnLoadingFile_Click);
            // 
            // pnmReceiving
            // 
            this.pnmReceiving.BackColor = System.Drawing.Color.White;
            this.pnmReceiving.Controls.Add(this.label6);
            this.pnmReceiving.Controls.Add(this.label5);
            this.pnmReceiving.Controls.Add(this.dgvReceivingDetailsList);
            this.pnmReceiving.Controls.Add(this.dgvReceivingDetails);
            this.pnmReceiving.Location = new System.Drawing.Point(15, 124);
            this.pnmReceiving.Name = "pnmReceiving";
            this.pnmReceiving.Size = new System.Drawing.Size(422, 364);
            this.pnmReceiving.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "입고내역 DetailView";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "입고내역 List";
            // 
            // dgvReceivingDetailsList
            // 
            this.dgvReceivingDetailsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceivingDetailsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvReceivingDetailsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle56.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle56.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle56.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceivingDetailsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle56;
            this.dgvReceivingDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle57.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceivingDetailsList.DefaultCellStyle = dataGridViewCellStyle57;
            this.dgvReceivingDetailsList.Location = new System.Drawing.Point(5, 18);
            this.dgvReceivingDetailsList.Name = "dgvReceivingDetailsList";
            this.dgvReceivingDetailsList.ReadOnly = true;
            this.dgvReceivingDetailsList.RowHeadersVisible = false;
            this.dgvReceivingDetailsList.RowTemplate.Height = 23;
            this.dgvReceivingDetailsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvReceivingDetailsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceivingDetailsList.ShowEditingIcon = false;
            this.dgvReceivingDetailsList.Size = new System.Drawing.Size(125, 561);
            this.dgvReceivingDetailsList.TabIndex = 29;
            // 
            // dgvReceivingDetails
            // 
            this.dgvReceivingDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceivingDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvReceivingDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle58.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle58.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceivingDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle58;
            this.dgvReceivingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle59.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle59.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceivingDetails.DefaultCellStyle = dataGridViewCellStyle59;
            this.dgvReceivingDetails.Location = new System.Drawing.Point(136, 18);
            this.dgvReceivingDetails.MultiSelect = false;
            this.dgvReceivingDetails.Name = "dgvReceivingDetails";
            this.dgvReceivingDetails.ReadOnly = true;
            this.dgvReceivingDetails.RowHeadersVisible = false;
            this.dgvReceivingDetails.RowTemplate.Height = 23;
            this.dgvReceivingDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceivingDetails.Size = new System.Drawing.Size(765, 561);
            this.dgvReceivingDetails.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "발주내역 DetailView";
            // 
            // dgvOrderDetailsList
            // 
            this.dgvOrderDetailsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetailsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderDetailsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle60.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle60.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle60.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetailsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle60;
            this.dgvOrderDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle61.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle61.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle61.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle61.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle61.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle61.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderDetailsList.DefaultCellStyle = dataGridViewCellStyle61;
            this.dgvOrderDetailsList.Location = new System.Drawing.Point(5, 26);
            this.dgvOrderDetailsList.Name = "dgvOrderDetailsList";
            this.dgvOrderDetailsList.ReadOnly = true;
            this.dgvOrderDetailsList.RowHeadersVisible = false;
            this.dgvOrderDetailsList.RowTemplate.Height = 23;
            this.dgvOrderDetailsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetailsList.Size = new System.Drawing.Size(189, 616);
            this.dgvOrderDetailsList.TabIndex = 8;
            this.dgvOrderDetailsList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetailsList_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "발주내역List";
            // 
            // dgvNeedInventoryDetailView
            // 
            this.dgvNeedInventoryDetailView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNeedInventoryDetailView.BackgroundColor = System.Drawing.Color.White;
            this.dgvNeedInventoryDetailView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNeedInventoryDetailView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle62.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle62.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNeedInventoryDetailView.DefaultCellStyle = dataGridViewCellStyle62;
            this.dgvNeedInventoryDetailView.Location = new System.Drawing.Point(200, 26);
            this.dgvNeedInventoryDetailView.MultiSelect = false;
            this.dgvNeedInventoryDetailView.Name = "dgvNeedInventoryDetailView";
            this.dgvNeedInventoryDetailView.RowHeadersVisible = false;
            this.dgvNeedInventoryDetailView.RowTemplate.Height = 23;
            this.dgvNeedInventoryDetailView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNeedInventoryDetailView.Size = new System.Drawing.Size(707, 616);
            this.dgvNeedInventoryDetailView.TabIndex = 9;
            this.dgvNeedInventoryDetailView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvNeedInventoryDetailView_DataError);
            // 
            // pnmInventory
            // 
            this.pnmInventory.BackColor = System.Drawing.Color.White;
            this.pnmInventory.Controls.Add(this.label3);
            this.pnmInventory.Controls.Add(this.dgvInventoryTable);
            this.pnmInventory.Controls.Add(this.label1);
            this.pnmInventory.Controls.Add(this.dgvInventoryType);
            this.pnmInventory.Location = new System.Drawing.Point(515, 106);
            this.pnmInventory.Name = "pnmInventory";
            this.pnmInventory.Size = new System.Drawing.Size(511, 262);
            this.pnmInventory.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "재고테이블";
            // 
            // dgvInventoryTable
            // 
            this.dgvInventoryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventoryTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInventoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle63.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle63.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventoryTable.DefaultCellStyle = dataGridViewCellStyle63;
            this.dgvInventoryTable.Location = new System.Drawing.Point(467, 33);
            this.dgvInventoryTable.MultiSelect = false;
            this.dgvInventoryTable.Name = "dgvInventoryTable";
            this.dgvInventoryTable.ReadOnly = true;
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle64.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle64.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle64.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle64.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle64;
            this.dgvInventoryTable.RowHeadersVisible = false;
            this.dgvInventoryTable.RowTemplate.Height = 23;
            this.dgvInventoryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryTable.Size = new System.Drawing.Size(621, 543);
            this.dgvInventoryTable.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "재고종류";
            // 
            // dgvInventoryType
            // 
            this.dgvInventoryType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryType.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventoryType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInventoryType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle65.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle65.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle65.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle65.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle65.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle65.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventoryType.DefaultCellStyle = dataGridViewCellStyle65;
            this.dgvInventoryType.Location = new System.Drawing.Point(16, 33);
            this.dgvInventoryType.MultiSelect = false;
            this.dgvInventoryType.Name = "dgvInventoryType";
            dataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle66.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle66.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle66.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle66.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle66.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle66.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryType.RowHeadersDefaultCellStyle = dataGridViewCellStyle66;
            this.dgvInventoryType.RowHeadersVisible = false;
            this.dgvInventoryType.RowTemplate.Height = 23;
            this.dgvInventoryType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryType.Size = new System.Drawing.Size(445, 543);
            this.dgvInventoryType.TabIndex = 16;
            // 
            // btnRelease
            // 
            this.btnRelease.FlatAppearance.BorderSize = 0;
            this.btnRelease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelease.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelease.ForeColor = System.Drawing.Color.White;
            this.btnRelease.Image = global::GoodeeWay.Properties.Resources.내역;
            this.btnRelease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelease.Location = new System.Drawing.Point(670, 0);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(241, 70);
            this.btnRelease.TabIndex = 14;
            this.btnRelease.Text = "재고사용내역";
            this.btnRelease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::GoodeeWay.Properties.Resources.제거;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(368, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 70);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "제거";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::GoodeeWay.Properties.Resources.수정;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(261, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 70);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInventoryTypeAdd
            // 
            this.btnInventoryTypeAdd.FlatAppearance.BorderSize = 0;
            this.btnInventoryTypeAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnInventoryTypeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryTypeAdd.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryTypeAdd.ForeColor = System.Drawing.Color.White;
            this.btnInventoryTypeAdd.Image = global::GoodeeWay.Properties.Resources.추가11;
            this.btnInventoryTypeAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventoryTypeAdd.Location = new System.Drawing.Point(155, 0);
            this.btnInventoryTypeAdd.Name = "btnInventoryTypeAdd";
            this.btnInventoryTypeAdd.Size = new System.Drawing.Size(104, 70);
            this.btnInventoryTypeAdd.TabIndex = 11;
            this.btnInventoryTypeAdd.Text = "추가";
            this.btnInventoryTypeAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInventoryTypeAdd.UseVisualStyleBackColor = true;
            this.btnInventoryTypeAdd.Click += new System.EventHandler(this.btnInventoryTypeAdd_Click);
            // 
            // btnInventoryNewSelect
            // 
            this.btnInventoryNewSelect.FlatAppearance.BorderSize = 0;
            this.btnInventoryNewSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnInventoryNewSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryNewSelect.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryNewSelect.ForeColor = System.Drawing.Color.White;
            this.btnInventoryNewSelect.Image = global::GoodeeWay.Properties.Resources.새로고침1;
            this.btnInventoryNewSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventoryNewSelect.Location = new System.Drawing.Point(914, 0);
            this.btnInventoryNewSelect.Name = "btnInventoryNewSelect";
            this.btnInventoryNewSelect.Size = new System.Drawing.Size(187, 70);
            this.btnInventoryNewSelect.TabIndex = 10;
            this.btnInventoryNewSelect.Text = "새로고침";
            this.btnInventoryNewSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInventoryNewSelect.UseVisualStyleBackColor = true;
            this.btnInventoryNewSelect.Click += new System.EventHandler(this.btnInventoryNewSelect_Click);
            // 
            // btnNewTable
            // 
            this.btnNewTable.FlatAppearance.BorderSize = 0;
            this.btnNewTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNewTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTable.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTable.ForeColor = System.Drawing.Color.White;
            this.btnNewTable.Image = global::GoodeeWay.Properties.Resources.새로고침;
            this.btnNewTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewTable.Location = new System.Drawing.Point(0, 0);
            this.btnNewTable.Name = "btnNewTable";
            this.btnNewTable.Size = new System.Drawing.Size(153, 70);
            this.btnNewTable.TabIndex = 6;
            this.btnNewTable.Text = "새로고침";
            this.btnNewTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewTable.UseVisualStyleBackColor = true;
            this.btnNewTable.Click += new System.EventHandler(this.btnNewTable_Click);
            // 
            // pnmOrder
            // 
            this.pnmOrder.BackColor = System.Drawing.Color.White;
            this.pnmOrder.Controls.Add(this.label2);
            this.pnmOrder.Controls.Add(this.label4);
            this.pnmOrder.Controls.Add(this.dgvNeedInventoryDetailView);
            this.pnmOrder.Controls.Add(this.dgvOrderDetailsList);
            this.pnmOrder.Location = new System.Drawing.Point(515, 374);
            this.pnmOrder.Name = "pnmOrder";
            this.pnmOrder.Size = new System.Drawing.Size(567, 249);
            this.pnmOrder.TabIndex = 33;
            // 
            // btnSaveOrderDetails
            // 
            this.btnSaveOrderDetails.FlatAppearance.BorderSize = 0;
            this.btnSaveOrderDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSaveOrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOrderDetails.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrderDetails.ForeColor = System.Drawing.Color.White;
            this.btnSaveOrderDetails.Image = global::GoodeeWay.Properties.Resources.저장1;
            this.btnSaveOrderDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveOrderDetails.Location = new System.Drawing.Point(708, 1);
            this.btnSaveOrderDetails.Name = "btnSaveOrderDetails";
            this.btnSaveOrderDetails.Size = new System.Drawing.Size(207, 70);
            this.btnSaveOrderDetails.TabIndex = 12;
            this.btnSaveOrderDetails.Text = "발주내역저장";
            this.btnSaveOrderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveOrderDetails.UseVisualStyleBackColor = true;
            this.btnSaveOrderDetails.Click += new System.EventHandler(this.btnSaveOrderDetails_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.FlatAppearance.BorderSize = 0;
            this.btnUpdateOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnUpdateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateOrder.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOrder.ForeColor = System.Drawing.Color.White;
            this.btnUpdateOrder.Image = global::GoodeeWay.Properties.Resources.수정;
            this.btnUpdateOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateOrder.Location = new System.Drawing.Point(159, 0);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(207, 70);
            this.btnUpdateOrder.TabIndex = 11;
            this.btnUpdateOrder.Text = "수정내용저장";
            this.btnUpdateOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.FlatAppearance.BorderSize = 0;
            this.btnExcelExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnExcelExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelExport.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelExport.ForeColor = System.Drawing.Color.White;
            this.btnExcelExport.Image = global::GoodeeWay.Properties.Resources.excel;
            this.btnExcelExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelExport.Location = new System.Drawing.Point(918, 1);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(182, 70);
            this.btnExcelExport.TabIndex = 10;
            this.btnExcelExport.Text = "Excel추출";
            this.btnExcelExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcelExport.UseVisualStyleBackColor = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.FlatAppearance.BorderSize = 0;
            this.btnAddOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Image = global::GoodeeWay.Properties.Resources.추가11;
            this.btnAddOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddOrder.Location = new System.Drawing.Point(0, 0);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(153, 70);
            this.btnAddOrder.TabIndex = 6;
            this.btnAddOrder.Text = "발주추가";
            this.btnAddOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnmReceiving);
            this.Controls.Add(this.pnbReceiving);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.pnmOrder);
            this.Controls.Add(this.pnmInventory);
            this.Name = "FrmInventory";
            this.Size = new System.Drawing.Size(1100, 730);
            this.MenuPanel.ResumeLayout(false);
            this.pnbReceiving.ResumeLayout(false);
            this.pnmReceiving.ResumeLayout(false);
            this.pnmReceiving.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivingDetailsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivingDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeedInventoryDetailView)).EndInit();
            this.pnmInventory.ResumeLayout(false);
            this.pnmInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryType)).EndInit();
            this.pnmOrder.ResumeLayout(false);
            this.pnmOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button btnReturnAdd;
        private System.Windows.Forms.Button btnReceiving;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel pnbReceiving;
        private System.Windows.Forms.Button btnReceivingDetailsSave;
        private System.Windows.Forms.Button btnLoadingFile;
        private System.Windows.Forms.Panel pnmReceiving;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvOrderDetailsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNeedInventoryDetailView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvReceivingDetailsList;
        private System.Windows.Forms.DataGridView dgvReceivingDetails;
        private System.Windows.Forms.Panel pnmInventory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvInventoryTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInventoryType;
        private System.Windows.Forms.Button btnInventoryNewSelect;
        private System.Windows.Forms.Button btnNewTable;
        private System.Windows.Forms.Button btnInventoryTypeAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Panel pnmOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnExcelExport;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnOrderDisplay;
        private System.Windows.Forms.Button btnSaveOrderDetails;
    }
}
