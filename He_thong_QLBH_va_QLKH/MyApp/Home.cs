using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
            labelHome.Text = btnNV.Text;

        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLKH());
            labelHome.Text = btnKH.Text;
        }


        private void btnDH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDonHang());
            labelHome.Text = btnDH.Text;
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanPham());
            labelHome.Text = btnSP.Text;
        }

        private void btnKN_Click(object sender, EventArgs e)
        {            
            OpenChildForm(new frmKhieuNai());
            labelHome.Text = btnKN.Text;            
        }
    }
}
