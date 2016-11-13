using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeeganRobertRockPaperScissors
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public static string playerChoice;
        public static string computerChoice;

        public static int computerScoreCount = 0;
        public static int playerScoreCount = 0;
        public static int drawCount = 0;

        public static string playerScore = "0";
        public static string computerScore = "0";
        public static string drawScore = "0";
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Computer Scores " + computerScore + " and Player Scores " + playerScore + " with " + drawScore + " draws");
            this.Close();
        }
        
        private void buttonPaper_Click(object sender, EventArgs e)
        {
            playerChoice = "Paper";
            computerChoiceStart();

        }

        private void buttonRock_Click(object sender, EventArgs e)
        {
            playerChoice = "Rock";
            computerChoiceStart();
        }

        private void buttonScissors_Click(object sender, EventArgs e)
        {
            playerChoice = "Scissors";
            computerChoiceStart();
        }

        public void computerChoiceStart()
        {

            Random RandomNumber = new Random();
            int x = RandomNumber.Next(0, 3);
            if (x == 0)
            {
                computerChoice = "Rock";
            }
            if (x == 1)
            {
                computerChoice = "Paper";
            }
            if (x == 2)
            {
                computerChoice = "Scissors";
            }
            results();

        }

        public void results()
        {
            if (computerChoice == "Rock" && playerChoice == "Rock" || computerChoice == "Scissors" && playerChoice == "Scissors" ||
                  computerChoice == "Paper" && playerChoice == "Paper")
            {
                playerChoiceTextBox.Text = ("Player choose " + playerChoice);
                computerChoiceTextBox.Text = ("Computer choose " + computerChoice);

                drawCount++;
                drawScore = drawCount.ToString();
                drawLabel.Text = (drawScore);

            }

            if (computerChoice == "Paper" && playerChoice == "Rock" ||
                computerChoice == "Scissors" && playerChoice == "Paper" ||
                computerChoice == "Rock" && playerChoice == "Scissors")
            {
                
                playerChoiceTextBox.Text = ("Player choose " + playerChoice);
                computerChoiceTextBox.Text = ("Computer choose " + computerChoice);
                
                computerScoreCount++;
                computerScore = computerScoreCount.ToString();
                computerScoreLabel.Text = (computerScore);
                
            }

            if (playerChoice == "Paper" && computerChoice == "Rock" ||
                playerChoice == "Scissors" && computerChoice == "Paper" ||
                playerChoice == "Rock" && computerChoice == "Scissors")
            {
                
                playerChoiceTextBox.Text = ("Player choose " + playerChoice);
                computerChoiceTextBox.Text = ("Computer choose " + computerChoice);
                
                playerScoreCount++;
                playerScore = playerScoreCount.ToString();
                playerScoreLabel.Text = (playerScore);
    
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
