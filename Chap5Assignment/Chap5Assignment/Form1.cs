using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap5Assignment
{
    public partial class DistCalc : Form
    {
        public DistCalc()
        {
            InitializeComponent();
        }

        private void textBoxMPH_TextChanged(object sender, EventArgs e)
        {
            string distance;

            distance = textBoxMPH.Text;

            int.Parse(distance);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int answer

            answer = distance * time; 
        }

        private void textBoxHours_TextChanged(object sender, EventArgs e)
        {
            int hours;

            hours = textBoxHours.Text;

            int.Parse(hours);
        }
    }
}
