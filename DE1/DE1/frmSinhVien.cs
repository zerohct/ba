using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE1
{
    public partial class frmSinhVien : Form
    {
        private SinhVienModel context= new SinhVienModel();
        private SinhVienBLL sinhVienBLL;
        private LopBLL lopBLL;
        public frmSinhVien()
        {
            InitializeComponent();
            sinhVienBLL = new SinhVienBLL();
            lopBLL = new LopBLL();
        }
        private void HienThiLop()
        {
            List<LOP> listKhoa = lopBLL.GetAllKhoa();

            cblop.DataSource = listKhoa;
            cblop.DisplayMember = "TENLOP";
            cblop.ValueMember = "MALOP";
        }
        private void BindGrid(List<SINHVIEN> listSV)
        {
            gvSinhVien.Rows.Clear();

            foreach (SINHVIEN item in listSV)
            {
                int index = gvSinhVien.Rows.Add();
                gvSinhVien.Rows[index].Cells[0].Value = item.MASV;
                gvSinhVien.Rows[index].Cells[1].Value = item.HOTENSV;
                gvSinhVien.Rows[index].Cells[2].Value = item.NGAYSINH;
                gvSinhVien.Rows[index].Cells[3].Value = item.LOP.TENLOP;

            }
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            HienThiLop();
            BindGrid(sinhVienBLL.GetAllSinhVien());
            hienthikhikhongnhan();
        }
        private void hienthikhidanhan()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;
            btnLuu.Enabled = true;
            btnkoLuu.Enabled = true;
        }
        private void hienthikhinhan()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;
            btnLuu.Enabled = false;
            btnkoLuu.Enabled = false;
        }
        private void hienthikhikhongnhan()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = true;
            btnLuu.Enabled = false;
            btnkoLuu.Enabled = false;
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (txtMSSV.Text == "" || txtHoTenSV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (cblop.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DateTime ngaySinh = dtNS.Value;
                SINHVIEN sv = new SINHVIEN();
                sv.MASV = txtMSSV.Text;
                sv.HOTENSV = txtHoTenSV.Text;
                sv.MALOP = cblop.SelectedValue.ToString();
                sv.NGAYSINH = ngaySinh;
                sinhVienBLL.AddSinhVien(sv);
                BindGrid(sinhVienBLL.GetAllSinhVien());
                MessageBox.Show("Thêm sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hienthikhidanhan();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text;
            SINHVIEN sv = sinhVienBLL.GetSinhVienByMSSV(mssv);

            if (sv != null)
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn xóa sinh viên này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    sinhVienBLL.DeleteSinhVien(sv);

                    BindGrid(sinhVienBLL.GetAllSinhVien());
                    txtMSSV.Clear();
                    txtHoTenSV.Clear();
                    hienthikhidanhan();
                    MessageBox.Show("Xóa sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Mã sinh viên này không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text;
            DateTime ngaySinh = dtNS.Value;
            SINHVIEN sv = sinhVienBLL.GetSinhVienByMSSV(mssv);

            if (sv != null)
            {
                sv.MASV = txtMSSV.Text;
                sv.HOTENSV = txtHoTenSV.Text;
                sv.MALOP = cblop.SelectedValue.ToString();
                sv.NGAYSINH = ngaySinh;

                sinhVienBLL.UpdateSinhVien(sv);
                BindGrid(sinhVienBLL.GetAllSinhVien());

                MessageBox.Show("Sửa sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hienthikhidanhan();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("bạn có muốn thoát", "thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void gvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gvSinhVien.Rows.Count)
            {
                DataGridViewRow row = gvSinhVien.Rows[e.RowIndex];
                txtMSSV.Text = row.Cells[0].Value?.ToString();
                txtHoTenSV.Text = row.Cells[1].Value?.ToString();
                dtNS.Text = row.Cells[2].Value?.ToString();
                cblop.Text = row.Cells[3].Value?.ToString();
                SINHVIEN student = sinhVienBLL.GetSinhVienByMSSV(txtMSSV.Text);
                hienthikhinhan();
                if (student == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchName = txtsearch.Text;
            SinhVienBLL repository = new SinhVienBLL();
            BindGrid( repository.SearchSinhVienTheoTen(searchName));
            hienthikhikhongnhan();
           /* gvSinhVien.DataSource = searchResults;*/

        }
    }
}
