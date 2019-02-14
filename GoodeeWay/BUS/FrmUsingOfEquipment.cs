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
    public partial class FrmUsingOfEquipment : Form
    {
        public FrmUsingOfEquipment()
        {
            InitializeComponent();
        }

        List<VO.EquipmentVO> equipment = new List<VO.EquipmentVO>();

        private void FrmUsingOfEquipment_Load(object sender, EventArgs e)
        {
            
            crtEquipment.ChartAreas[0].AxisX.LabelStyle.Format = "MM월 dd일"; //"dd.MM-hh:mm";
            crtEquipment.ChartAreas[0].AxisY.LabelStyle.Format = "000,000\\";
            DAO.EquipmentDAO dAO = new DAO.EquipmentDAO();
            equipment= dAO.AllequipmentVOsList();
            crtEquipment.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            crtEquipment.Series[0].Points.DataBind(equipment, "purchaseDate", "purchasePrice", null);
            crtEquipment.Series[0].LegendText = "총액";
        }
    }
}
