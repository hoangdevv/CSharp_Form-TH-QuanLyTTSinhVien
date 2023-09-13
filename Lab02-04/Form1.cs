using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //nút thêm/ cập nhật
        private void buttonThemUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxSTK.Text=="" || textBoxName.Text =="" || textBoxAddress.Text =="" || textBoxMoney.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        //hàm KT số tài khoản
        private int KTSTK(string STK)
        {
           for(int i = 0;i< listViewQLTTTK.Items.Count;i++)
            {
                if (listViewQLTTTK.Items[i].SubItems[0].Text == "STK")
                {
                    return i;
                }
            }
           return -1;
        }

        //Hàm thêm cập nhật thông tin
        
    }
}
