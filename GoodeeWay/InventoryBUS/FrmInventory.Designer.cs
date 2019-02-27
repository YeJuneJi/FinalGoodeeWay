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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnReceiving = new System.Windows.Forms.Button();
            this.btnOrderDisplay = new System.Windows.Forms.Button();
            this.btnReturnAdd = new System.Windows.Forms.Button();
            this.pnbReceiving = new System.Windows.Forms.Panel();
            this.btnSaveOrderDetails = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnInventoryNewSelect = new System.Windows.Forms.Button();
            this.btnReceivingDetailsSave = new System.Windows.Forms.Button();
            this.btnNewTable = new System.Windows.Forms.Button();
            this.btnLoadingFile = new System.Windows.Forms.Button();
            this.btnInventoryTypeAdd = new System.Windows.Forms.Button();
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
            this.pnmOrder = new System.Windows.Forms.Panel();
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
            this.MenuPanel.Controls.Add(this.btnOrder);
            this.MenuPanel.Controls.Add(this.btnInventory);
            this.MenuPanel.Controls.Add(this.btnReceiving);
            this.MenuPanel.Controls.Add(this.btnOrderDisplay);
            this.MenuPanel.Controls.Add(this.btnReturnAdd);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1324, 70);
            this.MenuPanel.TabIndex = 19;
            // 
            // btnOrder
            // 
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Image = global::GoodeeWay.Properties.Resources.sjm_order1;
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
            this.btnInventory.Image = global::GoodeeWay.Properties.Resources.sjm_inventory2;
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
            // btnReceiving
            // 
            this.btnReceiving.FlatAppearance.BorderSize = 0;
            this.btnReceiving.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnReceiving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiving.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiving.ForeColor = System.Drawing.Color.White;
            this.btnReceiving.Image = global::GoodeeWay.Properties.Resources.sjm_receiving1;
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
            // btnOrderDisplay
            // 
            this.btnOrderDisplay.FlatAppearance.BorderSize = 0;
            this.btnOrderDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnOrderDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderDisplay.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDisplay.ForeColor = System.Drawing.Color.White;
            this.btnOrderDisplay.Image = global::GoodeeWay.Properties.Resources.sjm_calculate;
            this.btnOrderDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderDisplay.Location = new System.Drawing.Point(995, 0);
            this.btnOrderDisplay.Name = "btnOrderDisplay";
            this.btnOrderDisplay.Size = new System.Drawing.Size(203, 70);
            this.btnOrderDisplay.TabIndex = 13;
            this.btnOrderDisplay.Text = "발주내역산출";
            this.btnOrderDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderDisplay.UseVisualStyleBackColor = true;
            this.btnOrderDisplay.Click += new System.EventHandler(this.btnOrderDisplay_Click);
            // 
            // btnReturnAdd
            // 
            this.btnReturnAdd.FlatAppearance.BorderSize = 0;
            this.btnReturnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnReturnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnAdd.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnAdd.ForeColor = System.Drawing.Color.White;
            this.btnReturnAdd.Image = global::GoodeeWay.Properties.Resources.sjm_return;
            this.btnReturnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnAdd.Location = new System.Drawing.Point(998, 2);
            this.btnReturnAdd.Name = "btnReturnAdd";
            this.btnReturnAdd.Size = new System.Drawing.Size(200, 65);
            this.btnReturnAdd.TabIndex = 9;
            this.btnReturnAdd.Text = "반품추가";
            this.btnReturnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnAdd.UseVisualStyleBackColor = true;
            this.btnReturnAdd.Click += new System.EventHandler(this.btnReturnAdd_Click);
            // 
            // pnbReceiving
            // 
            this.pnbReceiving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.pnbReceiving.Controls.Add(this.btnSaveOrderDetails);
            this.pnbReceiving.Controls.Add(this.btnAddOrder);
            this.pnbReceiving.Controls.Add(this.btnUpdate);
            this.pnbReceiving.Controls.Add(this.btnUpdateOrder);
            this.pnbReceiving.Controls.Add(this.btnDelete);
            this.pnbReceiving.Controls.Add(this.btnExcelExport);
            this.pnbReceiving.Controls.Add(this.btnRelease);
            this.pnbReceiving.Controls.Add(this.btnInventoryNewSelect);
            this.pnbReceiving.Controls.Add(this.btnReceivingDetailsSave);
            this.pnbReceiving.Controls.Add(this.btnNewTable);
            this.pnbReceiving.Controls.Add(this.btnLoadingFile);
            this.pnbReceiving.Controls.Add(this.btnInventoryTypeAdd);
            this.pnbReceiving.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnbReceiving.Location = new System.Drawing.Point(0, 655);
            this.pnbReceiving.Name = "pnbReceiving";
            this.pnbReceiving.Size = new System.Drawing.Size(1324, 70);
            this.pnbReceiving.TabIndex = 20;
            // 
            // btnSaveOrderDetails
            // 
            this.btnSaveOrderDetails.FlatAppearance.BorderSize = 0;
            this.btnSaveOrderDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSaveOrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOrderDetails.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrderDetails.ForeColor = System.Drawing.Color.White;
            this.btnSaveOrderDetails.Image = global::GoodeeWay.Properties.Resources.sjm_save1;
            this.btnSaveOrderDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveOrderDetails.Location = new System.Drawing.Point(786, 0);
            this.btnSaveOrderDetails.Name = "btnSaveOrderDetails";
            this.btnSaveOrderDetails.Size = new System.Drawing.Size(227, 70);
            this.btnSaveOrderDetails.TabIndex = 12;
            this.btnSaveOrderDetails.Text = "발주내역저장";
            this.btnSaveOrderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveOrderDetails.UseVisualStyleBackColor = true;
            this.btnSaveOrderDetails.Click += new System.EventHandler(this.btnSaveOrderDetails_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.FlatAppearance.BorderSize = 0;
            this.btnAddOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Image = global::GoodeeWay.Properties.Resources.sjm_add1;
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
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::GoodeeWay.Properties.Resources.sjm_edit;
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
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.FlatAppearance.BorderSize = 0;
            this.btnUpdateOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnUpdateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateOrder.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOrder.ForeColor = System.Drawing.Color.White;
            this.btnUpdateOrder.Image = global::GoodeeWay.Properties.Resources.sjm_save1;
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
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::GoodeeWay.Properties.Resources.sjm_delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(368, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 70);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "삭제";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.FlatAppearance.BorderSize = 0;
            this.btnExcelExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnExcelExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelExport.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelExport.ForeColor = System.Drawing.Color.White;
            this.btnExcelExport.Image = global::GoodeeWay.Properties.Resources.sjm_excel;
            this.btnExcelExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelExport.Location = new System.Drawing.Point(1016, 0);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(182, 70);
            this.btnExcelExport.TabIndex = 10;
            this.btnExcelExport.Text = "Excel추출";
            this.btnExcelExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcelExport.UseVisualStyleBackColor = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.FlatAppearance.BorderSize = 0;
            this.btnRelease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelease.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelease.ForeColor = System.Drawing.Color.White;
            this.btnRelease.Image = global::GoodeeWay.Properties.Resources.sjm_details;
            this.btnRelease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelease.Location = new System.Drawing.Point(768, -1);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(241, 70);
            this.btnRelease.TabIndex = 14;
            this.btnRelease.Text = "재고사용내역";
            this.btnRelease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnInventoryNewSelect
            // 
            this.btnInventoryNewSelect.FlatAppearance.BorderSize = 0;
            this.btnInventoryNewSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnInventoryNewSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryNewSelect.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryNewSelect.ForeColor = System.Drawing.Color.White;
            this.btnInventoryNewSelect.Image = global::GoodeeWay.Properties.Resources.sjm_refresh1;
            this.btnInventoryNewSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventoryNewSelect.Location = new System.Drawing.Point(1012, -1);
            this.btnInventoryNewSelect.Name = "btnInventoryNewSelect";
            this.btnInventoryNewSelect.Size = new System.Drawing.Size(187, 70);
            this.btnInventoryNewSelect.TabIndex = 10;
            this.btnInventoryNewSelect.Text = "새로고침";
            this.btnInventoryNewSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInventoryNewSelect.UseVisualStyleBackColor = true;
            this.btnInventoryNewSelect.Click += new System.EventHandler(this.btnInventoryNewSelect_Click);
            // 
            // btnReceivingDetailsSave
            // 
            this.btnReceivingDetailsSave.FlatAppearance.BorderSize = 0;
            this.btnReceivingDetailsSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnReceivingDetailsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceivingDetailsSave.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceivingDetailsSave.ForeColor = System.Drawing.Color.White;
            this.btnReceivingDetailsSave.Image = global::GoodeeWay.Properties.Resources.sjm_save2;
            this.btnReceivingDetailsSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceivingDetailsSave.Location = new System.Drawing.Point(939, 2);
            this.btnReceivingDetailsSave.Name = "btnReceivingDetailsSave";
            this.btnReceivingDetailsSave.Size = new System.Drawing.Size(260, 65);
            this.btnReceivingDetailsSave.TabIndex = 10;
            this.btnReceivingDetailsSave.Text = "입고내역 저장";
            this.btnReceivingDetailsSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceivingDetailsSave.UseVisualStyleBackColor = true;
            this.btnReceivingDetailsSave.Click += new System.EventHandler(this.btnReceivingDetailsSave_Click);
            // 
            // btnNewTable
            // 
            this.btnNewTable.FlatAppearance.BorderSize = 0;
            this.btnNewTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNewTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTable.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTable.ForeColor = System.Drawing.Color.White;
            this.btnNewTable.Image = global::GoodeeWay.Properties.Resources.sjm_refresh;
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
            // btnLoadingFile
            // 
            this.btnLoadingFile.FlatAppearance.BorderSize = 0;
            this.btnLoadingFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLoadingFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadingFile.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadingFile.ForeColor = System.Drawing.Color.White;
            this.btnLoadingFile.Image = global::GoodeeWay.Properties.Resources.sjm_import;
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
            // btnInventoryTypeAdd
            // 
            this.btnInventoryTypeAdd.FlatAppearance.BorderSize = 0;
            this.btnInventoryTypeAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnInventoryTypeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryTypeAdd.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryTypeAdd.ForeColor = System.Drawing.Color.White;
            this.btnInventoryTypeAdd.Image = global::GoodeeWay.Properties.Resources.sjm_add11;
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
            // pnmReceiving
            // 
            this.pnmReceiving.BackColor = System.Drawing.Color.White;
            this.pnmReceiving.Controls.Add(this.label6);
            this.pnmReceiving.Controls.Add(this.label5);
            this.pnmReceiving.Controls.Add(this.dgvReceivingDetailsList);
            this.pnmReceiving.Controls.Add(this.dgvReceivingDetails);
            this.pnmReceiving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnmReceiving.Location = new System.Drawing.Point(0, 0);
            this.pnmReceiving.Name = "pnmReceiving";
            this.pnmReceiving.Size = new System.Drawing.Size(1324, 725);
            this.pnmReceiving.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(134, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "입고내역 DetailView";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "입고내역 List";
            // 
            // dgvReceivingDetailsList
            // 
            this.dgvReceivingDetailsList.AllowUserToResizeColumns = false;
            this.dgvReceivingDetailsList.AllowUserToResizeRows = false;
            this.dgvReceivingDetailsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceivingDetailsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvReceivingDetailsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReceivingDetailsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReceivingDetailsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceivingDetailsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvReceivingDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceivingDetailsList.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvReceivingDetailsList.EnableHeadersVisualStyles = false;
            this.dgvReceivingDetailsList.Location = new System.Drawing.Point(5, 27);
            this.dgvReceivingDetailsList.MultiSelect = false;
            this.dgvReceivingDetailsList.Name = "dgvReceivingDetailsList";
            this.dgvReceivingDetailsList.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceivingDetailsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvReceivingDetailsList.RowHeadersVisible = false;
            this.dgvReceivingDetailsList.RowTemplate.Height = 23;
            this.dgvReceivingDetailsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvReceivingDetailsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceivingDetailsList.ShowEditingIcon = false;
            this.dgvReceivingDetailsList.Size = new System.Drawing.Size(125, 550);
            this.dgvReceivingDetailsList.TabIndex = 29;
            this.dgvReceivingDetailsList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReceivingDetailsList_CellMouseDoubleClick);
            // 
            // dgvReceivingDetails
            // 
            this.dgvReceivingDetails.AllowUserToResizeColumns = false;
            this.dgvReceivingDetails.AllowUserToResizeRows = false;
            this.dgvReceivingDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceivingDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvReceivingDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReceivingDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReceivingDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceivingDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvReceivingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceivingDetails.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvReceivingDetails.EnableHeadersVisualStyles = false;
            this.dgvReceivingDetails.Location = new System.Drawing.Point(136, 27);
            this.dgvReceivingDetails.MultiSelect = false;
            this.dgvReceivingDetails.Name = "dgvReceivingDetails";
            this.dgvReceivingDetails.ReadOnly = true;
            this.dgvReceivingDetails.RowHeadersVisible = false;
            this.dgvReceivingDetails.RowTemplate.Height = 23;
            this.dgvReceivingDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceivingDetails.Size = new System.Drawing.Size(765, 550);
            this.dgvReceivingDetails.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(198, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "발주내역 DetailView";
            // 
            // dgvOrderDetailsList
            // 
            this.dgvOrderDetailsList.AllowUserToResizeColumns = false;
            this.dgvOrderDetailsList.AllowUserToResizeRows = false;
            this.dgvOrderDetailsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetailsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderDetailsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOrderDetailsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOrderDetailsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetailsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvOrderDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderDetailsList.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvOrderDetailsList.EnableHeadersVisualStyles = false;
            this.dgvOrderDetailsList.Location = new System.Drawing.Point(5, 27);
            this.dgvOrderDetailsList.MultiSelect = false;
            this.dgvOrderDetailsList.Name = "dgvOrderDetailsList";
            this.dgvOrderDetailsList.ReadOnly = true;
            this.dgvOrderDetailsList.RowHeadersVisible = false;
            this.dgvOrderDetailsList.RowTemplate.Height = 23;
            this.dgvOrderDetailsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetailsList.Size = new System.Drawing.Size(189, 550);
            this.dgvOrderDetailsList.TabIndex = 8;
            this.dgvOrderDetailsList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrderDetailsList_CellMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "발주내역List";
            // 
            // dgvNeedInventoryDetailView
            // 
            this.dgvNeedInventoryDetailView.AllowUserToResizeColumns = false;
            this.dgvNeedInventoryDetailView.AllowUserToResizeRows = false;
            this.dgvNeedInventoryDetailView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNeedInventoryDetailView.BackgroundColor = System.Drawing.Color.White;
            this.dgvNeedInventoryDetailView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNeedInventoryDetailView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvNeedInventoryDetailView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNeedInventoryDetailView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvNeedInventoryDetailView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNeedInventoryDetailView.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvNeedInventoryDetailView.EnableHeadersVisualStyles = false;
            this.dgvNeedInventoryDetailView.Location = new System.Drawing.Point(200, 27);
            this.dgvNeedInventoryDetailView.MultiSelect = false;
            this.dgvNeedInventoryDetailView.Name = "dgvNeedInventoryDetailView";
            this.dgvNeedInventoryDetailView.RowHeadersVisible = false;
            this.dgvNeedInventoryDetailView.RowTemplate.Height = 23;
            this.dgvNeedInventoryDetailView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNeedInventoryDetailView.Size = new System.Drawing.Size(707, 550);
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
            this.pnmInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnmInventory.Location = new System.Drawing.Point(0, 0);
            this.pnmInventory.Name = "pnmInventory";
            this.pnmInventory.Size = new System.Drawing.Size(1324, 725);
            this.pnmInventory.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(509, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "재고테이블";
            // 
            // dgvInventoryTable
            // 
            this.dgvInventoryTable.AllowUserToResizeRows = false;
            this.dgvInventoryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventoryTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInventoryTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInventoryTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvInventoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventoryTable.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvInventoryTable.EnableHeadersVisualStyles = false;
            this.dgvInventoryTable.Location = new System.Drawing.Point(513, 27);
            this.dgvInventoryTable.MultiSelect = false;
            this.dgvInventoryTable.Name = "dgvInventoryTable";
            this.dgvInventoryTable.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvInventoryTable.RowHeadersVisible = false;
            this.dgvInventoryTable.RowTemplate.Height = 23;
            this.dgvInventoryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryTable.Size = new System.Drawing.Size(669, 550);
            this.dgvInventoryTable.TabIndex = 18;
            this.dgvInventoryTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInventoryTable_CellMouseClick);
            this.dgvInventoryTable.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvInventoryTable_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "재고종류";
            // 
            // dgvInventoryType
            // 
            this.dgvInventoryType.AllowUserToResizeRows = false;
            this.dgvInventoryType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryType.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventoryType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInventoryType.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInventoryType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvInventoryType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventoryType.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvInventoryType.EnableHeadersVisualStyles = false;
            this.dgvInventoryType.Location = new System.Drawing.Point(5, 27);
            this.dgvInventoryType.MultiSelect = false;
            this.dgvInventoryType.Name = "dgvInventoryType";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryType.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvInventoryType.RowHeadersVisible = false;
            this.dgvInventoryType.RowTemplate.Height = 23;
            this.dgvInventoryType.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvInventoryType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryType.Size = new System.Drawing.Size(502, 550);
            this.dgvInventoryType.TabIndex = 16;
            // 
            // pnmOrder
            // 
            this.pnmOrder.BackColor = System.Drawing.Color.White;
            this.pnmOrder.Controls.Add(this.label2);
            this.pnmOrder.Controls.Add(this.label4);
            this.pnmOrder.Controls.Add(this.dgvNeedInventoryDetailView);
            this.pnmOrder.Controls.Add(this.dgvOrderDetailsList);
            this.pnmOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnmOrder.Location = new System.Drawing.Point(0, 70);
            this.pnmOrder.Name = "pnmOrder";
            this.pnmOrder.Size = new System.Drawing.Size(1324, 585);
            this.pnmOrder.TabIndex = 33;
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnmOrder);
            this.Controls.Add(this.pnbReceiving);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.pnmInventory);
            this.Controls.Add(this.pnmReceiving);
            this.Name = "FrmInventory";
            this.Size = new System.Drawing.Size(1324, 725);
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
        private System.Windows.Forms.DataGridView dgvReceivingDetailsList;
    }
}
