using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odentiHesaplamaFormAplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double ilcePayi, bankaKesintisi, gmPayi, ilPayi, tom, gtom, tum;

            ilcePayi = Convert.ToDouble(textBox1.Text);
            bankaKesintisi = Convert.ToDouble(textBox2.Text);

            tom = (ilcePayi * 100) / 64;
            gmPayi = (tom * 20) / 100;
            ilPayi = (tom * 16) / 100;
            tum = (gmPayi + ilPayi);
            gtom = tom + bankaKesintisi;

            textBox3.Text = gmPayi.ToString();
            textBox4.Text = ilPayi.ToString();
            textBox5.Text = tum.ToString();
            textBox6.Text = gtom.ToString();
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            panel1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
