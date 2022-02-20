using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sou_bankası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dogru = 0;
            int yanlis = 0;
            
            if (radioButton2.Checked)
            {
                dogru = dogru + 1;
            }
            if (radioButton4.Checked)
            {
                dogru = dogru + 1;
            }
            if (radioButton9.Checked)
            {
                dogru = dogru + 1;
            }
            if (radioButton10.Checked)
            {
                dogru = dogru + 1;
            }
            yanlis = 4 - dogru;
            linkLabel1.Text = "dogru sayisi = " + dogru.ToString() + "yanlis sayisi== " + yanlis.ToString();
        }
    }
}
