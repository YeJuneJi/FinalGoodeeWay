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
            breadGroup.AutoSize = true;
            breadGroup.BorderStyle = BorderStyle.FixedSingle;
            breadGroup.Name = "Bread";

            cheeseGroup.AutoSize = true;
            cheeseGroup.BorderStyle = BorderStyle.FixedSingle;

            vegetableGroup.AutoSize = true;
            vegetableGroup.BorderStyle = BorderStyle.FixedSingle;

            sauceGroup.AutoSize = true;
            sauceGroup.BorderStyle = BorderStyle.FixedSingle;

            toppingGroup.AutoSize = true;
            toppingGroup.BorderStyle = BorderStyle.FixedSingle;

            additionalGroup.AutoSize = true;
            additionalGroup.BorderStyle = BorderStyle.FixedSingle;

            // 선택한 메뉴에대한 사항 로드
            menuImage.Image = Image.FromFile(item.MenuImage);
            lblMenuName.Text = item.MenuName;            
            lblPrice.Text = item.Price.ToString() + " 원";
            lblKcal.Text = item.Kcal.ToString() + " Kcal";

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

            foreach (MenuDetail item in menuDetailList)
            {
                if (item.Division == "Bread")
                {
                    RadioButton rb = new RadioButton();
                    rb.Name = item.InventoryName;
                    rb.Text = item.InventoryName;
                    rb.Checked = item.Compulsory;
                    breadGroup.Controls.Add(rb);
                }
                else if (item.Division == "Cheese")
                {
                    RadioButton rb = new RadioButton();
                    rb.Name = item.InventoryName;
                    rb.Text = item.InventoryName;
                    rb.Checked = item.Compulsory;
                    cheeseGroup.Controls.Add(rb);
                }
                else if (item.Division == "Vegetable")
                {
                    CheckBox cb = new CheckBox();
                    cb.Name = item.InventoryName;
                    cb.Text = item.InventoryName;
                    cb.Checked = item.Compulsory;

                    vegetableGroup.Controls.Add(cb);                    
                }               
                else if (item.Division == "Sauce")
                {
                    CheckBox cb = new CheckBox();
                    cb.Name = item.InventoryName;
                    cb.Text = item.InventoryName;
                    cb.Checked = item.Compulsory;
                    sauceGroup.Controls.Add(cb);
                }
                else if (item.Division == "Topping")
                {
                    CheckBox cb = new CheckBox();
                    cb.Name = item.InventoryName;
                    cb.Text = item.InventoryName;
                    cb.Checked = item.Compulsory;
                    toppingGroup.Controls.Add(cb);
                }
                else if (item.Division == "Additional")
                {
                    CheckBox cb = new CheckBox();
                    cb.Name = item.InventoryName;
                    cb.Text = item.InventoryName;
                    cb.Checked = item.Compulsory;
                    additionalGroup.Controls.Add(cb);
                }
            }            

            flowLayoutPanel1.Controls.Add(breadGroup);
            flowLayoutPanel1.Controls.Add(cheeseGroup);
            flowLayoutPanel1.Controls.Add(vegetableGroup);            
            flowLayoutPanel1.Controls.Add(sauceGroup);
            flowLayoutPanel1.Controls.Add(toppingGroup);
            flowLayoutPanel1.Controls.Add(additionalGroup);
        }

        private void btnOK_Click(object sender, EventArgs e) // 확인 버튼 클릭시 작동
        {            
            bucketMenuList.Add(item);
            CheckState();

            MenuAndDetails menuAndDetails = new MenuAndDetails();
            menuAndDetails.Menu = item;
            menuAndDetails.MenuDetailList = bucketMenuDetailList;

            bucketMenuAndDetailList.Add(menuAndDetails);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) // 취소 버튼 클릭시 작동
        {
            this.Close();
        }

        private void CheckState() // 체크 박스에 얻은 내용 저장
        {
            bucketMenuDetailList.Clear();
            foreach (FlowLayoutPanel panel in flowLayoutPanel1.Controls)
            {
                foreach (var box in panel.Controls)
                {
                    if (box.GetType() == typeof(Label))
                    {

                    }
                    else if (box.GetType() == typeof(RadioButton))
                    {
                        RadioButton rb = (RadioButton)box;
                        if (rb.Checked)
                        {
                            foreach (var item in menuDetailList)
                            {
                                if (item.InventoryName.Equals(rb.Name))
                                {
                                    bucketMenuDetailList.Add(item);
                                    break;
                                }
                            }
                        }
                    }
                    else if (box.GetType() == typeof(CheckBox))
                    {
                        CheckBox cb = (CheckBox)box;
                        if (cb.Checked)
                        {
                            foreach (var item in menuDetailList)
                            {
                                if (item.InventoryName.Equals(cb.Name))
                                {
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
