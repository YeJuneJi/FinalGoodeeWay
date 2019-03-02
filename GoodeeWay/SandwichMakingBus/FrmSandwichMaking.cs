using GoodeeWay.DAO;
using GoodeeWay.Properties;
using GoodeeWay.VO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GoodeeWay.SandwichMakingBus
{
    public partial class FrmSandwichMaking : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;        

        int count = 5;

        List<MakingFormVO> odList = new List<MakingFormVO>();
        List<MakingFormVO> standByList = new List<MakingFormVO>();
        List<MakingFormVO> makingList = new List<MakingFormVO>();        

        public FrmSandwichMaking()
        {
            InitializeComponent();
            this.Icon = Resources.C_Sharp_Logo_2_1;
        }

        private void FrmSandwichMaking_Load(object sender, EventArgs e)
        {
            GridViewReset();
        }

        /// <summary>
        /// 5초마다 데이터그리드뷰를 갱신해주는 타이머 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            if (count >= 5)
            {                
                GridViewReset();
                count = 0;
            }

            count++;
        }

        /// <summary>
        /// 데이터베이스에서 자료를가져와 '대기'와 '제조'로 분류해주는 메소드
        /// </summary>
        private void Classify()
        {
            odList.Clear();
            standByList.Clear();
            makingList.Clear();

            odList = new MakingDAO().SelectMaking();

            foreach (var item in odList)
            {
                if (item.Division.Equals("대기"))
                {
                    standByList.Add(item);
                }
                else if (item.Division.Equals("제조"))
                {
                    makingList.Add(item);
                }
            }
        }

        /// <summary>
        /// 데이터그리드뷰를 refresh 해주는 메소드
        /// </summary>
        private void GridViewReset()
        {
            Classify();
            
            dataGridViewSB.Columns.Clear();
            dataGridViewSB.DataSource = null;

            dataGridViewSB.DataSource = standByList;

            DataGridViewButtonColumn startButton = new DataGridViewButtonColumn();
            startButton.Text = "시작";
            startButton.Name = "시작";
            startButton.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn cancelButton = new DataGridViewButtonColumn();
            cancelButton.Text = "취소";
            cancelButton.Name = "취소";
            cancelButton.UseColumnTextForButtonValue = true;

            dataGridViewSB.Columns.Add(startButton);
            dataGridViewSB.Columns.Add(cancelButton);

            dataGridViewING.Columns.Clear();
            dataGridViewING.DataSource = null;

            dataGridViewING.DataSource = makingList;

            DataGridViewButtonColumn endButton = new DataGridViewButtonColumn();
            endButton.Text = "완료";
            endButton.Name = "완료";
            endButton.UseColumnTextForButtonValue = true;

            dataGridViewING.Columns.Add(endButton);
        }

        /// <summary>
        /// 데이터 그리드뷰 cell을 클릭이벤트 메소드 제조 시작,취소 처리를 할 수 있다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                if (senderGrid.Columns[e.ColumnIndex].Name.Equals("시작"))
                {
                    if (dataGridViewSB.SelectedRows[0].Cells[0].Value.GetType() == typeof(int))
                    {
                        int num = (int)dataGridViewSB.SelectedRows[0].Cells[0].Value;
                        if (MessageBox.Show(num + "의 제조를 시작하겠습니까?", "시작", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            // 수정 메서드 작동 
                            try
                            {
                                new MakingDAO().UpdateMaking(num);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("시작 할 수 없습니다");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("다시 선택해 주세요");
                    }

                    GridViewReset();
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name.Equals("취소"))
                {
                    if (dataGridViewSB.SelectedRows[0].Cells[0].Value.GetType() == typeof(int))
                    {
                        int num = (int)dataGridViewSB.SelectedRows[0].Cells[0].Value;
                        if (MessageBox.Show(num + "를 취소하겠습니까?", "취소", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            // 삭제 메서드 작동
                            try
                            {
                                new MakingDAO().DeleteMaking(num);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("삭제 할 수 없습니다");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("다시 선택해 주세요");
                    }

                    GridViewReset();
                }
            }
        }

        /// <summary>
        /// 제조 데이터 그리드뷰 클릭이벤트 제조 완료를 할 수 있다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewING_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RealMenuVO realMenuVO = JsonConvert.DeserializeObject<RealMenuVO>(dataGridViewING.SelectedRows[0].Cells[2].Value.ToString());

            tbList.Text = String.Empty;

            tbList.Text += "========================================\r\n";
            foreach (var rmv in realMenuVO.RealMenu)
            {
                if (rmv.Menu.Division.Equals(Convert.ToString((int)Division.샌드위치)))
                {
                    tbList.Text += "\r\n\r\n<<" + Enum.GetName(typeof(Division), int.Parse(rmv.Menu.Division)) + ">>" + rmv.Menu.MenuName;
                    tbList.Text += "\r\n\r\n재료 : ==>";
                    foreach (var mdl in rmv.MenuDetailList)
                    {
                        tbList.Text += "\t" + mdl.InventoryName + ", ";
                    }
                }
                else
                {
                    tbList.Text += "\r\n\r\n<<" + Enum.GetName(typeof(Division), int.Parse(rmv.Menu.Division)) + ">>\r\n" + rmv.Menu.MenuName;
                }

            }

            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                if (senderGrid.Columns[e.ColumnIndex].Name.Equals("완료"))
                {
                    if (dataGridViewING.SelectedRows[0].Cells[0].Value.GetType() == typeof(int))
                    {
                        int num = (int)dataGridViewING.SelectedRows[0].Cells[0].Value;

                        if (MessageBox.Show(num + "번의 제조를 완료 하시겠습니까?", "완료", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            // 삭제 메서드 작동
                            try
                            {
                                new MakingDAO().DeleteMaking(num);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("완료 할 수 없습니다");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("다시 선택해 주세요");
                    }

                    GridViewReset();
                }                
            }
        }

        /// <summary>
        /// 닫기 사진을 누르면 폼이 닫힌다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void movePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // 다른 컨트롤에 묶여있을 수 있을 수 있으므로 마우스캡쳐 해제
                ReleaseCapture();

                // 타이틀 바의 다운 이벤트처럼 보냄
                SendMessage(this.Handle, WM_NLBUTTONDOWN, HT_CAPTION, 0);
            }

            base.OnMouseDown(e);
        }
    }
}
