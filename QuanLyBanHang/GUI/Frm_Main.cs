using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.GUI
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_nhanvien"] == null)
            {
                frm_nhanvien ttkh = new frm_nhanvien();
                ttkh.MdiParent = this;
                ttkh.Show();
            }
            else
            {
                Application.OpenForms["frm_nhanvien"].Activate();
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_khachhang"] == null)
            {
                frm_khachhang ttkh = new frm_khachhang();
                ttkh.MdiParent = this;
                ttkh.Show();
            }
            else
            {
                Application.OpenForms["frm_khachhang"].Activate();
            }
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_hanghoa"] == null)
            {
                frm_hanghoa tthh = new frm_hanghoa();
                tthh.MdiParent = this;
                tthh.Show();
            }
            else
            {
                Application.OpenForms["frm_hanghoa"].Activate();
            }
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_nhacungcap"] == null)
            {
                frm_nhacungcap ttkh = new frm_nhacungcap();
                ttkh.MdiParent = this;
                ttkh.Show();
            }
            else
            {
                Application.OpenForms["frm_nhacungcap"].Activate();
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_thongke"] == null)
            {
                frm_thongke ttkh = new frm_thongke();
                ttkh.MdiParent = this;
                ttkh.Show();
            }
            else
            {
                Application.OpenForms["frm_thongke"].Activate();
            }
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_hoadon"] == null)
            {
                frm_hoadon tthd = new frm_hoadon();
                tthd.MdiParent = this;
                tthd.Show();
            }
            else
            {
                Application.OpenForms["frm_hoadon"].Activate();
            }
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_thongtin"] == null)
            {
                frm_thongtin tt = new frm_thongtin();
                tt.MdiParent = this;
                tt.Show();
            }
            else
            {
                Application.OpenForms["frm_thongtin"].Activate();
            }
        }

        
    }
}
