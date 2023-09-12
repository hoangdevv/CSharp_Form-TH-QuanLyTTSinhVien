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
        private Dictionary<string, int> giaGhe = new Dictionary<string, int>
        {
            { "Button1", 30000 },
            { "Button2", 30000 },
            { "Button3", 30000 },
            { "Button4", 30000 },
            { "Button5", 30000 },
            { "Button6", 40000 },
            { "Button7", 40000 },
            { "Button8", 40000 },
            { "Button9", 40000 },
            { "Button210", 40000 },
            { "Button11", 50000 },
            { "Button12", 50000 },
            { "Button13", 50000 },
            { "Button14", 50000 },
            { "Button15", 50000 },
            { "Button16", 80000 },
            { "Button17", 80000 },
            { "Button18", 80000 },
            { "Button19", 80000 },
            { "Button20", 80000 }
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Control ct in groupBoxButton.Controls)
            {
                if(ct is Button)
                {
                    Button bt = (Button)ct;
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

            
                //
            }

        }


        private void buttonChon_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tongTien = 0;
            if (btn != null)
            {
                if (btn.BackColor == System.Drawing.Color.Blue)
                {
                    btn.BackColor = System.Drawing.Color.Yellow;
                    
                }
            }
        }
    }
}
