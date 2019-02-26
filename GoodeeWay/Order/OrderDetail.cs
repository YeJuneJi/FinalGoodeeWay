using GoodeeWay.DAO;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.Order
{
    public partial class OrderDetail : Form
    {
        List<MenuDetail> menuDetailList = new List<MenuDetail>();        

        Menu item;
        List<Menu> bucketMenuList;
        List<MenuDetail> bucketMenuDetailList = new List<MenuDetail>();
        List<MenuAndDetails> bucketMenuAndDetailList;        

        FlowLayoutPanel breadGroup = new FlowLayoutPanel();
        FlowLayoutPanel cheeseGroup = new FlowLayoutPanel();
        FlowLayoutPanel vegetableGroup = new FlowLayoutPanel();
        FlowLayoutPanel sauceGroup = new FlowLayoutPanel();
        FlowLayoutPanel toppingGroup = new FlowLayoutPanel();
        FlowLayoutPanel additionalGroup = new FlowLayoutPanel();

        public OrderDetail()
        {
            InitializeComponent();
        }

        public OrderDetail(Menu item, List<Menu> bucketMenuList, List<MenuAndDetails> bucketMenuAndDetailList) : this()
        {
            this.item = item.Clone();
            this.bucketMenuList = bucketMenuList;            
            this.bucketMenuAndDetailList = bucketMenuAndDetailList;
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {         
            breadGroup.AutoSize = cheeseGroup.AutoSize = vegetableGroup.AutoSize = sauceGroup.AutoSize = toppingGroup.AutoSize = additionalGroup.AutoSize = true;

            breadGroup.BorderStyle = cheeseGroup.BorderStyle = vegetableGroup.BorderStyle = sauceGroup.BorderStyle = toppingGroup.BorderStyle = additionalGroup.BorderStyle = BorderStyle.FixedSingle;

            breadGroup.Name = "Bread";

            // 선택한 메뉴에대한 사항 로드
            try
            {
                menuImage.Image = Image.FromFile(Application.StartupPath + item.MenuImage);
            }
            catch (Exception)
            {
                MessageBox.Show("이미지를 로드 할 수 없습니다. 경로를 확인해 주세요");
            }
            
            lblMenuName.Text = item.MenuName;

            if (item.DiscountRatio != 0)
            {
                lblPrice.Text = "가격 : " + ((decimal)item.Price).ToString() + " 원" + " -> " + " 할인 가격 : " + ((decimal)item.Price - ((decimal)item.Price / (decimal)item.DiscountRatio)).ToString() + "원";
            }
            else
            {
                lblPrice.Text = "가격 : " + ((decimal)item.Price).ToString() + " 원";
            }

            lblKcal.Text = "칼로리 : " + item.Kcal.ToString() + " Kcal";
            
            

            // 메뉴 레시피들을 받아와 리스트에 저장
            menuDetailList = new OrderDetailDAO().getRecipe(item.MenuName, menuDetailList);           

            Label lblBread = new Label();
            lblBread.Text = "빵";

            breadGroup.Controls.Add(lblBread);

            Label lblCheese = new Label();
            lblCheese.Text = "치즈";
            cheeseGroup.Controls.Add(lblCheese);

            Label lblVegetable = new Label();
            lblVegetable.Text = "채소";
            vegetableGroup.Controls.Add(lblVegetable);

            Label lblSauce = new Label();
            lblSauce.Text = "소스";
            sauceGroup.Controls.Add(lblSauce);

            Label lblToping = new Label();
            lblToping.Text = "토핑";
            toppingGroup.Controls.Add(lblToping);

            Label lblAdditional = new Label();
            lblAdditional.Text = "추가";
            additionalGroup.Controls.Add(lblAdditional);

            NameLabelFormatter(lblBread, lblCheese, lblVegetable, lblSauce, lblToping, lblAdditional);

            foreach (MenuDetail item in menuDetailList)
            {
                if (item.Division == "Bread")
                {                    
                    breadGroup.Controls.AddRange(CreateRadioButton(item));
                }
                else if (item.Division == "Cheese")
                {                    
                    cheeseGroup.Controls.AddRange(CreateRadioButton(item));                    
                }
                else if (item.Division == "Vegetable")
                {                    
                    vegetableGroup.Controls.AddRange(CreateCheckBox(item));                    
                }               
                else if (item.Division == "Sauce")
                {
                    sauceGroup.Controls.AddRange(CreateCheckBox(item));                    
                }
                else if (item.Division == "Topping")
                {
                    toppingGroup.Controls.AddRange(CreateCheckBox(item));                    
                }
                else if (item.Division == "Additional")
                {
                    additionalGroup.Controls.AddRange(CreateCheckBox(item));                    
                }
            }            

            flowLayoutPanel1.Controls.AddRange(new Control[] { breadGroup, cheeseGroup, vegetableGroup, sauceGroup, toppingGroup, additionalGroup } );
        }

        private Control[] CreateRadioButton(MenuDetail item)
        {            
            RadioButton rb = new RadioButton();
            rb.Name = item.InventoryName;
            rb.Text = item.InventoryName;
            rb.Checked = item.Compulsory;
            rb.CheckedChanged += Radio_CheckedChanged;

            Label lblAmount = new Label();
            lblAmount.Text = "사용량";
            MaterialLabelFormatter(lblAmount);

            NumericUpDown nudAmount = new NumericUpDown();
            nudAmount.Value = item.Amount;
            nudAmount.Name = item.InventoryName;
            nudAmount.Size = new Size(40, 21);
            nudAmount.Enabled = item.Compulsory;

            return new Control[] { rb, lblAmount, nudAmount };
        }

        private Control[] CreateCheckBox(MenuDetail item)
        {
            CheckBox cb = new CheckBox();
            cb.Name = item.InventoryName;
            cb.Text = item.InventoryName;
            cb.Checked = item.Compulsory;
            cb.CheckedChanged += Cbx_CheckedChanged;

            Label lblAmount = new Label();
            lblAmount.Text = "사용량";
            MaterialLabelFormatter(lblAmount);

            NumericUpDown nudAmount = new NumericUpDown();
            nudAmount.Value = item.Amount;
            nudAmount.Name = item.InventoryName;
            nudAmount.Size = new Size(40, 21);
            nudAmount.Enabled = item.Compulsory;

            return new Control[] { cb, lblAmount, nudAmount };
        }


        private void Cbx_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox radio = sender as CheckBox;
            foreach (FlowLayoutPanel panel in flowLayoutPanel1.Controls)
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
            foreach (FlowLayoutPanel panel in flowLayoutPanel1.Controls)
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


        private void btnOK_Click(object sender, EventArgs e) // 확인 버튼 클릭시 작동
        {            
            bucketMenuList.Add(item);
            CheckState(); // 체크한 레시프들을 저장

            MenuAndDetails menuAndDetails = new MenuAndDetails(); // 레시피들을 저장
            menuAndDetails.Menu = item;
            menuAndDetails.MenuDetailList = bucketMenuDetailList;

            bucketMenuAndDetailList.Add(menuAndDetails);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) // 취소 버튼 클릭시 작동
        {
            this.Close();
        }

        private void NameLabelFormatter(params Label[] labels)
        {
            foreach (var item in labels)
            {
                item.Size = new Size(500, 20);
                item.Padding = new Padding(0, 8, 0, 0);
            }
        }

        private void MaterialLabelFormatter(Label label)
        {
            label.Text = "사용량 :";
            label.Padding = new Padding(0, 8, 0, 0);
            label.Size = new Size(50, 20);
        }

        private void CheckState() // 체크 박스에 얻은 내용 저장
        {
            bucketMenuDetailList.Clear();
            foreach (FlowLayoutPanel panel in flowLayoutPanel1.Controls)
            {
                foreach (var ctrl in panel.Controls)
                {                    
                    if (ctrl.GetType() == typeof(RadioButton))
                    {
                        RadioButton rb = (RadioButton)ctrl;
                        if (rb.Checked)
                        {                            
                            foreach (MenuDetail item in menuDetailList)
                            {
                                if (item.InventoryName.Equals(rb.Name))
                                {
                                    foreach (var item2 in flowLayoutPanel1.Controls.Find(rb.Name, true))
                                    {
                                        if (item2.GetType() == typeof(NumericUpDown))
                                        {
                                            NumericUpDown nn = (NumericUpDown)item2;
                                            item.Amount = (int)nn.Value;
                                        }
                                    }
                                    
                                    bucketMenuDetailList.Add(item);
                                    break;
                                }
                            }
                        }
                    }
                    if (ctrl.GetType() == typeof(CheckBox))
                    {
                        CheckBox cb = (CheckBox)ctrl;
                        if (cb.Checked)
                        {
                            foreach (MenuDetail item in menuDetailList)
                            {
                                if (item.InventoryName.Equals(cb.Name))
                                {
                                    foreach (var item2 in flowLayoutPanel1.Controls.Find(cb.Name, true))
                                    {
                                        if (item2.GetType() == typeof(NumericUpDown))
                                        {
                                            NumericUpDown nn = (NumericUpDown)item2;
                                            item.Amount = (int)nn.Value;
                                        }
                                    }

                                    bucketMenuDetailList.Add(item);
                                    break;
                                }
                            }
                        }
                    }          
                }
            }            
        }
    }
}
