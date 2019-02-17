using GoodeeWay.DAO;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GoodeeWay.Sales
{
    public partial class FrmSalesMenu : Form
    {
        FlowLayoutPanel breadPanel;
        FlowLayoutPanel cheesePanel;
        FlowLayoutPanel vegetablePanel;
        FlowLayoutPanel saucePanel;
        FlowLayoutPanel toppingPanel;
        FlowLayoutPanel additionalPanel;
        NumericUpDown nmrUpDownBread;
        NumericUpDown nmrUpDownCheese;
        NumericUpDown nmrUpDownVege;
        NumericUpDown nmrUpDownSauce;
        NumericUpDown nmrUpDownTopping;
        NumericUpDown nmrUpDownAdd;
        DataTable inventoryTypeTable;
        PictureBox picturePanel;
        List<InventoryTypeVO> inventoryTypeList = new List<InventoryTypeVO>();
        List<SalesMenuVO> salesMenuList = new List<SalesMenuVO>();

        string oldMenuCode;
        int oldDivision;
        public FrmSalesMenu()
        {
            InitializeComponent();
        }

        private void FrmSalesMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            FlowPanel.BorderStyle = BorderStyle.FixedSingle; //플로우차트의 테두리 스타일.
            salesMenuGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            salesMenuGView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            salesMenuList = new SalesMenuDAO().OutPutAllMenus();
            salesMenuGView.DataSource = salesMenuList;
            salesMenuGView.Columns[0].HeaderText = "메뉴코드";
            salesMenuGView.Columns[1].HeaderText = "메뉴명";
            salesMenuGView.Columns[2].HeaderText = "가격";
            salesMenuGView.Columns[3].HeaderText = "Kcal";
            salesMenuGView.Columns[4].HeaderText = "이미지";
            salesMenuGView.Columns[5].HeaderText = "구분";
            salesMenuGView.Columns[6].HeaderText = "부가설명";
            salesMenuGView.Columns[7].HeaderText = "할인율";
            foreach (Division item in Enum.GetValues(typeof(Division))) //Enum Type 반복하며 ComboBox에 등록.
            {
                cbxDivision.Items.Add(item);
            }

            //InventoryTypeDAO에 정의되어있는 InventoryTypeSelect() 메서드를호출하여 
            //InventoryType테이블의 데이터를Datatable에 저장한다.
            inventoryTypeTable = new InventoryTypeDAO().InventoryTypeSelect();
            foreach (DataRow item in inventoryTypeTable.Rows)//데이터 테이블의 로우의만큼 반복하며
            {
                
                inventoryTypeList.Add(new InventoryTypeVO()//inventoryTypeList에 저장한다.
                {
                    InventoryName = item[1].ToString(),
                    InventoryTypeCode = item[0].ToString(),
                    MaterialClassification = item[6].ToString(),
                    ReceivingQuantity = int.Parse(item[2].ToString()),
                    MinimumQuantity = int.Parse(item[3].ToString()),
                });
            }
        }

        private void btnMnuInsert_Click(object sender, EventArgs e)
        {
            //메뉴를 등록하기 이전 유효성 검사를 하기위해 컨트롤들의 내용의 공백을 제거하거나 이미지를 지정한다..
            string menuCode = msktbxMnuCode.Text;
            string menuName = tbxMnuName.Text.Replace(" ", "").Trim();
            string price = tbxPrice.Text.Replace(",", "").Trim();
            string kcal = tbxKcal.Text.Replace(" ", "").Trim();
            string division = cbxDivision.Text;
            string addContxt = tbxAddContxt.Text.Trim();
            string discountRatio = tbxDiscountRatio.Text.Replace(",", "").Trim();
            Image image = pbxPhoto.Image;

            
            bool sucessRecipe = false; //레시피 등록 성공여부를 판단하기 위한 bool 변수
            
            bool sucessMenu = false; //메뉴 등록 성공여부를 판단하기 위한 bool 변수/

            
            if (ValidateNull(menuCode, menuName, price, kcal, division, addContxt, discountRatio, image) && ValidateType(price, kcal, discountRatio) && ValidateMenuCode(menuCode))//만약 유효성 검사에 통과 한다면
            {
                //만약 선택된 분류가 샌드위치가 아니라면
                if (cbxDivision.SelectedIndex != 0)
                {
                    //메뉴를 등록하고 메뉴등록 성공여부를 반환한다.
                    sucessMenu = InsertingMenu(menuCode, menuName, price, kcal, division, addContxt, discountRatio, image, sucessMenu);
                }
                //만약 선택된 분류가 샌드위치라면
                else
                {
                    //메뉴를 등록하고 메뉴 등록성공여부를 반환 후
                    sucessMenu = InsertingMenu(menuCode, menuName, price, kcal, division, addContxt, discountRatio, image, sucessMenu);
                    if (!sucessMenu)
                    {
                        return;
                    }
                    //그 메뉴코드에 해당하는 레시피들을 등록하고 레시피 등록 성공 여부를 반환한다.
                    sucessRecipe = InsertingRecipe(menuCode, sucessRecipe);
                }
                btnClear_Click(null, null);//모든 컨트롤 내용 초기화.
            }

            if (sucessMenu && !sucessRecipe) //만약 메뉴만 등록되었다면
            {
                MessageBox.Show("저장 성공!");
            }
            else if (sucessMenu && sucessRecipe) //메뉴와 레시피가 모두 등록 되었다면.
            {
                MessageBox.Show("저장 성공!(기본 레시피 저장 포함)");
            }
            ReflashData(); //데이터 그리드 뷰 새로고침
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            if (oFdialogPhoto.ShowDialog() != DialogResult.Cancel)
            {
                pbxPhoto.ImageLocation = oFdialogPhoto.FileName;
            }
        }

        private void cbxDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDivision.SelectedIndex != 0)//만약 샌드위치가 아니라면 
            {
                FlowPanel.Controls.Clear();
                picturePanel = new PictureBox();
                picturePanel.BorderStyle = BorderStyle.Fixed3D;
                picturePanel.Dock = DockStyle.Top;
                picturePanel.Size = FlowPanel.Size;
                picturePanel.SizeMode = PictureBoxSizeMode.StretchImage;
                picturePanel.Image = Properties.Resources.GoodeeWayHead;
                FlowPanel.Controls.Add(picturePanel);
            }
            else
            {
                FlowPanel.Controls.Clear();
                breadPanel = new FlowLayoutPanel();
                cheesePanel = new FlowLayoutPanel();
                vegetablePanel = new FlowLayoutPanel();
                saucePanel = new FlowLayoutPanel();
                toppingPanel = new FlowLayoutPanel();
                additionalPanel = new FlowLayoutPanel();

                breadPanel.AutoSize = cheesePanel.AutoSize = vegetablePanel.AutoSize = saucePanel.AutoSize = toppingPanel.AutoSize = additionalPanel.AutoSize = true;
                breadPanel.BorderStyle = cheesePanel.BorderStyle = vegetablePanel.BorderStyle = saucePanel.BorderStyle = toppingPanel.BorderStyle = additionalPanel.BorderStyle = BorderStyle.FixedSingle;

                //라벨 동적 생성
                Label lblBread = new Label();
                lblBread.Text = "빵";

                Label lblcheese = new Label();
                lblcheese.Text = "치즈";

                Label lblvege = new Label();
                lblvege.Text = "채소";

                Label lblsause = new Label();
                lblsause.Text = "소스";

                Label lbltopping = new Label();
                lbltopping.Text = "토핑";

                Label lbladd = new Label();
                lbladd.Text = "부가";

                //라벨의 형식을 지정
                NameLabelFormatter(lblBread, lblcheese, lblvege, lblsause, lbltopping, lbladd);

                //라벨들을 각각의 판넬의 컨트롤에 추가
                breadPanel.Controls.Add(lblBread);
                cheesePanel.Controls.Add(lblcheese);
                vegetablePanel.Controls.Add(lblvege);
                saucePanel.Controls.Add(lblsause);
                toppingPanel.Controls.Add(lbltopping);
                additionalPanel.Controls.Add(lbladd);
                
                foreach (InventoryTypeVO inventoryType in inventoryTypeList)//inventoryTypeList를 반복하며
                {
                    if (inventoryType.MaterialClassification == "Bread") //만약 재료 구분이 Bread라면
                    {
                        //라디오버튼
                        RadioButton radioBread = new RadioButton();
                        radioBread.Text = inventoryType.InventoryName;
                        radioBread.Name = inventoryType.InventoryTypeCode;
                        radioBread.CheckedChanged += Radio_CheckedChanged;
                        //라벨
                        Label labelBread = new Label();
                        MaterialLabelFormatter(labelBread);
                        //뉴메릭
                        nmrUpDownBread = new NumericUpDown();
                        nmrUpDownBread.Size = new Size(40, 21);
                        nmrUpDownBread.Name = inventoryType.InventoryTypeCode;
                        nmrUpDownBread.Enabled = false;
                        breadPanel.Controls.AddRange(new Control[] { radioBread, labelBread, nmrUpDownBread });

                    }
                    if (inventoryType.MaterialClassification == "Cheese")
                    {
                        RadioButton radioCheese = new RadioButton();
                        radioCheese.Text = inventoryType.InventoryName;
                        radioCheese.Name = inventoryType.InventoryTypeCode;
                        radioCheese.CheckedChanged += Radio_CheckedChanged;
                        Label labelCheese = new Label();
                        MaterialLabelFormatter(labelCheese);
                        //뉴메릭
                        nmrUpDownCheese = new NumericUpDown();
                        nmrUpDownCheese.Size = new Size(40, 21);
                        nmrUpDownCheese.Name = inventoryType.InventoryTypeCode;
                        nmrUpDownCheese.Enabled = false;
                        cheesePanel.Controls.AddRange(new Control[] { radioCheese, labelCheese, nmrUpDownCheese });
                    }
                    if (inventoryType.MaterialClassification == "Vegetable")
                    {
                        CheckBox cbxVege = new CheckBox();
                        cbxVege.Text = inventoryType.InventoryName;
                        cbxVege.Name = inventoryType.InventoryTypeCode;
                        cbxVege.CheckedChanged += Cbx_CheckedChanged;
                        Label labelVege = new Label();
                        MaterialLabelFormatter(labelVege);
                        //뉴메릭
                        nmrUpDownVege = new NumericUpDown();
                        nmrUpDownVege.Size = new Size(40, 21);
                        nmrUpDownVege.Name = inventoryType.InventoryTypeCode;
                        nmrUpDownVege.Enabled = false;
                        vegetablePanel.Controls.AddRange(new Control[] { cbxVege, labelVege, nmrUpDownVege });
                    }
                    if (inventoryType.MaterialClassification == "Sauce")
                    {
                        CheckBox cbxSauce = new CheckBox();
                        cbxSauce.Text = inventoryType.InventoryName;
                        cbxSauce.Name = inventoryType.InventoryTypeCode;
                        cbxSauce.CheckedChanged += Cbx_CheckedChanged;
                        Label labelSauce = new Label();
                        MaterialLabelFormatter(labelSauce);
                        //뉴메릭
                        nmrUpDownSauce = new NumericUpDown();
                        nmrUpDownSauce.Size = new Size(40, 21);
                        nmrUpDownSauce.Name = inventoryType.InventoryTypeCode;
                        nmrUpDownSauce.Enabled = false;
                        saucePanel.Controls.AddRange(new Control[] { cbxSauce, labelSauce, nmrUpDownSauce });
                    }
                    if (inventoryType.MaterialClassification == "Topping")
                    {
                        CheckBox cbxTopping = new CheckBox();
                        cbxTopping.Text = inventoryType.InventoryName;
                        cbxTopping.Name = inventoryType.InventoryTypeCode;
                        cbxTopping.CheckedChanged += Cbx_CheckedChanged;
                        Label labelTopping = new Label();
                        MaterialLabelFormatter(labelTopping);
                        //뉴메릭
                        nmrUpDownTopping = new NumericUpDown();
                        nmrUpDownTopping.Size = new Size(40, 21);
                        nmrUpDownTopping.Name = inventoryType.InventoryTypeCode;
                        nmrUpDownTopping.Enabled = false;
                        toppingPanel.Controls.AddRange(new Control[] { cbxTopping, labelTopping, nmrUpDownTopping });
                    }
                    if (inventoryType.MaterialClassification == "Additional")
                    {
                        CheckBox cbxAdd = new CheckBox();
                        cbxAdd.Text = inventoryType.InventoryName;
                        cbxAdd.Name = inventoryType.InventoryTypeCode;
                        cbxAdd.CheckedChanged += Cbx_CheckedChanged;
                        Label labelAdd = new Label();
                        MaterialLabelFormatter(labelAdd);
                        //뉴메릭
                        nmrUpDownAdd = new NumericUpDown();
                        nmrUpDownAdd.Size = new Size(40, 21);
                        nmrUpDownAdd.Name = inventoryType.InventoryTypeCode;
                        nmrUpDownAdd.Enabled = false;
                        additionalPanel.Controls.AddRange(new Control[] { cbxAdd, labelAdd, nmrUpDownAdd });
                    }
                }
                (breadPanel.Controls[1] as RadioButton).Checked = (cheesePanel.Controls[1] as RadioButton).Checked = true; // 패널의 라디오버튼의 첫번째 체크 여부를 true로 초기화
                (breadPanel.Controls[3] as NumericUpDown).Enabled = (cheesePanel.Controls[3] as NumericUpDown).Enabled = true; //패널의 뉴메릭업다운의 첫번째 Enable를 true 로 초기화
                FlowPanel.Controls.AddRange(new Control[] { breadPanel, cheesePanel, vegetablePanel, saucePanel, toppingPanel, additionalPanel });//동적으로 생성된 패널들을 FlowPanel의 컨트롤에 추가
            }
        }

        private void Cbx_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox radio = sender as CheckBox;
            foreach (FlowLayoutPanel panel in FlowPanel.Controls)
            {
                foreach (var ctrl in panel.Controls)
                {
                    if (ctrl.GetType() == typeof(NumericUpDown))
                    {
                        NumericUpDown nume = ctrl as NumericUpDown;
                        if (nume.Name == radio.Name && radio.Checked)
                        {
                            nume.Enabled = true;
                        }
                        else if (nume.Name == radio.Name && !radio.Checked)
                        {
                            nume.Enabled = false;
                        }
                    }
                }
            }
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            foreach (FlowLayoutPanel panel in FlowPanel.Controls)
            {
                foreach (var ctrl in panel.Controls)
                {
                    if (ctrl.GetType() == typeof(NumericUpDown))  
                    {
                        NumericUpDown nume = ctrl as NumericUpDown;
                        if (nume.Name == radio.Name && radio.Checked)
                        {
                            nume.Enabled = true;
                        }
                        else if (nume.Name == radio.Name && !radio.Checked)
                        {
                            nume.Enabled = false;
                        } 
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            msktbxMnuCode.Text = tbxAddContxt.Text = tbxKcal.Text = tbxMnuName.Text = tbxPrice.Text = tbxDiscountRatio.Text = "";
            pbxPhoto.Image = null;
            cbxDivision.SelectedIndex = -1;
            msktbxMnuCode.Focus();
        }

        private void btnMnuUpdate_Click(object sender, EventArgs e)
        {
            //1. 만약 바뀌기 전 후가 전부 샌드위치이면
            //메뉴 업데이트 -> 레시피 업데이트
            //2. 만약 oldDivision이 샌드위치이고, division이 샌드위치가 아니면
            //레시피 삭제 -> 메뉴 업데이트
            //delete from dbo.Recipe where 메뉴코드 = 올드메뉴코드
            //3. 만약 oldDivision이 샌드위치가 아니고, division이 샌드위치이면
            //메뉴 수정 - > 레시피 등록
            //insert into 메뉴코드 = 메뉴코드 .....
            string menuCode = msktbxMnuCode.Text;
            string menuName = tbxMnuName.Text.Replace(" ", "").Trim();
            string price = tbxPrice.Text.Replace(",", "").Trim();
            string kcal = tbxKcal.Text.Replace(" ", "").Trim();
            string division = cbxDivision.Text.Replace(" ", "").Trim();
            string addContxt = tbxAddContxt.Text.Trim();
            string discountRatio = tbxDiscountRatio.Text.Replace(" ", "").Trim();
            Image image = pbxPhoto.Image;
            bool menuUpdateSucess = false;
            bool successInsertRecipe = false;
            bool sucessUpdateRecipe = false;
            bool sucessdeleteRecipe = false;
            if (ValidateNull(menuCode, menuName, price, kcal, division, addContxt, discountRatio, image) && ValidateType(price, kcal, discountRatio) && ValidateMenuCode(menuCode))
            {
                SalesMenuVO salesMenuVO = new SalesMenuVO();
                salesMenuVO.MenuCode = menuCode;
                salesMenuVO.MenuName = menuName;
                salesMenuVO.Price = float.Parse(price);
                salesMenuVO.Kcal = int.Parse(kcal);
                salesMenuVO.MenuImage = image;
                foreach (Division item in Enum.GetValues(typeof(Division)))
                {
                    if (item.ToString().Equals(division))
                    {
                        salesMenuVO.Division = (int)item;
                    }
                }
                salesMenuVO.AdditionalContext = addContxt;
                salesMenuVO.DiscountRatio = float.Parse(discountRatio);
                //수정전 과 수정후가 같고 그것이 샌드위치이면..
                if (oldDivision == salesMenuVO.Division && oldDivision == 0)
                {
                    menuUpdateSucess = MenuUpdate(salesMenuVO, menuUpdateSucess);
                    sucessUpdateRecipe = RecipeUpdate(menuCode, sucessUpdateRecipe);
                }
                if (oldDivision == 0 && salesMenuVO.Division != 0)
                {
                    try
                    {
                        if (new MenuRecipeDAO().DeleteRecipesByMenuCode(salesMenuVO.MenuCode))
                        {
                            sucessdeleteRecipe = true;
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    menuUpdateSucess = MenuUpdate(salesMenuVO, menuUpdateSucess);
                }
                else if (oldDivision != 0 && salesMenuVO.Division == 0)
                {
                    menuUpdateSucess = MenuUpdate(salesMenuVO, menuUpdateSucess);
                    successInsertRecipe = InsertingRecipe(salesMenuVO.MenuCode, successInsertRecipe);
                }
                else if (oldDivision != 0 && salesMenuVO.Division != 0)
                {
                    menuUpdateSucess = MenuUpdate(salesMenuVO, menuUpdateSucess);
                }

                ReflashData();
            }
            if ((menuUpdateSucess && sucessUpdateRecipe) || menuUpdateSucess)
            {
                MessageBox.Show("레시피 수정 완료");
            }
            else if (menuUpdateSucess && sucessdeleteRecipe)
            {
                MessageBox.Show("메뉴 수정 성공(이전 레시피 삭제)");
            }
            else if (menuUpdateSucess && successInsertRecipe)
            {
                MessageBox.Show("메뉴 수정 성공(추가 레시피 등록)");
            }
            else
            { 
                    MessageBox.Show("수정 실패");
            }
            btnClear_Click(null, null);
        }

        private void btnMnuDelete_Click(object sender, EventArgs e)
        {
            string menuCode = msktbxMnuCode.Text;
            int count = 0;
            foreach (SalesMenuVO item in salesMenuList)
            {
                if (item.MenuCode.Equals(menuCode))
                {
                    count++;
                    break;
                }
            }
            if (ValidateMenuCode(menuCode))
            {
                if (count == 0)
                {
                    MessageBox.Show("삭제하실 메뉴가 없습니다.");
                    return;
                }
                try
                {
                    if (new SalesMenuDAO().DeleteMenu(menuCode))
                    {
                        MessageBox.Show("메뉴 삭제 성공");
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("메뉴 삭제 실패");
                }
            }
            btnClear_Click(null, null);
            ReflashData();
        }

        private void salesMenuGView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                oldMenuCode = msktbxMnuCode.Text = salesMenuGView.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbxMnuName.Text = salesMenuGView.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbxPrice.Text = salesMenuGView.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbxKcal.Text = salesMenuGView.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbxAddContxt.Text = salesMenuGView.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbxDiscountRatio.Text = salesMenuGView.Rows[e.RowIndex].Cells[7].Value.ToString();
                pbxPhoto.Image = salesMenuGView.Rows[e.RowIndex].Cells[4].Value as Image;
                foreach (Division item in Enum.GetValues(typeof(Division)))
                {
                    if (salesMenuGView.Rows[e.RowIndex].Cells[5].Value.Equals((int)item))
                    {
                        cbxDivision.SelectedItem = item;
                        oldDivision = (int)item;
                    }
                }

                if (cbxDivision.SelectedIndex == 0)
                {
                    List<MenuRecipeVO> menuRecipeList = new MenuRecipeDAO().SelectRecipesByMenuCode(msktbxMnuCode.Text);
                    foreach (MenuRecipeVO item in menuRecipeList)
                    {
                        foreach (FlowLayoutPanel panel in FlowPanel.Controls)
                        {
                            foreach (var ctrl in panel.Controls)
                            {
                                if (ctrl.GetType() == typeof(RadioButton))
                                {
                                    RadioButton rbtn = ctrl as RadioButton;
                                    if (item.InventoryTypeCode.Equals(rbtn.Name))
                                    {
                                        rbtn.Checked = item.Necessary;
                                    }
                                }
                                if (ctrl.GetType() == typeof(CheckBox))
                                {
                                    CheckBox cbx = ctrl as CheckBox;
                                    if (item.InventoryTypeCode.Equals(cbx.Name))
                                    {
                                        cbx.Checked = item.Necessary;
                                    }
                                }
                                if (ctrl.GetType() == typeof(NumericUpDown))
                                {
                                    NumericUpDown numeric = ctrl as NumericUpDown;
                                    if (item.InventoryTypeCode.Equals(numeric.Name))
                                    {
                                        numeric.Value = item.IngredientAmount;
                                    }
                                }
                            }
                        }
                    }
                }
                tbxPrice.Focus();
                salesMenuGView.Focus();
            }
        }

        private void tbxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == Convert.ToChar(Keys.Back)) && tbxPrice.Text.Length > 8)
            {
                e.Handled = true;
            }
        }

        private void tbxPrice_Leave(object sender, EventArgs e)
        {
            if (tbxPrice.Text != "")
            {
                string lgsText = tbxPrice.Text;
                if (float.TryParse(tbxPrice.Text, out float price))
                {
                    tbxPrice.Text = Convert.ToDouble(lgsText).ToString("N0");
                }
            }
        }

        private void btnMnuSearch_Click(object sender, EventArgs e)
        {
            FrmSalesMenuSearch menuSearch = new FrmSalesMenuSearch();
            menuSearch.ShowDialog();
        }

        /// <summary>
        /// 메뉴를 등록하기위해 데이터를 받아와 DAO단으로 전송해주는 메서드
        /// </summary>
        /// <param name="menuCode"></param>
        /// <param name="menuName"></param>
        /// <param name="price"></param>
        /// <param name="kcal"></param>
        /// <param name="division"></param>
        /// <param name="addContxt"></param>
        /// <param name="image"></param>
        /// <param name="sucessMenu"></param>
        /// <returns></returns>
        private bool InsertingMenu(string menuCode, string menuName, string price, string kcal, string division, string addContxt, string discountRatio, Image image, bool sucessMenu)
        {
            sucessMenu = false;
            SalesMenuVO salesMenuVO = new SalesMenuVO();
            salesMenuVO.MenuCode = menuCode;
            salesMenuVO.MenuName = menuName;
            salesMenuVO.Price = float.Parse(price);
            salesMenuVO.Kcal = int.Parse(kcal);
            salesMenuVO.MenuImage = image;
            foreach (Division item in Enum.GetValues(typeof(Division)))
            {
                if (item.ToString().Equals(division))
                {
                    salesMenuVO.Division = (int)item;
                }
            }
            salesMenuVO.AdditionalContext = addContxt;
            salesMenuVO.DiscountRatio = float.Parse(discountRatio);
            try
            {
                if (new SalesMenuDAO().InsertMenu(salesMenuVO))
                {
                    sucessMenu = true;
                }
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("PRIMARY"))
                {
                    MessageBox.Show("메뉴코드 혹은 메뉴이름에 중복된 데이터가 있습니다!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return sucessMenu;
        }

        /// <summary>
        /// 메뉴를 업데이트 하는 메서드
        /// </summary>
        /// <param name="salesMenuVO"></param>
        /// <param name="menuUpdateSucess"></param>
        /// <returns></returns>
        private bool MenuUpdate(SalesMenuVO salesMenuVO, bool menuUpdateSucess)
        {
            try
            {
                int result = new SalesMenuDAO().UpdateMenu(salesMenuVO, oldMenuCode);
                if (result < 1)
                {
                    MessageBox.Show(result.ToString());
                    menuUpdateSucess = false;
                }
                else
                {
                    menuUpdateSucess = true;
                }
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("PRIMARY"))
                {
                    MessageBox.Show("메뉴코드 혹은 메뉴이름에 중복된 데이터가 있습니다!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return menuUpdateSucess;
        }

        /// <summary>
        /// 레시피를 등록하기위한 InsertingRecipe 메서드
        /// </summary>
        /// <param name="menuCode"></param>
        /// <param name="sucessRecipe"></param>
        /// <returns></returns>
        private bool InsertingRecipe(string menuCode, bool succRecip)
        {
            int ingrAmount = 0;
            succRecip = false;
            bool necess = false;
            foreach (InventoryTypeVO item in inventoryTypeList)
            {
                MenuRecipeVO menuRecipeVO = new MenuRecipeVO();
                menuRecipeVO.InventoryTypeCode = item.InventoryTypeCode;
                menuRecipeVO.MenuCode = menuCode;
                foreach (FlowLayoutPanel panel in FlowPanel.Controls)
                {
                    foreach (var ctrl in panel.Controls)
                    {
                        if (ctrl.GetType() == typeof(RadioButton))
                        {
                            RadioButton rbtn = ctrl as RadioButton;
                            if (item.InventoryName.Equals(rbtn.Text))
                            {
                                necess = rbtn.Checked;
                            }
                        }
                        if (ctrl.GetType() == typeof(CheckBox))
                        {
                            CheckBox cbx = ctrl as CheckBox;
                            if (item.InventoryName.Equals(cbx.Text))
                            {
                                necess = cbx.Checked;
                            }
                        }
                        if (ctrl.GetType() == typeof(NumericUpDown))
                        {
                            NumericUpDown numeric = ctrl as NumericUpDown;
                            if (item.InventoryTypeCode.Equals(numeric.Name))
                            {
                                ingrAmount = (int)numeric.Value;
                            }
                        }
                    }
                }
                menuRecipeVO.Necessary = necess;
                menuRecipeVO.IngredientAmount = ingrAmount;
                try
                {
                    if (new MenuRecipeDAO().InsertRecipe(menuRecipeVO))
                    {
                        succRecip = true;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return succRecip;
        }

        /// <summary>
        /// 레시피를 업데이트 하는 메서드
        /// </summary>
        /// <param name="menuCode"></param>
        /// <param name="sucessUpdateRecipe"></param>
        /// <returns></returns>
        private bool RecipeUpdate(string menuCode, bool sucessUpdateRecipe)
        {
            bool necess = false;
            int ingrAmount = 0;
            foreach (InventoryTypeVO item in inventoryTypeList)
            {
                MenuRecipeVO menuRecipeVO = new MenuRecipeVO();
                menuRecipeVO.InventoryTypeCode = item.InventoryTypeCode;
                menuRecipeVO.MenuCode = menuCode;
                foreach (FlowLayoutPanel panel in FlowPanel.Controls)
                {
                    foreach (var ctrl in panel.Controls)
                    {
                        if (ctrl.GetType() == typeof(RadioButton))
                        {
                            RadioButton rbtn = ctrl as RadioButton;
                            if (item.InventoryName.Equals(rbtn.Text))
                            {
                                necess = rbtn.Checked;
                            }
                        }
                        if (ctrl.GetType() == typeof(CheckBox))
                        {
                            CheckBox cbx = ctrl as CheckBox;
                            if (item.InventoryName.Equals(cbx.Text))
                            {
                                necess = cbx.Checked;
                            }
                        }
                        if (ctrl.GetType() == typeof(NumericUpDown))
                        {
                            NumericUpDown numeric = ctrl as NumericUpDown;
                            if (item.InventoryTypeCode.Equals(numeric.Name))
                            {
                                ingrAmount = (int)numeric.Value;
                            }
                        }
                    }
                }
                menuRecipeVO.Necessary = necess;
                menuRecipeVO.IngredientAmount = ingrAmount;
                try
                {
                    int result = new MenuRecipeDAO().UpdateRecipes(menuRecipeVO);
                    if (result < 1)
                    {
                        MessageBox.Show("레시피 수정 실패 " + item.InventoryName);
                        sucessUpdateRecipe = false;
                    }
                    else
                    {
                        sucessUpdateRecipe = true;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return sucessUpdateRecipe;
        }

        /// <summary>
        /// 메뉴코드의 유효성검사
        /// </summary>
        /// <param name="menuCode"></param>
        /// <returns></returns>
        private bool ValidateMenuCode(string menuCode)
        {
            bool result = false;

            if (msktbxMnuCode.Text.Substring(3).Replace(" ", "").Length != 7)
            {
                msktbxMnuCode.Focus();
                MessageBox.Show("메뉴코드의 자리수를 맞춰주세요.");
            }
            else
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// Null 유효성 검사 메서드
        /// </summary>
        /// <param name="menuCode"></param>
        /// <param name="menuName"></param>
        /// <param name="price"></param>
        /// <param name="kcal"></param>
        /// <param name="division"></param>
        /// <param name="addContxt"></param>
        /// <param name="image"></param>
        /// <returns></returns>
        private bool ValidateNull(string menuCode, string menuName, string price, string kcal, string division, string addContxt, string discountRatio, Image image)
        {
            bool result = false;
            if (!(string.IsNullOrEmpty(menuCode) || string.IsNullOrEmpty(menuName) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(kcal) || string.IsNullOrEmpty(division) || string.IsNullOrEmpty(addContxt) || string.IsNullOrEmpty(discountRatio) || image == null))
            {
                result = true;
            }
            else
            {
                msktbxMnuCode.Focus();
                MessageBox.Show("값을 모두 입력 해 주세요!");
            }
            return result;
        }

        /// <summary>
        /// 타입 유효성 검사 메서드
        /// </summary>
        /// <param name="price"></param>
        /// <param name="kcal"></param>
        /// <returns></returns>
        private bool ValidateType(string price, string kcal, string discountRatio)
        {
            bool result = false;
            float fprice, fkcal, fdiscountRatio;

            if (float.TryParse(price, out fprice) && float.TryParse(kcal, out fkcal) && float.TryParse(discountRatio, out fdiscountRatio))
            {
                result = true;
            }
            else
            {
                tbxPrice.Focus();
                MessageBox.Show("가격과 칼로리와 할인율은 숫자만 입력 해 주세요!");
            }
            return result;
        }

        /// <summary>
        /// 그리드뷰와 리스트의를 초기화하는 메서드
        /// </summary>
        private void ReflashData()
        {
            salesMenuList.Clear();
            salesMenuGView.DataSource = null;
            salesMenuList = new SalesMenuDAO().OutPutAllMenus();
            salesMenuGView.DataSource = salesMenuList;
            salesMenuGView.Columns[0].HeaderText = "메뉴코드";
            salesMenuGView.Columns[1].HeaderText = "메뉴명";
            salesMenuGView.Columns[2].HeaderText = "가격";
            salesMenuGView.Columns[3].HeaderText = "Kcal";
            salesMenuGView.Columns[4].HeaderText = "이미지";
            salesMenuGView.Columns[5].HeaderText = "구분";
            salesMenuGView.Columns[6].HeaderText = "부가설명";
            salesMenuGView.Columns[7].HeaderText = "할인율";
        }

        private void NameLabelFormatter(params Label[] labels)
        {
            foreach (var item in labels)
            {
                item.Size = new Size(50, 20);
                item.Padding = new Padding(0,8,0,0);
            }
        }

        private void MaterialLabelFormatter(Label label)
        {
            label.Text = "사용량 :";
            label.Padding = new Padding(0, 8, 0, 0);
            label.Size = new Size(50, 20);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
