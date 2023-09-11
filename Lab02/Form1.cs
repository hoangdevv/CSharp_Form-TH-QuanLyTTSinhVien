using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //btn cong
        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                float a, b, result;
                a = float.Parse(textInputA.Text);
                b = float.Parse(textInputB.Text);
                result = a + b;
                textInputKQ.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Co loi. Hay thu lai", "Thong bao");
            }
        }

        //btn tru
        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                float a, b, result;
                a = float.Parse(textInputA.Text);
                b = float.Parse(textInputB.Text);
                result = a - b;
                textInputKQ.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Co loi. Hay thu lai", "Thong bao");
            }
        }

        //btn nhan

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                float a, b, result;
                a = float.Parse(textInputA.Text);
                b = float.Parse(textInputB.Text);
                result = a * b;
                textInputKQ.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Co loi. Hay thu lai","Thong bao");
            }
        
        }

        //btn chia
        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                float a, b, result;
                a = float.Parse(textInputA.Text);
                b = float.Parse(textInputB.Text);
                result = a / b;
                textInputKQ.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Co loi. Hay thu lai", "Thong bao");
            }
           
        }

        //input kq
       private void textInputKQ_TextChanged(object sender, EventArgs e)
       {
            
       }

        //thay doi, dieu khien noi dung 
        private void textInputA_TextChanged(object sender, EventArgs e)
        {
            if (!checkNumber(textInputA.Text))
            {
                MessageBox.Show("Hay nhap dung dinh dang!", "Canh bao", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void textInputB_TextChanged(object sender, EventArgs e)
        {
            if (!checkNumber(textInputB.Text))
            {
                MessageBox.Show("Hay nhap dung dinh dang!", "Canh bao", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        //ham kiem tra so hay chu
        private bool checkNumber(string text)
        {
            bool resultText = float.TryParse(text, out float result);
            if (!resultText)
            {
                return false;
            }
            return true;
        }

    }
}
