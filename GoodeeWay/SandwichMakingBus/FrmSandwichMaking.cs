using GoodeeWay.DAO;
using GoodeeWay.VO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
        }

        private void FrmSandwichMaking_Load(object sender, EventArgs e)
        {
            GridViewReset();
        }

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

        private void dataGridViewING_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RealMenuVO realMenuVO = JsonConvert.DeserializeObject<RealMenuVO>(dataGridViewING.SelectedRows[0].Cells[1].Value.ToString());

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

                        if (MessageBox.Show(num + "완료?", "완료", MessageBoxButtons.OKCancel) == DialogResult.OK)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSandwichMaking_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
