using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.unite_uygulama1_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double fiyat = Convert.ToDouble(textBox1.Text);
            if(radioButton3.Checked== true || radioButton2.Checked== true)
            {
                fiyat = fiyat + (fiyat * 0.05);
            }else if(radioButton4.Checked == true || radioButton5.Checked == true)
            {
                fiyat = fiyat + (fiyat * 0.10);
            }
            MessageBox.Show("tutarınız=" + fiyat.ToString());
        }
    }  
}   
