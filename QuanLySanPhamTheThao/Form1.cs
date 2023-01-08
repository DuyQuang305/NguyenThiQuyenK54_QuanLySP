using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanPhamTheThao
{
    public partial class Form1 : Form
    {
        struct SANPHAM
        {
            public string maSp;
            public string tenSp;
            public float soLuong;
            public float donGia;

        }

        SANPHAM[] DSSP;
        float[] Mang;
        int i = 0, n, STT;
        int viTriSua;

        public Form1()
        {
            InitializeComponent();
        }

        private void lsvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSanPham.SelectedItems.Count > 0)
            {
                viTriSua = int.Parse(lsvSanPham.SelectedItems[0].Text);

                txtMaSp.Text = lsvSanPham.SelectedItems[0].SubItems[1].Text;
                txtTenSp.Text = lsvSanPham.SelectedItems[0].SubItems[2].Text;
                txtSlSp.Text = lsvSanPham.SelectedItems[0].SubItems[3].Text;
                txtGiaSp.Text = lsvSanPham.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DSSP[viTriSua - 1].maSp = txtMaSp.Text;
            DSSP[viTriSua - 1].tenSp = txtTenSp.Text;
            DSSP[viTriSua - 1].soLuong = float.Parse(txtSlSp.Text);
            DSSP[viTriSua - 1].donGia = float.Parse(txtGiaSp.Text);

            lsvSanPham.Items.Clear();
            for (i = 0; i < n; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(DSSP[i].maSp);
                item.SubItems.Add(DSSP[i].tenSp);
                item.SubItems.Add(DSSP[i].soLuong.ToString());
                item.SubItems.Add(DSSP[i].donGia.ToString());
                lsvSanPham.Items.Add(item);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult key = MessageBox.Show("bạn có chắc chắn muốn xóa sản phẩm này?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (key == DialogResult.Yes)
            {
                i = 0;
                while (i < viTriSua - 1)
                    i++;
                for (i = viTriSua - 1; i < n; i++)
                    DSSP[i] = DSSP[i + 1];
                n--;
                lsvSanPham.Items.Clear();

                for (i = 0; i < n; i++)
                {
                    ListViewItem item = new ListViewItem((i + 1).ToString());
                    item.SubItems.Add(DSSP[i].maSp);
                    item.SubItems.Add(DSSP[i].tenSp);
                    item.SubItems.Add(DSSP[i].soLuong.ToString());
                    item.SubItems.Add(DSSP[i].donGia.ToString());
                    lsvSanPham.Items.Add(item);
                }
            }  
        }

      

        private void btnTimGia_Click(object sender, EventArgs e)
        {
            for (i = 0; i < n; i++)
                lsvSanPham.Items[i].BackColor = Color.White;
                
            float giaTim;
            bool timThay = false;
            giaTim = float.Parse(txtTimGia.Text);

            for (i=0; i<n;i++)
                if (DSSP[i].donGia == giaTim)
                {
                    timThay = true;
                    lsvSanPham.Items[i].BackColor = Color.Red;
                }
            if (timThay == false)
                MessageBox.Show("Không tìm thấy Giá: " + giaTim.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnTimTen_Click(object sender, EventArgs e)
        {
            for (i = 0; i < n; i++)
                lsvSanPham.Items[i].BackColor = Color.White;

            string tenTim;
            bool timThay = false;
            tenTim = txtTimTen.Text;

            for (i = 0; i < n; i++)
                lsvSanPham.Items[i].BackColor = Color.White;

            for (i = 0; i < n; i++)
                if (DSSP[i].tenSp == tenTim)
                {
                    timThay = true;
                    lsvSanPham.Items[i].BackColor = Color.Red;
                }
            if (timThay == false)
                MessageBox.Show("Không tìm thấy Giá: " + tenTim.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGiaMax_Click(object sender, EventArgs e)
        {
            i = 0;
            float giaMax;
            giaMax = DSSP[0].donGia;

            lsvSanPham.Items[i].BackColor = Color.White;

            for (i = 0; i < n; i++)
                if (giaMax < DSSP[i].donGia)
                    giaMax = DSSP[i].donGia;

            for (i = 0; i < n; i++)
                if (giaMax == DSSP[i].donGia)
                    lsvSanPham.Items[i].BackColor = Color.Red;
        }

        private void btnGiaMin_Click(object sender, EventArgs e)
        {
            i = 0;
            float giaMin;
            giaMin = DSSP[0].donGia;

            lsvSanPham.Items[i].BackColor = Color.White;

            for (i = 0; i < n; i++)
                if (giaMin > DSSP[i].donGia)
                    giaMin = DSSP[i].donGia;

            for (i = 0; i < n; i++)
                if (giaMin == DSSP[i].donGia)
                    lsvSanPham.Items[i].BackColor = Color.Red;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtMaSp.Text == "" || txtTenSp.Text == "" || txtSlSp.Text == "" || txtGiaSp.Text == "")
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                STT = i + 1;
                DSSP[i].maSp = txtMaSp.Text;
                DSSP[i].tenSp = txtTenSp.Text;
                DSSP[i].soLuong = float.Parse(txtSlSp.Text);
                DSSP[i].donGia = float.Parse(txtGiaSp.Text);

                ListViewItem item = new ListViewItem(STT.ToString());
                item.SubItems.Add(txtMaSp.Text);
                item.SubItems.Add(txtTenSp.Text);
                item.SubItems.Add(txtSlSp.Text);
                item.SubItems.Add(txtGiaSp.Text);
                lsvSanPham.Items.Add(item);
                i++;
                n++;

                txtMaSp.Clear();
                txtTenSp.Clear();
                txtSlSp.Clear();
                txtGiaSp.Clear();

                txtMaSp.Focus();
            }
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mang = new float[10];
            DSSP = new SANPHAM[10]; // Khởi tạo
            txtMaSp.Focus();
        }
    }     
}
