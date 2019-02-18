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

namespace GoodeeWay.BUS
{
    public partial class Attendance_SearchEmpno : Form
    {
        public Attendance_SearchEmpno()
        {
            InitializeComponent();
        }

        private void Attendance_SearchEmpno_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new EmpDAO().SelectAll();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.SelectedCells[0].Value;
            this.FormClosed += new FormClosedEventHandler(Enter_Empno);
            
        }

        private void Enter_Empno(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
