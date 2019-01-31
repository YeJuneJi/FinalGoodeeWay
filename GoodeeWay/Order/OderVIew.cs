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
    public partial class OderVIew : Form
    {
        List<Menu> menuList = new List<Menu>(); // 전체 메뉴 리스트
        List<ListViewItem> listViewItemList = new List<ListViewItem>(); // 메뉴 리스트를 리스트뷰 아이템으로 만든 리스트

        List<Menu> bucketMenuList = new List<Menu>(); // 선택한 메뉴 리스트
        List<MenuDetail> bucketMenuDetailList = new List<MenuDetail>(); // 선택한 메뉴의 레시피 리스트
        List<MenuAndDetails> bucketMenuAndDetailList = new List<MenuAndDetails>();

        ImageList imgList = new ImageList(); // 리스트 뷰를 위한 이미지 리스트

        public OderVIew()
        {
            InitializeComponent();
        }

        private void OderVIew_Load(object sender, EventArgs e) // 
        {
            menuList = new OrderDAO().GetAllMenu(); // 메뉴 테이블에서 모든 메뉴를 뽑아와 리스트에 등록

            // 테스트 입네다
            Menu m = new Menu();
            m.MenuCode = "0001";
            m.MenuName = "Egg샌드위치";
            m.Price = 5000;
            m.Kcal = 5000;
            m.MenuImage = Image.FromFile(@"C:\Users\gd12\Desktop\img\2.PNG");
            m.Division = "Sandwich";
            m.AdditionalContext = "계란 샌드위치 입네다~";

            Menu m2 = new Menu();
            m2.MenuCode = "0003";
            m2.MenuName = "초코쿠키";
            m2.Price = 3000;
            m2.Kcal = 1000;
            m2.MenuImage = Image.FromFile(@"C:\Users\gd12\Desktop\img\111.PNG");
            m2.Division = "Side";
            m2.AdditionalContext = "쿠기 입네다~";

            Menu m3 = new Menu();
            m3.MenuCode = "0002";
            m3.MenuName = "사이다";
            m3.Price = 1500;
            m3.Kcal = 600;
            m3.MenuImage = Image.FromFile(@"C:\Users\gd12\Desktop\img\MainLogo.PNG");
            m3.Division = "Drink";
            m3.AdditionalContext = "사이다 입네다~";

            Menu m4 = new Menu();
            m4.MenuCode = "0004";
            m4.MenuName = "치킨샐러드";
            m4.Price = 6000;
            m4.Kcal = 100;
            m4.MenuImage = Image.FromFile(@"C:\Users\gd12\Desktop\img\Precision.jpg");
            m4.Division = "Salad";
            m4.AdditionalContext = "치킨샐러드 입네다~";

            menuList.Add(m);
            menuList.Add(m2);
            menuList.Add(m3);
            menuList.Add(m4);

            GetMenuList();
            SetListView("All");
        }

        private void GetMenuList() // menuList 세팅
        {
            foreach (Menu item in menuList) // 메뉴리스트에 있는 목록을 각각 별로 listview에 띄어줌
            {
                imgList.Images.Add(item.MenuCode, item.MenuImage);
                imgList.ImageSize = new Size(128, 128);
                listViewOrder.LargeImageList = imgList;
                listViewBasket.LargeImageList = imgList;

                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Name = item.MenuName;
                listViewItem.Text = item.MenuName;
                listViewItem.ImageKey = item.MenuCode;

                listViewItemList.Add(listViewItem);
            }
        }

        private void button_Click(object sender, EventArgs e) // 버튼 선택시 이벤트 처리
        {
            Button b = (Button)sender;

            SetListView(b.Name.Replace("btn", ""));
        }

        private void SetListView(string v) // 선택한 버튼에 따른 ListView Setting
        {
            listViewOrder.Clear();
            if (v.Equals("All")) // 전체 선택일시
            {
                foreach (ListViewItem listViewItem in listViewItemList)
                {
                    listViewOrder.Items.Add((ListViewItem)listViewItem.Clone());
                }
            }
            else if (true) // 나머지 버튼 선택시 각각 
            {
                foreach (Menu menu in menuList)
                {
                    if (menu.Division.Equals(v))
                    {
                        foreach (ListViewItem listViewItem in listViewItemList)
                        {
                            if (listViewItem.Name == menu.MenuName)
                            {
                                listViewOrder.Items.Add((ListViewItem)listViewItem.Clone());
                            }
                        }
                    }                    
                }
            }
        }

        private void listViewOrder_Click(object sender, EventArgs e) // 상품 클릭시 처리 
        {
            ListView lvi = (ListView)sender;

            foreach (Menu item in menuList)
            {                
                if (item.MenuName == lvi.SelectedItems[0].Text)
                {
                    if (!item.Division.Equals("Sandwich")) // 구분이 Sandwich가 아니면 그냥 처리
                    {
                        bucketMenuList.Add(item);
                        MenuAndDetails menuAndDetails = new MenuAndDetails();
                        menuAndDetails.Menu = item;
                        menuAndDetails.MenuDetailList = null;

                        bucketMenuAndDetailList.Add(menuAndDetails);
                    }
                    else // 구분이 Sandwich이면 상세 페이지로 이동
                    {
                        OrderDetail orderDetail = new OrderDetail(item, bucketMenuList, bucketMenuDetailList, bucketMenuAndDetailList);
                        orderDetail.ShowDialog();
                    }                    
                    break;
                }
            }

            textBox1.Text = "";
            foreach (var item in bucketMenuAndDetailList)
            {
                textBox1.Text += "\r\n";
                textBox1.Text += item.Menu.MenuName;

                if (item.MenuDetailList != null)
                {
                    textBox1.Text += "\r\n";
                    textBox1.Text += "--> 상세메뉴 :  ";
                    foreach (var item2 in item.MenuDetailList)
                    {
                        textBox1.Text += item2.Name + " | ";
                    }
                }                
            }
            
            SetBasketListBox();
        }       

        private void btnCancel_Click(object sender, EventArgs e) // 전체 취소 버튼 클릭시 작동
        {
            bucketMenuList.Clear();
            bucketMenuDetailList.Clear();
            bucketMenuAndDetailList.Clear();

            SetBasketListBox();
        }

        private void btnCancelOne_Click(object sender, EventArgs e) // 취소 버튼 클릭시 작동
        {
            bucketMenuList.RemoveAt(listViewBasket.SelectedItems[0].Index);
            bucketMenuAndDetailList.RemoveAt(listViewBasket.SelectedItems[0].Index);
            SetBasketListBox();
        }

        private void SetBasketListBox() // 장바구니 리스트에 따라 listview 목록을 refresh 해주는 메소드
        {
            listViewBasket.Clear();

            foreach (Menu menu in bucketMenuList)
            {
                foreach (ListViewItem listViewItem in listViewItemList)
                {
                    if (listViewItem.Name.Equals(menu.MenuName))
                    {
                        listViewBasket.Items.Add((ListViewItem)listViewItem.Clone());
                    }
                }
            }
        }

        bool result = false;

        private void btnOK_Click(object sender, EventArgs e) // 결제 버튼 클릭시 작동
        {
            Order order = new Order(bucketMenuAndDetailList); // 결제 창으로 이동

            order.FormClosed += new FormClosedEventHandler(this.formClosed);

            foreach (var item in order.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    Button bt = (Button)item;
                    if (bt.Name.Equals("btnOk"))
                    {
                        bt.Click += new System.EventHandler(this.orderBtnOK);
                    }
                }
            }

            order.ShowDialog();
        }
        
        private void formClosed(object sender, EventArgs e) // 결제창이 닫히면 작동
        {
            if (result == true)
            {
                MessageBox.Show("정상 결제 완료");
                this.Close();
            }
        }

        private void orderBtnOK(object sender, EventArgs e) // 결제창에서 ok 버튼 클릭시 작동
        {
            result = true;            
        }

        
    }
}
