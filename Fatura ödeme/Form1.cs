using Fatura_ödeme.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatura_ödeme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Elektric elektric = new Elektric();

        private void btnTutar_Click(object sender, EventArgs e)
        {
            Water water = new Water();
            water.Pay(double.Parse(textBox1.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Elektric elektric= new Elektric();
            elektric.Pay(double.Parse(textBox2.Text));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NaturalGas naturalGas = new NaturalGas();
            naturalGas.Pay(double.Parse(textBox3.Text));

        }
    }
}
