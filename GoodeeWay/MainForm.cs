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

namespace GoodeeWay
{
    public partial class MainForm : Form
    {
        List<EmpVO> lst;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lst = new EmpDAO().OutputAllBoard();
            this.dataGridView1.DataSource = lst;
        }
    }
}
