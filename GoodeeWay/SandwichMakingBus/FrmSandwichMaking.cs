using GoodeeWay.DAO;
using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeWay.SandwichMakingBus
{
    public partial class FrmSandwichMaking : Form
    {
        int count = 3;

        List<MakingFormVO> odList = new List<MakingFormVO>();
        List<MakingFormVO> standByList = new List<MakingFormVO>();
        List<MakingFormVO> makingList = new List<MakingFormVO>();
        Thread t1;

        public FrmSandwichMaking()
        {
            InitializeComponent();
        }

        private void FrmSandwichMaking_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            t1 = new Thread(new ThreadStart(tt));
            t1.Start();

        }

        private void tt()
        {
            DataGridView dataGridViewSB2 = new DataGridView();
            DataGridView dataGridViewING2 = new DataGridView();

            dataGridViewSB2.Size = new Size(200, 500);                        
            
            this.Controls.Add(dataGridViewSB);
            this.Controls.Add(dataGridViewING);

            while (true)
            {
                if (count == 3)
                {
                    GridViewReset(dataGridViewSB2, dataGridViewING2);

                    count = 0;
                }
            }
        }

        private void FrmSandwichMaking_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Abort();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            count++;
        }

        internal void CallMaking()
        {
            //GridViewReset();
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

        private void GridViewReset(DataGridView dataGridViewSB2, DataGridView dataGridViewING2)
        {
            Classify();
            MessageBox.Show("시작됬다");
            dataGridViewSB2.Columns.Clear();
            dataGridViewSB2.DataSource = null;

            dataGridViewSB2.DataSource = standByList;

            DataGridViewButtonColumn startButton = new DataGridViewButtonColumn();
            startButton.Text = "시작";
            startButton.Name = "시작";
            startButton.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn cancelButton = new DataGridViewButtonColumn();
            cancelButton.Text = "취소";
            cancelButton.Name = "취소";
            cancelButton.UseColumnTextForButtonValue = true;

            dataGridViewSB2.Columns.Add(startButton);
            dataGridViewSB2.Columns.Add(cancelButton);

            dataGridViewING2.Columns.Clear();
            dataGridViewING2.DataSource = null;

            dataGridViewING2.DataSource = makingList;

            DataGridViewButtonColumn endButton = new DataGridViewButtonColumn();
            endButton.Text = "완료";
            endButton.Name = "완료";
            endButton.UseColumnTextForButtonValue = true;

            dataGridViewING2.Columns.Add(endButton);

            //DataGridViewButtonColumn disposalButton = new DataGridViewButtonColumn();
            //disposalButton.Text = "폐기";
            //disposalButton.Name = "폐기";
            //disposalButton.UseColumnTextForButtonValue = true;

            //dataGridViewING.Columns.Add(disposalButton);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var senderGrid = (DataGridView)sender;

            //if (e.RowIndex >= 0)
            //{
            //    if (senderGrid.Columns[e.ColumnIndex].Name.Equals("시작"))
            //    {
            //        if (dataGridViewSB.SelectedRows[0].Cells[0].Value.GetType() == typeof(int))
            //        {
            //            int num = (int)dataGridViewSB.SelectedRows[0].Cells[0].Value;
            //            if (MessageBox.Show(num + "의 제조를 시작하겠습니까?", "시작", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //            {
            //                // 수정 메서드 작동 
            //                try
            //                {
            //                    new MakingDAO().UpdateMaking(num);
            //                }
            //                catch (Exception)
            //                {
            //                    MessageBox.Show("시작 할 수 없습니다");
            //                }
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("다시 선택해 주세요");
            //        }

            //        GridViewReset();
            //    }
            //    else if (senderGrid.Columns[e.ColumnIndex].Name.Equals("취소"))
            //    {
            //        if (dataGridViewSB.SelectedRows[0].Cells[0].Value.GetType() == typeof(int))
            //        {
            //            int num = (int)dataGridViewSB.SelectedRows[0].Cells[0].Value;
            //            if (MessageBox.Show(num + "를 취소하겠습니까?", "취소", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //            {
            //                // 삭제 메서드 작동
            //                try
            //                {
            //                    new MakingDAO().DeleteMaking(num);
            //                }
            //                catch (Exception)
            //                {
            //                    MessageBox.Show("삭제 할 수 없습니다");
            //                }
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("다시 선택해 주세요");
            //        }

            //        GridViewReset();
            //    }
            //}
        }

        private void dataGridViewING_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        //    var senderGrid = (DataGridView)sender;

        //    if (e.RowIndex >= 0)
        //    {
        //        //int num 
        //        if (senderGrid.Columns[e.ColumnIndex].Name.Equals("완료"))
        //        {
        //            if (dataGridViewING.SelectedRows[0].Cells[0].Value.GetType() == typeof(int))
        //            {
        //                int num = (int)dataGridViewING.SelectedRows[0].Cells[0].Value;

        //                if (MessageBox.Show(num + "완료?", "완료", MessageBoxButtons.OKCancel) == DialogResult.OK)
        //                {
        //                    // 삭제 메서드 작동
        //                    try
        //                    {
        //                        new MakingDAO().DeleteMaking(num);
        //                    }
        //                    catch (Exception)
        //                    {
        //                        MessageBox.Show("완료 할 수 없습니다");
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("다시 선택해 주세요");
        //            }

        //            GridViewReset();
        //        }
        //        //else if (senderGrid.Columns[e.ColumnIndex].Name.Equals("폐기"))
        //        //{
        //        //    if (dataGridViewING.SelectedRows[0].Cells[0].Value.GetType() == typeof(int))
        //        //    {
        //        //        MessageBox.Show(dataGridViewING.SelectedRows[0].Cells[0].Value.ToString() + "를 취소하겠습니까?", "폐기", MessageBoxButtons.OKCancel);
        //        //    }
        //        //    else
        //        //    {
        //        //        MessageBox.Show("다시 선택해 주세요");
        //        //    }

        //        //    // 삭제 메서드 작동

        //        //    GridViewSBReset();
        //        //}
        //    }
        }
    }
}
