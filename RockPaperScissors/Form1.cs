using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();

        public static class Global
        {
            public static string compChoice, myChoice, winner;
        }

        private void form1_load(object sender, EventArgs e) 
        {
            getCompChoice();
        }

        private void getCompChoice()
        {
            //richTextBox1.Text = "";

            switch (rand.Next(3)+ 1)
            {
                case 1: Global.compChoice = "Rock"; break;
                case 2: Global.compChoice = "Paper"; break;
                case 3: Global.compChoice = "Scissors"; break;
            }
        }
        private void showWinner()
        {
            Random rand = new Random();


            if (Global.myChoice == "Rock" && Global.compChoice == "Scissors")
            {
                richTextBox1.Text = "player";
            }
            else if (Global.myChoice == "Rock" && Global.compChoice == "Paper")
            {
                richTextBox1.Text = "computer";
            }
            else if (Global.myChoice == "Rock" && Global.compChoice == "Rock")
            {
                richTextBox1.Text = "tie";
            }
            else if (Global.myChoice == "Scissors" && Global.compChoice == "Rock")
            {
                richTextBox1.Text = "computer";
            }
            else if (Global.myChoice == "Scissors" && Global.compChoice == "Paper")
            {
                richTextBox1.Text = "player";
            }
            else if (Global.myChoice == "Scissors" && Global.compChoice == "Scissors")
            {
                richTextBox1.Text = "tie";
            }
            else if (Global.myChoice == "Paper" && Global.compChoice == "Scissors")
            {
                richTextBox1.Text = "computer";
            }
            else if (Global.myChoice == "Paper" && Global.compChoice == "Rock")
            {
                richTextBox1.Text = "player";
            }
            else if (Global.myChoice == "Paper" && Global.compChoice == "Paper")
            {
                richTextBox1.Text = "tied";
            }                    
        }
        private void btnRock_Click(object sender, EventArgs e)
        {
            Global.myChoice = "Rock";
            getCompChoice();
            showWinner();
        }
        private void btnPaper_Click(object sender, EventArgs e)
        {
            Global.myChoice = "Paper";
            getCompChoice();
            showWinner();
        }
        private void btnScissors_Click(object sender, EventArgs e)
        {
            Global.myChoice = "Scissors";
            getCompChoice();
            showWinner();
        }
    }
}
