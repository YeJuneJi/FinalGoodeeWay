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

namespace GoodeeWay.SandwichMakingBus
{
    public partial class FrmSandwichMaking : Form
    {
        int count = 0;        
        List<MakingFormVO> stringList = new List<MakingFormVO>();
        
        private void FrmSandwichMaking_Load(object sender, EventArgs e)
        {
            GridViewSBReset();
        }

        public FrmSandwichMaking()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongDateString() +" "+ DateTime.Now.ToLongTimeString();
        }

        private void GridViewSBReset()
        {
            dataGridViewSB.Columns.Clear();
            dataGridViewSB.DataSource = null;

            stringList = new MakingDAO().SelectMaking();

            foreach (var makingFormVO in stringList)
            {
                string[] splitString = makingFormVO.ToMaking.Split('@');

                foreach (var item in splitString)
                {
                    if (item.Contains("샌드위치"))
                    {
                        makingFormVO.SandwichRecipe += item.Replace("샌드위치", "") + "@";
                    }
                    else if (item.Contains("찹샐러드"))
                    {
                        makingFormVO.Salad += item.Replace("찹샐러드", "") + "|";
                    }
                    else if (item.Contains("사이드"))
                    {
                        makingFormVO.Side += item.Replace("사이드", "") + "|";
                    }
                    else if (item.Contains("음료"))
                    {
                        makingFormVO.Drink += item.Replace("음료", "") + "|";
                    }
                }

                dataGridViewSB.DataSource = stringList;
            }

            DataGridViewButtonColumn startButton = new DataGridViewButtonColumn();
            startButton.Text = "시작";
            startButton.Name = "시작";
            startButton.UseColumnTextForButtonValue = true;

            dataGridViewSB.Columns.Add(startButton);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] splitString = dataGridViewSB.SelectedRows[0].Cells[1].Value.ToString().Split('@');

            foreach (string item in splitString)
            {
                if (item != null && item != "")
                {
                    
                }
            }
        }

        internal void CallMaking()
        {
            GridViewSBReset();
        }
    }
}
