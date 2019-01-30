using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodeeWay.DAO;

namespace GoodeeWay.Equipment
{
    public partial class FrmEquipment : Form
    {
        public FrmEquipment()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAddEquipment frmAddEquipment = new FrmAddEquipment();
            frmAddEquipment.ShowDialog();
        }

        private void FrmEquipment_Load(object sender, EventArgs e)
        {
            EquipmentDAO dAO = new EquipmentDAO();

            dgvEquipmentList.DataSource = dAO.AllequipmentVOsList();
        }
    }
}
