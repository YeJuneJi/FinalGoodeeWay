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
                InventoryTypeCode = "IVT001",
                MaterialClassification = "bread",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "하티",
                InventoryTypeCode = "IVT002",
                MaterialClassification = "bread",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "위트",
                InventoryTypeCode = "IVT003",
                MaterialClassification = "bread",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "양상추",
                InventoryTypeCode = "IVT004",
                MaterialClassification = "vegetable",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "토마토",
                InventoryTypeCode = "IVT005",
                MaterialClassification = "vegetable",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "오이",
                InventoryTypeCode = "IVT006",
                MaterialClassification = "vegetable",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "피망",
                InventoryTypeCode = "IVT007",
                MaterialClassification = "vegetable",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "아메리칸치즈",
                InventoryTypeCode = "IVT008",
                MaterialClassification = "cheese",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "슈레드치즈",
                InventoryTypeCode = "IVT009",
                MaterialClassification = "cheese",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "스위트어니언",
                InventoryTypeCode = "IVT010",
                MaterialClassification = "sauce",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "허니머스터드",
                InventoryTypeCode = "IVT011",
                MaterialClassification = "sauce",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "스위트칠리",
                InventoryTypeCode = "IVT012",
                MaterialClassification = "sauce",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "미트볼",
                InventoryTypeCode = "IVT013",
                MaterialClassification = "additional",
                ReceivingQuantity = 200
            });
            testList.Add(new InventoryTypeVO()
            {
                InventoryName = "폴드포크",
                InventoryTypeCode = "IVT014",
                MaterialClassification = "additional",
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
            

            if (ValidateNull(menuCode, menuName, price, kcal, division, addContxt, image))
            {
                //if (cbxDivision.SelectedIndex == 0)
                //{
                //    MenuRecipeVO menuRecipeVO = new MenuRecipeVO()
                //    {
                //        IngredientAmount = 재고종류.
                //    };
                //}
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
                        MessageBox.Show("등록 성공");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("모두 입력해주세요.");
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
        /// <returns></returns>
        private bool ValidateNull(string menuCode, string menuName, string price, string kcal, string division, string addContxt, Image image)
        {
            bool result = false;
            if (!(string.IsNullOrEmpty(menuCode) || string.IsNullOrEmpty(menuName) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(kcal)|| string.IsNullOrEmpty(division) || string.IsNullOrEmpty(addContxt) || image == null))
            {
                result = true;
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
                FlowLayoutPanel breadPanel = new FlowLayoutPanel();
                FlowLayoutPanel cheesePanel = new FlowLayoutPanel();
                FlowLayoutPanel vegetablePanel = new FlowLayoutPanel();
                FlowLayoutPanel saucePanel = new FlowLayoutPanel();
                FlowLayoutPanel toppingPanel = new FlowLayoutPanel();
                FlowLayoutPanel additionalPanel = new FlowLayoutPanel();
                breadPanel.AutoSize = cheesePanel.AutoSize = vegetablePanel.AutoSize = saucePanel.AutoSize = toppingPanel.AutoSize = additionalPanel.AutoSize = true;

                breadPanel.BorderStyle = cheesePanel.BorderStyle = vegetablePanel.BorderStyle = saucePanel.BorderStyle = toppingPanel.BorderStyle =  additionalPanel.BorderStyle = BorderStyle.FixedSingle;
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

                foreach (InventoryTypeVO inventoryType in testList)
                {
                    if (inventoryType.MaterialClassification == "bread")
                    {
                        RadioButton radioButton = new RadioButton();
                        radioButton.Text = inventoryType.InventoryName;
                        breadPanel.Controls.Add(radioButton);
                    }
                    if (inventoryType.MaterialClassification == "cheese")
                    {
                        RadioButton radioButton = new RadioButton();
                        radioButton.Text = inventoryType.InventoryName;
                        cheesePanel.Controls.Add(radioButton);
                    }
                    if (inventoryType.MaterialClassification == "vegetable")
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Text = inventoryType.InventoryName;
                        vegetablePanel.Controls.Add(checkBox);
                    }
                    if (inventoryType.MaterialClassification == "sauce")
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Text = inventoryType.InventoryName;
                        saucePanel.Controls.Add(checkBox);
                    }
                    if (inventoryType.MaterialClassification == "topping")
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Text = inventoryType.InventoryName;
                        toppingPanel.Controls.Add(checkBox);
                    }
                    if (inventoryType.MaterialClassification == "additional")
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Text = inventoryType.InventoryName;
                        additionalPanel.Controls.Add(checkBox);
                    }

                }
                FlowPanel.Controls.AddRange(new Control[] { breadPanel, cheesePanel, vegetablePanel, saucePanel, toppingPanel, additionalPanel });

            }
        }
    }
}
