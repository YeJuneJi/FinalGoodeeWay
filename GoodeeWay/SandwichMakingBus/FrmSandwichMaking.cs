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

        public FrmSandwichMaking()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongDateString() +" "+ DateTime.Now.ToLongTimeString();
        }

        List<MakingFormVO> stringList = new List<MakingFormVO>();

        public void GetString(string toMaking)
        {            
            MakingFormVO mfVO = new MakingFormVO();
            mfVO.Num = count++;

            string[] splitString = toMaking.Split('@');
            
            foreach (var item in splitString)
            {
                if (item.Contains("샌드위치"))
                {
                    mfVO.SandwichRecipe += item.Replace("샌드위치", "") + "@";
                    
                }
                else if (item.Contains("찹샐러드"))
                {
                    mfVO.Salad += item.Replace("찹샐러드", "") + "|";
                }
                else if (item.Contains("사이드"))
                {
                    mfVO.Side += item.Replace("사이드", "") + "|";
                }
                else if (item.Contains("음료"))
                {
                    mfVO.Drink += item.Replace("음료", "") + "|";
                }
            }

            DataGridViewButtonColumn startButton = new DataGridViewButtonColumn();
            startButton.Text = "시작";
            startButton.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn endButton = new DataGridViewButtonColumn();
            endButton.Text = "종료";
            endButton.UseColumnTextForButtonValue = true;

            mfVO.StartButton = startButton;
            mfVO.EndButto = endButton;

            stringList.Add(mfVO);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = stringList;            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] splitString = dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Split('@');

            foreach (string item in splitString)
            {
                if (item != null && item != "")
                {
                    
                }
            }
        }
    }
}
