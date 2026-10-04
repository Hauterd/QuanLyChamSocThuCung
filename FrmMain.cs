using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyChamSocThuCung
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            btnTrangChu.Click -= btnTrangChu_Click;
            btnTrangChu.Click += btnTrangChu_Click;

            btnKhachHang.Click -= btnKhachHang_Click;
            btnKhachHang.Click += btnKhachHang_Click;

            btnThuCung.Click -= btnThuCung_Click;
            btnThuCung.Click += btnThuCung_Click;
        }



        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            HienThiTrangChu();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {

            this.Hide();

            FrmKhachHang frm = new FrmKhachHang();

            frm.FormClosed += (s, args) =>
            {
                 this.Show();
            };

             frm.Show();

        }

        private void btnThuCung_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmThuCung frm = new FrmThuCung();

            frm.FormClosed += (s, args) =>
            {
                this.Show();
            };

            frm.Show();
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            /*this.Hide();

            FrmThuCung frm = new FrmThuCung();

            frm.FormClosed += (s, args) =>
            {
                this.Show();
            };

            frm.Show();*/
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            //MoForm(new FrmDichVu());
        }

        private void btnLichChamSoc_Click(object sender, EventArgs e)
        {
            //MoForm(new FrmLichChamSoc());
        }

        private void btnHoSoSucKhoe_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmHoSoSucKhoe frm = new FrmHoSoSucKhoe();

            frm.FormClosed += (s, args) =>
            {
                this.Show();
            };

            frm.Show();
        }

        private void btnTiemChung_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmTiemChung frm = new FrmTiemChung();

            frm.FormClosed += (s, args) =>
            {
                this.Show();
            };

            frm.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            //MoForm(new FrmHoaDon());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            //MoForm(new FrmThongKe());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MoForm(Form form)
        {
            // Xóa form/chức năng hiện tại trong vùng nội dung
            pnlContent.Controls.Clear();

            // Thiết lập Form con
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Đưa Form con vào pnlContent
            pnlContent.Controls.Add(form);



            // Hiển thị Form
            form.Show();
        }
        private void HienThiTrangChu()
        {
            pnlContent.Controls.Clear();

            pnlContent.Controls.Add(pnlTrangChu);

            pnlTrangChu.Dock = DockStyle.Fill;
            pnlTrangChu.Visible = true;
        }

        private void lblChaoMung_Click(object sender, EventArgs e)
        {

        }
    }
}
