using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_03
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Control ct in groupBoxButton.Controls)
            {
                if(ct is Button)
                {
                    Button bt = (Button)ct;//thực hiện ép kiểu 'ct' về kiểu 'Button'
                                           //->để truy cập thuộc tính và phương thức của Button
                    bt.BackColor = Color.White;
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                //set màu cho ghế
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                }
                else if (btn.BackColor == Color.Blue)
                {
                    btn.BackColor = Color.White;
                }
                else if (btn.BackColor == Color.Yellow)
                {
                    MessageBox.Show("Ghế đã có người!");
                }
            }

        }


        private void buttonChon_Click(object sender, EventArgs e)
        {
            double sum = 0;
            foreach(Control ct in groupBoxButton.Controls)
            {
                if( ct is Button)
                {
                    Button bt = ( Button)ct;
                    if( bt.BackColor == Color.Blue)
                    {
                        bt.BackColor = Color.Yellow;
                        switch(bt.Name) 
                        {
                            case "button1":
                            case "button2":
                            case "button3":
                            case "button4":
                            case "button5":
                                {
                                    sum += 30000;
                                    break;
                                }
                            case "button6":
                            case "button7":
                            case "button8":
                            case "button9":
                            case "button10":
                                {
                                    sum += 40000;
                                    break;
                                }
                            case "button11":
                            case "button12":
                            case "button13":
                            case "button14":
                            case "button15":
                                {
                                    sum += 50000;
                                    break;
                                }
                            case "button16":
                            case "button17":
                            case "button18":
                            case "button19":
                            case "button20":
                                {
                                    sum += 80000;
                                    break;
                                }
                        }
                    }
                }
            }
            textTongTien.Text = sum.ToString();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            foreach(Control control in groupBoxButton.Controls)
            {
                if( control is Button)
                {
                    Button bt = (Button)control;
                    if(bt.BackColor == Color.Blue)
                    {
                        bt.BackColor = Color.White;
                    }
                }
            }
            textTongTien.Text = 0.ToString();
        }

        private void buttonKThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
