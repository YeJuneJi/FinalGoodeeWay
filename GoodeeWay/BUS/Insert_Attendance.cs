﻿using GoodeeWay.DAO;
using GoodeeWay.VO;
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

namespace GoodeeWay.BUS
{
    public partial class Insert_Attendance : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        public Insert_Attendance()
        {
            InitializeComponent();
        }

        AttendanceDAO atd = new AttendanceDAO();
        Attendance_SearchEmpno ase = new Attendance_SearchEmpno();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ase = new Attendance_SearchEmpno();
            ase.FormClosed += new FormClosedEventHandler(aseForm_FormClosed);
            ase.Show();
        }

        private void aseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtEmpno.Text = ase.empno;
        }
        
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //dtpTotaltime.Value = TimeSpan.FromHours.dtpTotaltime;

            var at = new AttendanceVO()
            {
                Empno = txtEmpno.Text,
                Date = DateTime.Parse(dtpDate.Text),
                TotalPay = float.Parse(txtTotalpay.Text),
                TimeIn = DateTime.Parse(dtpIn.Text),
                TimeOut = DateTime.Parse(dtpOut.Text),
                OverTime = DateTime.Parse(dtpOvertime.Text),
                TotalTime = DateTime.Parse(dtpTotaltime.Text),
                Note = txtNote.Text
            };

            if (atd.InsertAttendance(at))
            {
                MessageBox.Show("입력 성공");
            }
            else
            {
                MessageBox.Show("입력 실패");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpno.Text = "";
            txtTotalpay.Text = "";
            txtNote.Text = "";
        }

        private void Insert_Attendance_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // 다른 컨트롤에 묶여있을 수 있을 수 있으므로 마우스캡쳐 해제
                ReleaseCapture();

                // 타이틀 바의 다운 이벤트처럼 보냄
                SendMessage(this.Handle, WM_NLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
