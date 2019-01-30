using GoodeeWay.DAO;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        public FrmSalesMenu()
        {
            InitializeComponent();
        }

        private void FrmSalesMenu_Load(object sender, EventArgs e)
        {
            cbxDivision.Items.AddRange(new string[] { "샌드위치", "찹샐러드", "사이드", "음료" });

            #region 테스트 코드입니다 ^ㅡ^
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "허니오트",
                InventoryTypeCode = "ST0100",
                MaterialClassification = "Bread",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "하티",
                InventoryTypeCode = "ST0101",
                MaterialClassification = "Bread",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "위트",
                InventoryTypeCode = "ST0102",
                MaterialClassification = "Bread",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "양상추",
                InventoryTypeCode = "ST0103",
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
                InventoryTypeCode = "ST0110",
                MaterialClassification = "Additional",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "토핑쓰",
                InventoryTypeCode = "ST0111",
                MaterialClassification = "Topping",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "토핑스",
                InventoryTypeCode = "ST0112",
                MaterialClassification = "Topping",
                ReceivingQuantity = 200
            });


            #endregion

        }

        private void btnMnuInsert_Click(object sender, EventArgs e)
        {
            string menuCode = msktbxMnuCode.Text;
            string menuName = tbxMnuName.Text;
            string price = tbxPrice.Text;
            string kcal = tbxKcal.Text;
            string division = cbxDivision.Text;
            string addContxt = tbxAddContxt.Text;
            Image image = pbxPhoto.Image;
            bool sucessRecipe = false;
            bool sucessMenu = false;


            if (ValidateNull(menuCode, menuName, price, kcal, division, addContxt, image) && ValidateType(price, kcal))
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
                    bool necess = false;
                    foreach (InventoryTypeVO item in testList)
                    {
                        MenuRecipeVO menuRecipeVO = new MenuRecipeVO();
                        menuRecipeVO.IngredientAmount = 5;
                        menuRecipeVO.InventoryTypeCode = item.InventoryTypeCode;
                        menuRecipeVO.MenuCode = menuCode;
                        foreach (FlowLayoutPanel panel in FlowPanel.Controls)
                        {
                            foreach (var ctrl in panel.Controls)
                            {
                                if (ctrl.GetType() == typeof(RadioButton))
                                {
                                    RadioButton rbtn = ctrl as RadioButton;
                                    if (item.InventoryName.Equals(rbtn.Name))
                                    {
                                        necess = rbtn.Checked;
                                        //MessageBox.Show(necess.ToString());
                                    }
                                }
                                if (ctrl.GetType() == typeof(CheckBox))
                                {
                                    CheckBox cbx = ctrl as CheckBox;
                                    if (item.InventoryName.Equals(cbx.Name))
                                    {
                                        necess = cbx.Checked;
                                        //MessageBox.Show(necess.ToString());
                                    }
                                }
                            }
                        }
                        menuRecipeVO.Necessary = necess;
                        try
                        {
                            if (new MenuRecipeDAO().InsertRecipe(menuRecipeVO))
                            {
                                sucessRecipe = true;
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
            }


            if (cbxDivision.SelectedIndex != 0 && sucessMenu)
            {
                MessageBox.Show("저장 성공!");
            }
            else if (cbxDivision.SelectedIndex == 0 && sucessRecipe)
            {
                MessageBox.Show("저장 성공!(기본 레시피 저장 포함)");
            }
            else
            {
                MessageBox.Show("저장 실패");
            }
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
        /// <param name="sucessMenu"></param>
        /// <returns></returns>
        private bool InsertingMenu(string menuCode, string menuName, string price, string kcal, string division, string addContxt, Image image, bool sucessMenu)
        {
            sucessMenu = false;
            SalesMenuVO salesMenuVO = new SalesMenuVO()
            {
                MenuCode = menuCode,
                MenuName = menuName,
                Price = float.Parse(price),
                Kcal = int.Parse(kcal),
                MenuImage = image,
                Division = division,
                AdditionalContext = addContxt
            };
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
                        RadioButton radioBread = new RadioButton();
                        radioBread.Text = inventoryType.InventoryName;
                        radioBread.Name = inventoryType.InventoryName;
                        Label labelBread = new Label();
                        labelBread.Text = "사용량 : 5g";
                        labelBread.Padding = new Padding(0, 8, 0, 0);
                        labelBread.Size = new Size(70, 50);
                        breadPanel.Controls.Add(radioBread);
                        breadPanel.Controls.Add(labelBread);
                    }
                    if (inventoryType.MaterialClassification == "Cheese")
                    {
                        RadioButton radioCheese = new RadioButton();
                        radioCheese.Text = inventoryType.InventoryName;
                        radioCheese.Name = inventoryType.InventoryName;
                        Label labelCheese = new Label();
                        labelCheese.Text = "사용량 : 5g";
                        labelCheese.Padding = new Padding(0, 8, 0, 0);
                        labelCheese.Size = new Size(70, 50);
                        cheesePanel.Controls.Add(radioCheese);
                        cheesePanel.Controls.Add(labelCheese);
                    }
                    if (inventoryType.MaterialClassification == "Vegetable")
                    {
                        CheckBox cbxVege = new CheckBox();
                        cbxVege.Text = inventoryType.InventoryName;
                        cbxVege.Name = inventoryType.InventoryName;
                        Label labelVege = new Label();
                        labelVege.Text = "사용량 : 5g";
                        labelVege.Padding = new Padding(0, 8, 0, 0);
                        labelVege.Size = new Size(70, 50);
                        vegetablePanel.Controls.Add(cbxVege);
                        vegetablePanel.Controls.Add(labelVege);
                    }
                    if (inventoryType.MaterialClassification == "Sauce")
                    {
                        CheckBox cbxSauce = new CheckBox();
                        cbxSauce.Text = inventoryType.InventoryName;
                        cbxSauce.Name = inventoryType.InventoryName;
                        Label labelSauce = new Label();
                        labelSauce.Text = "사용량 : 5g";
                        labelSauce.Padding = new Padding(0, 8, 0, 0);
                        labelSauce.Size = new Size(70, 50);
                        saucePanel.Controls.Add(cbxSauce);
                        saucePanel.Controls.Add(labelSauce);
                    }
                    if (inventoryType.MaterialClassification == "Topping")
                    {
                        CheckBox cbxTopping = new CheckBox();
                        cbxTopping.Text = inventoryType.InventoryName;
                        cbxTopping.Text = inventoryType.InventoryName;
                        Label labelTopping = new Label();
                        labelTopping.Text = "사용량 : 5g";
                        labelTopping.Padding = new Padding(0, 8, 0, 0);
                        labelTopping.Size = new Size(70, 50);
                        toppingPanel.Controls.Add(cbxTopping);
                        toppingPanel.Controls.Add(labelTopping);
                    }
                    if (inventoryType.MaterialClassification == "Additional")
                    {
                        CheckBox cbxAdd = new CheckBox();
                        cbxAdd.Text = inventoryType.InventoryName;
                        cbxAdd.Text = inventoryType.InventoryName;
                        Label labelAdd = new Label();
                        labelAdd.Text = "사용량 : 5g";
                        labelAdd.Padding = new Padding(0, 8, 0, 0);
                        labelAdd.Size = new Size(70, 50);
                        additionalPanel.Controls.Add(cbxAdd);
                        additionalPanel.Controls.Add(labelAdd);
                    }

                }
                (breadPanel.Controls[1] as RadioButton).Checked = (cheesePanel.Controls[1] as RadioButton).Checked = true;
                FlowPanel.Controls.AddRange(new Control[] { breadPanel, cheesePanel, vegetablePanel, saucePanel, toppingPanel, additionalPanel });
            }
        }
    }
}
