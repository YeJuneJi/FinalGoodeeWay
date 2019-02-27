using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodeeWay.DAO;
using GoodeeWay.VO;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Configuration;
using System.Threading;

namespace GoodeeWay.Equipment
{
    public partial class FrmEquipment : Form
    {
        public FrmEquipment()
        {
            InitializeComponent();
        }

        private void FrmEquipment_Load(object sender, EventArgs e)
        {
            UcEquipment ucEquipment = new UcEquipment();
            ucEquipment.Location = new Point(0, 0);
            this.Controls.Add(ucEquipment);
            this.WindowState = FormWindowState.Maximized;
            EquipmentDAO dAO = new EquipmentDAO();


        }

       
    }

}
