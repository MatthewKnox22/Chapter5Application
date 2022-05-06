using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int iRnd = new int();

            iRnd = r.Next(0, 6);

            if (iRnd == 0) 
                diceOne.Show();
            else if (iRnd == 1)
                diceTwo.Show();
            else if (iRnd == 2)
                diceThree.Show();
            else if (iRnd == 3)
                diceFour.Show();
            else if (iRnd == 4)
                diceFive.Show();
            else if (iRnd == 5)
                diceSix.Show();

            if (iRnd == 0)
                diceOne.Show();
            else if (iRnd == 1)
                diceTwo.Show();
            else if (iRnd == 2)
                diceThree.Show();
            else if (iRnd == 3)
                diceFour.Show();
            else if (iRnd == 4)
                diceFive.Show();
            else if (iRnd == 5)
                diceSix.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            diceOne.Visible = false;
            diceTwo.Visible = false;
            diceThree.Visible = false;
            diceFour.Visible = false;
            diceFive.Visible = false;
            diceSix.Visible = false;
        }
    }
}
