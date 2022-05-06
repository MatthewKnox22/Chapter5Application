using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10Tutuor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static class global
        {
            public static int no1, no2, n3, ans;
            public static string no1t, no2t, n3t;
        }

        Random rand = new Random();
        int n1, n2, ans;

        private void button2_Click(object sender, EventArgs e)
        {
            global.no1 = rand.Next(101, 501);
            global.no2 = rand.Next(101, 501);
            global.no1t = global.no1.ToString();
            global.no2t = global.no2.ToString();
            label4.Text = global.no1t;
            label5.Text = global.no2t;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            global.n3 = global.no1 + global.no2;
            global.ans = int.Parse(textBoxAnswer.Text);
            if (global.ans == global.n3)
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Incorrect! The answer is " + (global.n3) + ".");
            }
        }

    }
}