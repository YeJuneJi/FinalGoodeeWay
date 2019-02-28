using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodeeWay.DAO;
using System.Runtime.InteropServices;

namespace GoodeeWay.Order
{
    public partial class FrmOrderView : UserControl
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        List<Menu> menuList = new List<Menu>(); // 전체 메뉴 리스트
        List<ListViewItem> listViewItemList = new List<ListViewItem>(); // 메뉴 리스트를 리스트뷰 아이템으로 만든 리스트

        List<Menu> bucketMenuList = new List<Menu>(); // 선택한 메뉴 리스트
        List<MenuDetail> bucketMenuDetailList = new List<MenuDetail>(); // 선택한 메뉴의 레시피 리스트
        List<MenuAndDetails> bucketMenuAndDetailList = new List<MenuAndDetails>();

        ImageList imgList = new ImageList(); // 리스트 뷰를 위한 이미지 리스트

        public FrmOrderView()
        {
            InitializeComponent();
        }

        private void FrmOrderView_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            new OrderDAO().GetAllMenu(menuList); // 메뉴 테이블에서 모든 메뉴를 뽑아와 리스트에 등록

            GetMenuList();
            SetListView("All");
        }

        /// <summary>
        /// 등록되어있는 메뉴들을 가져와 리스트뷰 아이템 셋팅을 해준다.
        /// </summary>
        private void GetMenuList() // menuList 세팅
        {
            foreach (Menu item in menuList) // 메뉴리스트에 있는 목록을 각각 별로 listview에 띄어줌
            {
                try
                {
                    imgList.Images.Add(item.MenuCode, Image.FromFile(Application.StartupPath + item.MenuImage));
                    imgList.ImageSize = new Size(128, 128);
                }
                catch (Exception)
                {
                    MessageBox.Show("이미지를 로드할 수 없습니다. 경로를 확인해 주세요");
                }
                listViewOrder.LargeImageList = imgList;
                listViewBasket.LargeImageList = imgList;

                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Name = item.MenuName;

                if (item.DiscountRatio != 0)
                {
                    listViewItem.Text = item.MenuName + "\r\n" + "할인! : " + ((decimal)item.Price - ((decimal)item.Price / (decimal)item.DiscountRatio)).ToString() + "원";
                }
                else
                {
                    listViewItem.Text = item.MenuName + "\r\n" + item.Price + "원";
                }

                listViewItem.ImageKey = item.MenuCode;

                listViewItemList.Add(listViewItem);
            }
        }

        /// <summary>
        /// 해당되는 버튼들에 대한 리스트뷰 아이템들을 화면에 보여준다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e) // 버튼 선택시 이벤트 처리
        {
            Button b = (Button)sender;

            SetListView(b.Name.Replace("btn", "")); // 버튼 이름에서 btn 제외후 전달
        }

        /// <summary>
        /// 넘겨받은 선택한 버튼들에대한 리스트뷰 아이템들을 가져와 보여준다.
        /// </summary>
        /// <param name="v"></param>
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

        /// <summary>
        /// 리스트뷰 아이템을 클릭하면 작동하는 이벤트 메소드
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewOrder_Click(object sender, EventArgs e) // 상품 클릭시 처리 
        {
            ListView lvi = (ListView)sender;

            foreach (Menu item in menuList)
            {
                if (lvi.SelectedItems[0].Text.Remove(lvi.SelectedItems[0].Text.IndexOf("\r\n")).Replace(" ", "").Equals(item.MenuName))                
                {
                    if (!item.Division.Equals(Convert.ToString((int)Division.샌드위치))) // 구분이 Sandwich가 아니면 그냥 처리
                    {
                        bucketMenuList.Add(item.Clone());
                        MenuAndDetails menuAndDetails = new MenuAndDetails();
                        menuAndDetails.Menu = item;
                        menuAndDetails.MenuDetailList = null;

                        bucketMenuAndDetailList.Add(menuAndDetails);
                    }
                    else // 구분이 Sandwich이면 상세 페이지로 이동
                    {
                        OrderDetail orderDetail = new OrderDetail(item, bucketMenuList, bucketMenuAndDetailList);
                        orderDetail.ShowDialog();
                    }
                    break;
                }
            }

            SetBasketListBox();
        }

        /// <summary>
        /// 전체취소 버튼을 누르면 동작하는 메소드
        /// 장바구니에 담겨져있는 모든 것들을 비워준다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e) // 전체 취소 버튼 클릭시 작동
        {
            bucketMenuList.Clear();
            bucketMenuDetailList.Clear();
            bucketMenuAndDetailList.Clear();

            SetBasketListBox();
        }

        /// <summary>
        /// 취소 버튼을 클릭하면 작동하는 메소드
        /// 장바구니 목록중에 선택한 아이템을 삭제해준다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelOne_Click(object sender, EventArgs e) // 취소 버튼 클릭시 작동
        {
            if (listViewBasket.SelectedItems.Count > 0)
            {
                bucketMenuList.RemoveAt(listViewBasket.SelectedItems[0].Index);
                bucketMenuAndDetailList.RemoveAt(listViewBasket.SelectedItems[0].Index);
                SetBasketListBox();
            }
            else
            {
                MessageBox.Show("삭제할 물품을 선택해 주세요");
            }
        }

        /// <summary>
        /// 장바구니에 담겨진 내용대로 장바구니 리스트뷰 목록을 갱신해준다.
        /// </summary>
        private void SetBasketListBox() // 장바구니 리스트에 따라 listview 목록을 refresh 해주는 메소드
        {
            listViewBasket.Clear();
            decimal price = 0;
            int kCal = 0;
            foreach (Menu menu in bucketMenuList)
            {
                foreach (ListViewItem listViewItem in listViewItemList)
                {
                    if (listViewItem.Name.Equals(menu.MenuName))
                    {
                        if (menu.DiscountRatio != 0)
                        {
                            price += (decimal)menu.Price - ((decimal)menu.Price / (decimal)menu.DiscountRatio);
                        }
                        else
                        {
                            price += (decimal)menu.Price;
                        }

                        kCal += menu.Kcal;

                        listViewBasket.Items.Add((ListViewItem)listViewItem.Clone());
                    }
                }
            }

            lblPrice.Text = "가격 : " + price;
            lblKcal.Text = "칼로리 : " + kCal;
        }

        bool result = false;

        Order order;

        /// <summary>
        /// 결제 버튼 클릭시 작동하는 이벤트 메소드
        /// 결제창으로 장바구니에 담겨진 내용들을 전달해준다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e) // 결제 버튼 클릭시 작동
        {
            if (bucketMenuAndDetailList.Count == 0)
            {
                MessageBox.Show("메뉴를 선택해 주세요");
            }
            else
            {
                order = new Order(bucketMenuAndDetailList); // 결제 창으로 이동

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
        }

        /// <summary>
        /// 결제창이 닫히면 작동하는 메소드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formClosed(object sender, EventArgs e) // 결제창이 닫히면 작동
        {
            if (order.result == true)
            {
                MessageBox.Show("정상 결제 완료");
                bucketMenuList.Clear();
                bucketMenuDetailList.Clear();
                bucketMenuAndDetailList.Clear();
                SetBasketListBox();
                //this.Close();   
            }
        }

        private void orderBtnOK(object sender, EventArgs e) // 결제창에서 ok 버튼 클릭시 작동
        {

        }
    }
}
