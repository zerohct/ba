using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai6_01
{
    public partial class Form1 : Form
    {

        private Model1 context = new Model1();
        private LoaiSachBLL loaiSachBLL;
        private SachBLL sachBLL;
        public Form1()
        {
            InitializeComponent();
            loaiSachBLL = new LoaiSachBLL();
            sachBLL = new SachBLL();
        }
        private void HienThiTheLoai()
        {
            List<loaisach> listTL = loaiSachBLL.GetAllLoaiSach();

            cbTheLoai.DataSource = listTL;
            cbTheLoai.DisplayMember = "tenloai";
            cbTheLoai.ValueMember = "maloai";
        }
        private void BindGrid(List<sach> listSach)
        {
            gvSach.Rows.Clear();

            foreach (sach item in listSach)
            {
                int index = gvSach.Rows.Add();
                gvSach.Rows[index].Cells[0].Value = item.masach;
                gvSach.Rows[index].Cells[1].Value = item.tensach;
                gvSach.Rows[index].Cells[2].Value = item.namxb;
                gvSach.Rows[index].Cells[3].Value = item.loaisach.tenloai;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiTheLoai();
            BindGrid(sachBLL.GetAllSach());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "" || txtTenSach.Text == "" ||txtNam.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (cbTheLoai.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn thể loại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sach sv = new sach();
                sv.masach = Convert.ToInt32(txtMaSach.Text);
                sv.tensach = txtTenSach.Text;
                sv.maloai = Convert.ToInt32(cbTheLoai.SelectedValue.ToString());
                sv.namxb = Convert.ToInt32(txtNam.Text);
                sachBLL.AddSach(sv);
                BindGrid(sachBLL.GetAllSach());
                MessageBox.Show("Thêm sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int ms = Convert.ToInt32(txtMaSach.Text);
            sach sv = sachBLL.GetSACHByMaSach(ms);

            if (sv != null)
            {
                sv.masach = Convert.ToInt32(txtMaSach.Text);
                sv.tensach = txtTenSach.Text;
                sv.maloai = Convert.ToInt32(cbTheLoai.SelectedValue.ToString());
                sv.namxb = Convert.ToInt32(txtNam.Text);
                sachBLL.UpdateSach(sv);
                BindGrid(sachBLL.GetAllSach());
                MessageBox.Show("Sửa sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gvSach.Rows.Count)
            {
                DataGridViewRow row = gvSach.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells[0].Value?.ToString();
                txtTenSach.Text = row.Cells[1].Value?.ToString();
                txtNam.Text = row.Cells[2].Value?.ToString();
                cbTheLoai.Text = row.Cells[3].Value?.ToString();
                sach s = sachBLL.GetSACHByMaSach(Convert.ToInt32(txtMaSach.Text));
                if (s == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            int ms = Convert.ToInt32(txtMaSach.Text);
            sach sv = sachBLL.GetSACHByMaSach(ms);

            if (sv != null)
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn xóa sách này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    sachBLL.DeleteSach(sv);

                    BindGrid(sachBLL.GetAllSach());
                    txtMaSach.Clear();
                    txtNam.Clear();
                    txtTenSach.Clear();
                    MessageBox.Show("Xóa sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Mã sách này không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text;
            BindGrid(sachBLL.SearchSachTheoTen(searchName));
        }
    }
}
