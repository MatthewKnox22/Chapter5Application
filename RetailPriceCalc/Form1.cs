using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailPriceCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double wholesale = double.Parse(txtWholesale.Text);
            double markup = double.Parse(txtMarkup.Text);
            double markupPercent = 1 + markup / 100;
            double retailPrice;

            double result = wholesale * markupPercent;
            double price = Math.Round(result, 2);
            CalculateRetail.Text = price.ToString();

        }
    }
}