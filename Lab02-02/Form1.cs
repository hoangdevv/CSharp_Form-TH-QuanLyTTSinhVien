using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Form-load
        private void Form1_Load(object sender, EventArgs e)
        {
            // mặc định chọn khoa ban đầu
            comboBoxCN.SelectedIndex = 0;
            // mặc định nữ đc checked
            checkBoxNu.Checked = true;
            // mặc định sỉ số cả nam và nữ bằng 0
            textBoxSSNam.Text = "0" ;
            textBoxSSNu.Text = "0" ;
        }

        // Thêm /sửa sinh viên
        private void buttonThemSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxMSSV.Text == "" || textBoxName.Text == "" || textBoxDTB.Text == "")
                {
                    throw new Exception("Vui lòng nhạp đầy đủ thông tin!");
                }
               
                // gán selectedRow có tồn tại mssv ko?
                int selectedRow = KiemTraSV(textBoxMSSV.Text);
                if (!kiemTraDTB(textBoxDTB.Text))
                {
                    MessageBox.Show("Nhâp lại điểm trung bình");
                }
                else
                {
                    if (selectedRow == -1) // khong ton tai
                    {
                        selectedRow = dataGridViewSV.Rows.Add(); //add 1 dòng mới
                        insertUpdate(selectedRow); //them thong tin vao ds
                        MessageBox.Show("Thêm sinh viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        countSLNamNu();
                    }
                    else // tồn tại thì cập nhật sửa lại trong ds
                    {
                        insertUpdate(selectedRow);
                        MessageBox.Show("Sửa sinh viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        countSLNamNu();
                    }
                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Ham kiem tra co ton tai sv bang 'mssv'
        private int KiemTraSV(string mssv)
        {
            for(int i = 0; i < dataGridViewSV.Rows.Count; i++)
            {

                if (dataGridViewSV.Rows[i].Cells[0].Value != null
                    && dataGridViewSV.Rows[i].Cells[0].Value.ToString() == mssv) // loại bỏ giá trị null và ss với mssv
                {
                    return i;
                }
            }
            return -1;
        }

        //Thêm / cập nhật thông tin
        private void insertUpdate(int selected)
        {
            dataGridViewSV.Rows[selected].Cells[0].Value = textBoxMSSV.Text;
            dataGridViewSV.Rows[selected].Cells[1].Value = textBoxName.Text;
            dataGridViewSV.Rows[selected].Cells[2].Value = checkBoxNu.Checked ? "Nữ" : "Nam";
            dataGridViewSV.Rows[selected].Cells[3].Value = float.Parse(textBoxDTB.Text).ToString();
            dataGridViewSV.Rows[selected].Cells[4].Value = comboBoxCN.Text;
        }

        //xóa sinh viên
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = KiemTraSV(textBoxMSSV.Text);
                if(selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy MSSV để xóa!");
                }
                else
                {
                    //dialogResult :đc sử dụng để thông báo kq,biểu thị cho ng dùng kq của
                    //hành động mà ng dùng thực hiện như "OK","CANCEL" hoặc "YES/NO" 
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes)
                    {
                        dataGridViewSV.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        countSLNamNu();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        //Hàm chỉ chọn nam hoạc nữ
        private void checkBoxNam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNam.Checked)
            {
                //chọn nam thì bỏ nữ
                checkBoxNu.Checked = false;
            }
        }
        private void checkBoxNu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNu.Checked)
            {
                //chọn nữ thì bỏ nam
                checkBoxNam.Checked = false;
            }
        }

        //Hàm đếm sỉ số nam và nữ
        private void countSLNamNu()
        {
            int tongSLNam = 0, tongSLNu = 0;
            for(int i = 0; i < dataGridViewSV.Rows.Count; i++)
            {
                object gioiTinh = dataGridViewSV.Rows[i].Cells[2].Value;
                if(gioiTinh != null && gioiTinh.ToString() == "Nam")
                {
                    tongSLNam++;
                }
                if(gioiTinh != null && gioiTinh.ToString() == "Nữ")
                {
                    tongSLNu++;
                }
            }
            textBoxSSNam.Text = $"{tongSLNam }";
            textBoxSSNu.Text = $"{tongSLNu}";

        }

        //Đề bài: chọn 1 dòng thể hiện ngược lại thông tin đã chọn sang phần nhập liệu
        //cellClick : sự kiện cho phép phản ứng khi ng dùng chọn 1 ô cụ thể
        private void dataGridViewSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewSV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) //giá trị từ ô được chọn khác null
                {
                    dataGridViewSV.CurrentRow.Selected = true; //highlight vào hàng được chọn

                    //FormattedValue: trả về, lấy giá trị dưới dạng 1 chuỗi đã đc định dạng 
                    textBoxMSSV.Text = dataGridViewSV.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    textBoxName.Text = dataGridViewSV.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    if (dataGridViewSV.Rows[e.RowIndex].Cells[2].FormattedValue.ToString() == "Nữ")
                    {
                        checkBoxNu.Checked = true;
                    }
                    else
                    {
                        checkBoxNam.Checked = true;
                    }
                    textBoxDTB.Text = dataGridViewSV.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    //SelectedItem :là pt trong comboBox , đại diện cho mục đc chọn trả về pt ng dùng đã chọn
                    comboBoxCN.SelectedItem = dataGridViewSV.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }


        private void textBoxDTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!kiemTraDTB(textBoxDTB.Text)){
                    MessageBox.Show("Nhập lại", "Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Hàm kt DTB
        private bool kiemTraDTB(string text)
        {
            bool ktDTB = float.TryParse(text, out float result);
            if (!ktDTB)
            {
                return false;
            }
            return true;
        }


    }
}
