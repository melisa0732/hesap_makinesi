using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_mekinesi
{
    public partial class Form1 : Form
    {
        double sayı1 = 0,sayı2 = 0;
        int işlem = 0;
        double hesaplama = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_sonuç.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(tb_sonuç.Text == "0")
            {
                tb_sonuç.Text = "";
            }
                tb_sonuç.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_sonuç.Text == "0")
            {
                tb_sonuç.Text = ""; 
            }
                tb_sonuç.Text += "2";
        } 

        private void button11_Click(object sender, EventArgs e)
        {
            if (tb_sonuç.Text == "0")
            {
                tb_sonuç.Text = ""; 
            }
                tb_sonuç.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tb_sonuç.Text == "0")
            {
                tb_sonuç.Text = "";
            }
                tb_sonuç.Text += "4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_sonuç.Text == "0")
            {
                tb_sonuç.Text = "";
            }
                tb_sonuç.Text += "5";
        }       

        private void button13_Click(object sender, EventArgs e)
        {
            if (tb_sonuç.Text == "0")
            {
                tb_sonuç.Text = "";
            }
                tb_sonuç.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tb_sonuç.Text == "0")
            {
                tb_sonuç.Text = "";
            }
                tb_sonuç.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tb_sonuç.Text == "0")
            {
                tb_sonuç.Text = "";
            }
                tb_sonuç.Text += "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (tb_sonuç.Text == "0")
            {
                tb_sonuç.Text = "";
            }
                tb_sonuç.Text += "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (tb_sonuç.Text == "0")
            {
                tb_sonuç.Text = "";
            }
                tb_sonuç.Text += "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (tb_sonuç.Text == "0")
            {
                tb_sonuç.Text = "";  
            }
                tb_sonuç.Text += ",";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tb_sonuç.Text = "0";
        }

        //+ butonu
        private void button12_Click(object sender, EventArgs e)
        {
            işlem = 1;
            sayı1 = Convert.ToDouble(tb_sonuç.Text);
            tb_sonuç.Text = "";
        }

        //- butonu
        private void button14_Click(object sender, EventArgs e)
        {
            işlem = 2;
            sayı1 = Convert.ToDouble(tb_sonuç.Text);
            tb_sonuç.Text = "";
        }

        //x butonu
        private void button16_Click(object sender, EventArgs e)
        {
            işlem = 3;
            sayı1 = Convert.ToDouble(tb_sonuç.Text);
            tb_sonuç.Text = "";
        }

       

        //  / butonu
        private void button20_Click(object sender, EventArgs e)
        {
            işlem = 4;
            sayı1 = Convert.ToDouble(tb_sonuç.Text);
            tb_sonuç.Text = "";
        }

        // silme butonu
        private void button7_Click(object sender, EventArgs e)
        {
            string veri = tb_sonuç.Text;
            int i; 
            tb_sonuç.Text = "";
            for(i=0; i<veri.Length-1; i++)
            {              
                tb_sonuç.Text += veri[i].ToString();               
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sayı2 = Convert.ToDouble(tb_sonuç.Text);
            if (işlem == 1)
            {
                tb_sonuç.Text = ((sayı1 + sayı2).ToString());
            }
            else if (işlem == 2)
            {
                tb_sonuç.Text = ((sayı1 - sayı2).ToString());
            }
            else if (işlem == 3)
            {
                tb_sonuç.Text = ((sayı1 * sayı2).ToString());
            }
            else if (işlem == 4)
            {
                tb_sonuç.Text = ((sayı1 / sayı2).ToString());
            }

            
            
        }

        

    }
}
