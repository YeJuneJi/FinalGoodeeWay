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

namespace GoodeeWay.Equipment
{
    public partial class FrmAddEquipment : Form
    {
        public FrmAddEquipment()
        {
            InitializeComponent();
        }

        #region panel이동을 위해서
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2; 
        #endregion


        /// <summary>
        /// DB로 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDetailName.Text =="")
            {
                MessageBox.Show("품목명을 입력해주세요");
                return;
            }
            EquipmentVO equipmentVO = new EquipmentVO()
            {
                DetailName = txtDetailName.Text,
                Location = txtLocation.Text,
                PurchasePrice = float.Parse(txtPrice.Text.Replace(",","")),
                PurchaseDate = dtpPurchaseDate.Value.Date,
                Note = txtNote.Text
            };
            EquipmentDAO dAO = new EquipmentDAO();
            try
            {
                DialogResult resurt = MessageBox.Show("저장하시겠습니까?","비품저장",MessageBoxButtons.YesNo);
                if (resurt == DialogResult.Yes)
                {
                    if (dAO.InsertEquipment(equipmentVO))
                    {
                        MessageBox.Show("성공적으로 저장되었습니다");
                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("저장실패" + ex.Message);
            }
        }

        /// <summary>
        ///  textbox값 초기화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRebuild_Click(object sender, EventArgs e)
        {
            txtDetailName.Text = "";
            txtLocation.Text = "";
            txtPrice.Text = "0";
            dtpPurchaseDate.Value = DateTime.Now;
            txtNote.Text = "";
        }

        /// <summary>
        /// close버튼 클릭시 창닫기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 현재 날짜 이후를 선택했을때 경고
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpPurchaseDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpPurchaseDate.Value > DateTime.Now)
            {
                MessageBox.Show("오늘 날짜는 " + DateTime.Now + " 입니다. 오늘 이전 날짜를 선택해주세요");
                dtpPurchaseDate.Value = DateTime.Now;
            }
        }

        /// <summary>
        /// 숫자형만,지우기,float 형의 범위로인한 가격제한
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))|| txtPrice.Text.Length > 8) 
            { 
                e.Handled = true;
            }
        }

        #region 글자수 제한
        private void txtDetailName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDetailName.Text.Length > 25)
            {
                e.Handled = true;
            }
        }

        private void txtLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtLocation.Text.Length > 10)
            {
                e.Handled = true;
            }
        } 
        #endregion

        /// <summary>
        /// txtprice의 format 변환
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (txtPrice.Text != "")
            {
                string lgsText;
                lgsText = txtPrice.Text.Replace(",", "");//숫자변환시 콤마로 발생하는 에러 방지
                txtPrice.Text = String.Format("{0:#,###}", Convert.ToInt32(lgsText));
                txtPrice.Select(txtPrice.Text.Length, 0);// 커서가 맨뒤로
                txtPrice.SelectionStart = txtPrice.Text.Length;//맨 마지막 선택...

            }
            else
            {
                txtPrice.Text = "0";
            }
        }

        /// <summary>
        /// price에 들어갈때  ' , '을 삭제 시켜준다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPrice_Enter(object sender, EventArgs e)
        {
            if (txtPrice.Text != "")
            {
                txtPrice.Text = txtPrice.Text.Replace(",", "");
            }
        }

        
        /// <summary>
        /// 위 패널을 통한 창이동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_MouseDown(object sender, MouseEventArgs e)
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
