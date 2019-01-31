using GoodeeWay.DAO;
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

        private Menu item;
        List<Menu> bucketMenuList;
        List<MenuDetail> bucketMenuDetailList;
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

        public OrderDetail(Menu item, List<Menu> bucketMenuList, List<MenuDetail> bucketMenuDetailList, List<MenuAndDetails> bucketMenuAndDetailList) : this()
        {
            this.item = item;
            this.bucketMenuList = bucketMenuList;
            this.bucketMenuDetailList = bucketMenuDetailList;
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
            menuImage.Image = item.MenuImage;
            lblMenuName.Text = item.MenuName;

            // 메뉴 레시피들을 받아와 리스트에 저장
            menuDetailList = new OrderDetailDAO().getRecipe(item.MenuName);

            // 테스트 데이터 입니다
            MenuDetail md = new MenuDetail();
            md.RecipeCode = "1";
            md.Amount = 1;
            md.MenuCode = "1";
            md.InventoryTypeCode = "1";
            md.Compulsory = false;
            md.Division = "Bread";
            md.Name = "호밀빵";

            MenuDetail md2 = new MenuDetail();
            md2.RecipeCode = "2";
            md2.Amount = 1;
            md2.MenuCode = "2";
            md2.InventoryTypeCode = "3";
            md2.Compulsory = true;
            md2.Division = "Bread";
            md2.Name = "단팥빵";

            MenuDetail md3 = new MenuDetail();
            md3.RecipeCode = "1";
            md3.Amount = 5;
            md3.MenuCode = "1";
            md3.InventoryTypeCode = "1";
            md3.Compulsory = true;
            md3.Division = "Vegetable";
            md3.Name = "양상추";

            MenuDetail md4 = new MenuDetail();
            md4.RecipeCode = "1";
            md4.Amount = 5;
            md4.MenuCode = "1";
            md4.InventoryTypeCode = "1";
            md4.Compulsory = true;
            md4.Division = "Vegetable";
            md4.Name = "양파";

            MenuDetail md5 = new MenuDetail();
            md5.RecipeCode = "1";
            md5.Amount = 5;
            md5.MenuCode = "1";
            md5.InventoryTypeCode = "1";
            md5.Compulsory = true;
            md5.Division = "Cheese";
            md5.Name = "체다치즈";

            MenuDetail md6 = new MenuDetail();
            md6.RecipeCode = "1";
            md6.Amount = 5;
            md6.MenuCode = "1";
            md6.InventoryTypeCode = "1";
            md6.Compulsory = false;
            md6.Division = "Cheese";
            md6.Name = "모짜렐라치즈";

            MenuDetail md7 = new MenuDetail();
            md7.RecipeCode = "1";
            md7.Amount = 5;
            md7.MenuCode = "1";
            md7.InventoryTypeCode = "1";
            md7.Compulsory = false;
            md7.Division = "Sauce";
            md7.Name = "케찹";

            MenuDetail md8 = new MenuDetail();
            md8.RecipeCode = "1";
            md8.Amount = 5;
            md8.MenuCode = "1";
            md8.InventoryTypeCode = "1";
            md8.Compulsory = true;
            md8.Division = "Sauce";
            md8.Name = "마요네즈";

            MenuDetail md15 = new MenuDetail();
            md15.RecipeCode = "1";
            md15.Amount = 5;
            md15.MenuCode = "1";
            md15.InventoryTypeCode = "1";
            md15.Compulsory = true;
            md15.Division = "Sauce";
            md15.Name = "칠리";

            MenuDetail md9 = new MenuDetail();
            md9.RecipeCode = "1";
            md9.Amount = 5;
            md9.MenuCode = "1";
            md9.InventoryTypeCode = "1";
            md9.Compulsory = true;
            md9.Division = "Toping";
            md9.Name = "에그";

            MenuDetail md10 = new MenuDetail();
            md10.RecipeCode = "1";
            md10.Amount = 5;
            md10.MenuCode = "1";
            md10.InventoryTypeCode = "1";
            md10.Compulsory = true;
            md10.Division = "Toping";
            md10.Name = "감자";

            MenuDetail md11 = new MenuDetail();
            md11.RecipeCode = "1";
            md11.Amount = 5;
            md11.MenuCode = "1";
            md11.InventoryTypeCode = "1";
            md11.Compulsory = true;
            md11.Division = "Additional";
            md11.Name = "로세리티";

            MenuDetail md12 = new MenuDetail();
            md12.RecipeCode = "1";
            md12.Amount = 5;
            md12.MenuCode = "1";
            md12.InventoryTypeCode = "1";
            md12.Compulsory = true;
            md12.Division = "Additional";
            md12.Name = "비프";

            menuDetailList.Add(md);
            menuDetailList.Add(md2);
            menuDetailList.Add(md3);
            menuDetailList.Add(md4);
            menuDetailList.Add(md5);
            menuDetailList.Add(md6);
            menuDetailList.Add(md7);
            menuDetailList.Add(md8);
            menuDetailList.Add(md9);
            menuDetailList.Add(md10);
            menuDetailList.Add(md11);
            menuDetailList.Add(md12);
            menuDetailList.Add(md15);
            // ================================

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
                    rb.Name = item.Name;
                    rb.Text = item.Name;
                    rb.Checked = item.Compulsory;
                    breadGroup.Controls.Add(rb);
                }
                else if (item.Division == "Cheese")
                {
                    RadioButton rb = new RadioButton();
                    rb.Name = item.Name;
                    rb.Text = item.Name;
                    rb.Checked = item.Compulsory;
                    cheeseGroup.Controls.Add(rb);
                }
                else if (item.Division == "Vegetable")
                {
                    CheckBox cb = new CheckBox();
                    cb.Name = item.Name;
                    cb.Text = item.Name;
                    cb.Checked = item.Compulsory;

                    //TextBox tb = new TextBox();
                    //tb.Text = "5";
                    //tb.Name = item.Name;

                    vegetableGroup.Controls.Add(cb);
                    //vegetableGroup.Controls.Add(tb);
                }               
                else if (item.Division == "Sauce")
                {
                    CheckBox cb = new CheckBox();
                    cb.Name = item.Name;
                    cb.Text = item.Name;
                    cb.Checked = item.Compulsory;
                    sauceGroup.Controls.Add(cb);
                }
                else if (item.Division == "Toping")
                {
                    CheckBox cb = new CheckBox();
                    cb.Name = item.Name;
                    cb.Text = item.Name;
                    cb.Checked = item.Compulsory;
                    toppingGroup.Controls.Add(cb);
                }
                else if (item.Division == "Additional")
                {
                    CheckBox cb = new CheckBox();
                    cb.Name = item.Name;
                    cb.Text = item.Name;
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

        private void btnOK_Click(object sender, EventArgs e)
        {            
            bucketMenuList.Add(item);
            CheckState();

            MenuAndDetails menuAndDetails = new MenuAndDetails();
            menuAndDetails.Menu = item;
            menuAndDetails.MenuDetailList = bucketMenuDetailList;

            bucketMenuAndDetailList.Add(menuAndDetails);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
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
                                if (item.Name.Equals(rb.Name))
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
                                if (item.Name.Equals(cb.Name))
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
