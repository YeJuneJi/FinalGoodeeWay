using GoodeeWay.DAO;
using GoodeeWay.VO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.SalesMenu
{
    public partial class FrmSalesMenu : Form
    {
        FlowLayoutPanel breadPanel;
        FlowLayoutPanel cheesePanel;
        FlowLayoutPanel vegetablePanel;
        FlowLayoutPanel saucePanel;
        FlowLayoutPanel toppingPanel;
        FlowLayoutPanel additionalPanel;
        List<InventoryTypeVO> testList = new List<InventoryTypeVO>();
        List<SalesMenuVO> salesMenuList = new List<SalesMenuVO>();
        string oldMenuCode;
        int oldDivision;
        public FrmSalesMenu()
        {
            InitializeComponent();
        }

        private void FrmSalesMenu_Load(object sender, EventArgs e)
        {
            salesMenuGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            salesMenuGView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            salesMenuList = new SalesMenuDAO().OutPutAllMenus();
            salesMenuGView.DataSource = salesMenuList;

            foreach (Division item in Enum.GetValues(typeof(Division))) //Enum Type 반복하며 ComboBox에 등록.
            {
                cbxDivision.Items.Add(item);
            }

            #region 테스트 코드입니다 ^ㅡ^
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "허니오트",
                InventoryTypeCode = "ST0010",
                MaterialClassification = "Bread",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "하티",
                InventoryTypeCode = "ST0011",
                MaterialClassification = "Bread",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "위트",
                InventoryTypeCode = "ST0012",
                MaterialClassification = "Bread",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "양상추",
                InventoryTypeCode = "ST0012",
                MaterialClassification = "Vegetable",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "토마토",
                InventoryTypeCode = "ST0104",
                MaterialClassification = "Vegetable",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "아메리칸치즈",
                InventoryTypeCode = "ST0105",
                MaterialClassification = "Cheese",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "슈레드치즈",
                InventoryTypeCode = "ST0106",
                MaterialClassification = "Cheese",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "스위트어니언",
                InventoryTypeCode = "ST0107",
                MaterialClassification = "Sauce",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "허니머스터드",
                InventoryTypeCode = "ST0108",
                MaterialClassification = "Sauce",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "미트볼",
                InventoryTypeCode = "ST0109",
                MaterialClassification = "Additional",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "폴드포크",
                InventoryTypeCode = "ST0001",
                MaterialClassification = "Additional",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "햄",
                InventoryTypeCode = "ST0113",
                MaterialClassification = "Additional",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "토핑쓰",
                InventoryTypeCode = "ST0013",
                MaterialClassification = "Topping",
                ReceivingQuantity = 300
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "토핑스",
                InventoryTypeCode = "ST0014",
                MaterialClassification = "Topping",
                ReceivingQuantity = 200
            });


            #endregion
        }

        private void btnMnuInsert_Click(object sender, EventArgs e)
        {
            string menuCode = msktbxMnuCode.Text;
            string menuName = tbxMnuName.Text.Replace(" ", "").Trim();
            string price = tbxPrice.Text.Replace(",", "").Trim();
            string kcal = tbxKcal.Text.Replace(" ", "").Trim();
            string division = cbxDivision.Text;
            string addContxt = tbxAddContxt.Text.Trim();
            Image image = pbxPhoto.Image;
            bool sucessRecipe = false;
            bool sucessMenu = false;

            if (ValidateNull(menuCode, menuName, price, kcal, division, addContxt, image) && ValidateType(price, kcal) && ValidateMenuCode(menuCode))
            {
                if (cbxDivision.SelectedIndex != 0)
                {
                    sucessMenu = InsertingMenu(menuCode, menuName, price, kcal, division, addContxt, image, sucessMenu);
                }
                else
                {
                    sucessMenu = InsertingMenu(menuCode, menuName, price, kcal, division, addContxt, image, sucessMenu);
                    if (!sucessMenu)
                    {
                        return;
                    }
                    sucessRecipe = InsertingRecipe(menuCode, sucessRecipe);
                }
                btnClear_Click(null, null);
            }


            if (!sucessRecipe)
            {
                MessageBox.Show("저장 성공!");
            }
            else
            {
                MessageBox.Show("저장 성공!(기본 레시피 저장 포함)");
            }
            ReflashData();
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
            foreach (InventoryTypeVO item in testList)
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
        private bool InsertingMenu(string menuCode, string menuName, string price, string kcal, string division, string addContxt, Image image, bool sucessMenu)
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
        /// 
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
        /// 
        /// </summary>
        /// <param name="menuCode"></param>
        /// <param name="menuName"></param>
        /// <param name="price"></param>
        /// <param name="kcal"></param>
        /// <param name="division"></param>
        /// <param name="addContxt"></param>
        /// <param name="image"></param>
        /// <returns></returns>
        private bool ValidateNull(string menuCode, string menuName, string price, string kcal, string division, string addContxt, Image image)
        {
            bool result = false;
            if (!(string.IsNullOrEmpty(menuCode) || string.IsNullOrEmpty(menuName) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(kcal) || string.IsNullOrEmpty(division) || string.IsNullOrEmpty(addContxt) || image == null))
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
        /// 
        /// </summary>
        /// <param name="price"></param>
        /// <param name="kcal"></param>
        /// <returns></returns>
        private bool ValidateType(string price, string kcal)
        {
            bool result = false;
            float fprice, fkcal;

            if (float.TryParse(price, out fprice) && float.TryParse(kcal, out fkcal))
            {
                result = true;
            }
            else
            {
                tbxPrice.Focus();
                MessageBox.Show("가격과 칼로리는 숫자만 입력 해 주세요!");
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        private void ReflashData()
        {
            salesMenuList.Clear();
            salesMenuGView.DataSource = null;
            salesMenuList = new SalesMenuDAO().OutPutAllMenus();
            salesMenuGView.DataSource = salesMenuList;
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
            if (cbxDivision.SelectedIndex != 0)
            {
                this.Size = new Size(757, 556);
            }
            else
            {
                FlowPanel.Controls.Clear();
                this.Size = new Size(1320, 556);
                breadPanel = new FlowLayoutPanel();
                cheesePanel = new FlowLayoutPanel();
                vegetablePanel = new FlowLayoutPanel();
                saucePanel = new FlowLayoutPanel();
                toppingPanel = new FlowLayoutPanel();
                additionalPanel = new FlowLayoutPanel();
                breadPanel.AutoSize = cheesePanel.AutoSize = vegetablePanel.AutoSize = saucePanel.AutoSize = toppingPanel.AutoSize = additionalPanel.AutoSize = true;
                breadPanel.BorderStyle = cheesePanel.BorderStyle = vegetablePanel.BorderStyle = saucePanel.BorderStyle = toppingPanel.BorderStyle = additionalPanel.BorderStyle = BorderStyle.FixedSingle;
                Label lblBread = new Label();
                lblBread.Text = "빵";
                lblBread.Size = new Size(50, 50);
                lblBread.Padding = new Padding(10);
                breadPanel.Controls.Add(lblBread);

                Label lblcheese = new Label();
                lblcheese.Text = "치즈";
                lblcheese.Size = new Size(50, 50);
                lblcheese.Padding = new Padding(10);
                cheesePanel.Controls.Add(lblcheese);

                Label lblvege = new Label();
                lblvege.Text = "채소";
                lblvege.Size = new Size(50, 50);
                lblvege.Padding = new Padding(10);
                vegetablePanel.Controls.Add(lblvege);

                Label lblsause = new Label();
                lblsause.Text = "소스";
                lblsause.Size = new Size(50, 50);
                lblsause.Padding = new Padding(10);
                saucePanel.Controls.Add(lblsause);

                Label lbltopping = new Label();
                lbltopping.Text = "토핑";
                lbltopping.Size = new Size(50, 50);
                lbltopping.Padding = new Padding(10);
                toppingPanel.Controls.Add(lbltopping);

                Label lbladd = new Label();
                lbladd.Text = "부가";
                lbladd.Size = new Size(50, 50);
                lbladd.Padding = new Padding(10);
                additionalPanel.Controls.Add(lbladd);

                foreach (InventoryTypeVO inventoryType in testList)
                {
                    if (inventoryType.MaterialClassification == "Bread")
                    {
                        //라디오버튼
                        RadioButton radioBread = new RadioButton();
                        radioBread.Text = inventoryType.InventoryName;
                        radioBread.Name = inventoryType.InventoryTypeCode;
                        //라벨
                        Label labelBread = new Label();
                        labelBread.Text = "사용량 :";
                        labelBread.Padding = new Padding(0, 8, 0, 0);
                        labelBread.Size = new Size(50, 20);
                        //뉴메릭
                        NumericUpDown nmrUpDownBread = new NumericUpDown();
                        nmrUpDownBread.Size = new Size(40, 21);
                        nmrUpDownBread.Name = inventoryType.InventoryTypeCode;
                        breadPanel.Controls.Add(radioBread);
                        breadPanel.Controls.Add(labelBread);
                        breadPanel.Controls.Add(nmrUpDownBread);
                    }
                    if (inventoryType.MaterialClassification == "Cheese")
                    {
                        RadioButton radioCheese = new RadioButton();
                        radioCheese.Text = inventoryType.InventoryName;
                        radioCheese.Name = inventoryType.InventoryTypeCode;
                        Label labelCheese = new Label();
                        labelCheese.Text = "사용량 :";
                        labelCheese.Padding = new Padding(0, 8, 0, 0);
                        labelCheese.Size = new Size(50, 20);
                        //뉴메릭
                        NumericUpDown nmrUpDownCheese = new NumericUpDown();
                        nmrUpDownCheese.Size = new Size(40, 21);
                        nmrUpDownCheese.Name = inventoryType.InventoryTypeCode;
                        cheesePanel.Controls.Add(radioCheese);
                        cheesePanel.Controls.Add(labelCheese);
                        cheesePanel.Controls.Add(nmrUpDownCheese);
                    }
                    if (inventoryType.MaterialClassification == "Vegetable")
                    {
                        CheckBox cbxVege = new CheckBox();
                        cbxVege.Text = inventoryType.InventoryName;
                        cbxVege.Name = inventoryType.InventoryTypeCode;
                        Label labelVege = new Label();
                        labelVege.Text = "사용량 :";
                        labelVege.Padding = new Padding(0, 8, 0, 0);
                        labelVege.Size = new Size(50, 20);
                        //뉴메릭
                        NumericUpDown nmrUpDownVege = new NumericUpDown();
                        nmrUpDownVege.Size = new Size(40, 21);
                        nmrUpDownVege.Name = inventoryType.InventoryTypeCode;
                        vegetablePanel.Controls.Add(cbxVege);
                        vegetablePanel.Controls.Add(labelVege);
                        vegetablePanel.Controls.Add(nmrUpDownVege);
                    }
                    if (inventoryType.MaterialClassification == "Sauce")
                    {
                        CheckBox cbxSauce = new CheckBox();
                        cbxSauce.Text = inventoryType.InventoryName;
                        cbxSauce.Name = inventoryType.InventoryTypeCode;
                        Label labelSauce = new Label();
                        labelSauce.Text = "사용량 :";
                        labelSauce.Padding = new Padding(0, 8, 0, 0);
                        labelSauce.Size = new Size(50, 20);
                        //뉴메릭
                        NumericUpDown nmrUpDownSauce = new NumericUpDown();
                        nmrUpDownSauce.Size = new Size(40, 21);
                        nmrUpDownSauce.Name = inventoryType.InventoryTypeCode;
                        saucePanel.Controls.Add(cbxSauce);
                        saucePanel.Controls.Add(labelSauce);
                        saucePanel.Controls.Add(nmrUpDownSauce);
                    }
                    if (inventoryType.MaterialClassification == "Topping")
                    {
                        CheckBox cbxTopping = new CheckBox();
                        cbxTopping.Text = inventoryType.InventoryName;
                        cbxTopping.Name = inventoryType.InventoryTypeCode;
                        Label labelTopping = new Label();
                        labelTopping.Text = "사용량 :";
                        labelTopping.Padding = new Padding(0, 8, 0, 0);
                        labelTopping.Size = new Size(50, 20);
                        //뉴메릭
                        NumericUpDown nmrUpDownTopping = new NumericUpDown();
                        nmrUpDownTopping.Size = new Size(40, 21);
                        nmrUpDownTopping.Name = inventoryType.InventoryTypeCode;
                        toppingPanel.Controls.Add(cbxTopping);
                        toppingPanel.Controls.Add(labelTopping);
                        toppingPanel.Controls.Add(nmrUpDownTopping);
                    }
                    if (inventoryType.MaterialClassification == "Additional")
                    {
                        CheckBox cbxAdd = new CheckBox();
                        cbxAdd.Text = inventoryType.InventoryName;
                        cbxAdd.Name = inventoryType.InventoryTypeCode;
                        Label labelAdd = new Label();
                        labelAdd.Text = "사용량 :";
                        labelAdd.Padding = new Padding(0, 8, 0, 0);
                        labelAdd.Size = new Size(50, 20);
                        //뉴메릭
                        NumericUpDown nmrUpDownAdd = new NumericUpDown();
                        nmrUpDownAdd.Size = new Size(40, 21);
                        nmrUpDownAdd.Name = inventoryType.InventoryTypeCode;
                        additionalPanel.Controls.Add(cbxAdd);
                        additionalPanel.Controls.Add(labelAdd);
                        additionalPanel.Controls.Add(nmrUpDownAdd);
                    }
                }
                (breadPanel.Controls[1] as RadioButton).Checked = (cheesePanel.Controls[1] as RadioButton).Checked = true;
                FlowPanel.Controls.AddRange(new Control[] { breadPanel, cheesePanel, vegetablePanel, saucePanel, toppingPanel, additionalPanel });
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            msktbxMnuCode.Text = tbxAddContxt.Text = tbxKcal.Text = tbxMnuName.Text = tbxPrice.Text = "";
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
            //insert into 메뉴코드 = 어쩌고
            string menuCode = msktbxMnuCode.Text;
            string menuName = tbxMnuName.Text.Replace(" ", "").Trim();
            string price = tbxPrice.Text.Replace(",", "").Trim();
            string kcal = tbxKcal.Text.Replace(" ", "").Trim();
            string division = cbxDivision.Text.Replace(" ", "").Trim();
            string addContxt = tbxAddContxt.Text.Trim();
            Image image = pbxPhoto.Image;
            bool menuUpdateSucess = false;
            bool successInsertRecipe = false;
            bool sucessUpdateRecipe = false;
            bool sucessdeleteRecipe = false;
            if (ValidateNull(menuCode, menuName, price, kcal, division, addContxt, image) && ValidateType(price, kcal) && ValidateMenuCode(menuCode))
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
                //수정전 과 수정후가 같고 그것이 샌드위치이면..
                if (oldDivision == salesMenuVO.Division && oldDivision == 0)
                {
                    menuUpdateSucess = MenuUpdate(salesMenuVO, menuUpdateSucess);
                    sucessUpdateRecipe = RecipeUpdate(menuCode, sucessUpdateRecipe);
                    btnClear_Click(null, null);
                }
                if (oldDivision == 0 && salesMenuVO.Division != 0)
                {
                    try
                    {
                        if (new MenuRecipeDAO().DeleteRecipesByMenuCode(salesMenuVO.MenuCode))
                        {
                            //MessageBox.Show("레시피 삭제 성공");
                            sucessdeleteRecipe = true;
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    menuUpdateSucess = MenuUpdate(salesMenuVO, menuUpdateSucess);
                    btnClear_Click(null, null);
                }
                else if (oldDivision != 0 && salesMenuVO.Division == 0)
                {
                    menuUpdateSucess = MenuUpdate(salesMenuVO, menuUpdateSucess);
                    successInsertRecipe = InsertingRecipe(salesMenuVO.MenuCode, successInsertRecipe);
                    btnClear_Click(null, null);
                }

                ReflashData();
            }
            if (menuUpdateSucess && sucessUpdateRecipe)
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
                MessageBox.Show("test");
            }
        }

        private bool RecipeUpdate(string menuCode, bool sucessUpdateRecipe)
        {
            bool necess = false;
            int ingrAmount = 0;
            foreach (InventoryTypeVO item in testList)
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

        private void salesMenuGView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                oldMenuCode = msktbxMnuCode.Text = salesMenuGView.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbxMnuName.Text = salesMenuGView.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbxPrice.Text = salesMenuGView.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbxKcal.Text = salesMenuGView.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbxAddContxt.Text = salesMenuGView.Rows[e.RowIndex].Cells[6].Value.ToString();
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
    }
}
