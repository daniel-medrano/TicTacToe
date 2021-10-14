using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Game : Form
    {

        int moves;
        int turn;
        string winner;
        int player1;
        int player2;
        bool gameOver;

        Button[,] squares;
        public Game()
        {
            moves = 0;
            turn = 0;
            winner = "";
            player1 = 0;
            player2 = 0;
            gameOver = false;
            InitializeComponent();
            squares = new Button[3, 3] {
                { button1, button2, button3},
                { button4, button5, button6},
                { button7, button8, button9}
            };
            turnLabel.Text += "X";
        }

        private void NextTurn()
        {
            //Turn 0 for X, turn 1 for O.
            if (turn == 0)
            {
                turn = 1;
                turnLabel.Text = turnLabel.Text.Replace("X", "O");
            } 
            else
            {
                turn = 0;
                turnLabel.Text = turnLabel.Text.Replace("O", "X");
            }
        }

        private bool IsXTurn()
        {
            if (turn == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        private bool IsGameOver()
        {
            for (int row = 0; row < 3; row++)
            {
                if (squares[row, 0].Text != "" && squares[row, 1].Text == squares[row, 0].Text && squares[row, 2].Text == squares[row, 1].Text)
                {
                    winner = squares[row, 0].Text;
                    return true;
                }
            }

            for (int col = 0; col < 3; col++)
            {
                if (squares[0, col].Text != "" && squares[1, col].Text == squares[0, col].Text && squares[2, col].Text == squares[1, col].Text)
                {
                    winner = squares[0, col].Text;
                    return true;
                }
            }

            if (squares[0, 0].Text != "" && squares[1, 1].Text == squares[0, 0].Text && squares[2, 2].Text == squares[1, 1].Text)
            {
                winner = squares[0, 0].Text;
                return true;
            }
            if (squares[0, 2].Text != "" && squares[1, 1].Text == squares[0, 2].Text && squares[2, 0].Text == squares[1, 1].Text)
            {
                winner = squares[0, 2].Text;
                return true;
            }

            return false;
        }

        private bool IsADraw()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (squares[row, col].Enabled == true)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals(""))
            {
                if (IsXTurn())
                {
                    button1.Text = "X";
                } else
                {
                    button1.Text = "O";
                }
                button1.Enabled = false;
                UpdateData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text.Equals(""))
            {
                if (IsXTurn())
                {
                    button2.Text = "X";
                }
                else
                {
                    button2.Text = "O";
                }
                button2.Enabled = false;
                UpdateData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text.Equals(""))
            {
                if (IsXTurn())
                {
                    button3.Text = "X";
                }
                else
                {
                    button3.Text = "O";
                }
                button3.Enabled = false;
                UpdateData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text.Equals(""))
            {
                if (IsXTurn())
                {
                    button4.Text = "X";
                }
                else
                {
                    button4.Text = "O";
                }
                button4.Enabled = false;
                UpdateData();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text.Equals(""))
            {
                if (IsXTurn())
                {
                    button5.Text = "X";
                }
                else
                {
                    button5.Text = "O";
                }
                button5.Enabled = false;
                UpdateData();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text.Equals(""))
            {
                if (IsXTurn())
                {
                    button6.Text = "X";
                }
                else
                {
                    button6.Text = "O";
                }
                button6.Enabled = false;
                UpdateData();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text.Equals(""))
            {
                if (IsXTurn())
                {
                    button7.Text = "X";
                }
                else
                {
                    button7.Text = "O";
                }
                button7.Enabled = false;
                UpdateData();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text.Equals(""))
            {
                if (IsXTurn())
                {
                    button8.Text = "X";
                }
                else
                {
                    button8.Text = "O";
                }
                button8.Enabled = false;
                UpdateData();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text.Equals(""))
            {
                if (IsXTurn())
                {
                    button9.Text = "X";
                }
                else
                {
                    button9.Text = "O";
                }
                button9.Enabled = false;
                UpdateData();
            }
        }

        private void UpdateData()
        {
            string strMoves = "Moves: " + ++moves;
            movesLabel.Text = strMoves;

            if (IsGameOver())
            {
                MessageBox.Show("GAME OVER: " + winner + " won!");
                GameOver();
            }
            else if (IsADraw())
            {
                MessageBox.Show("GAME OVER: It is a draw.");
            }
            NextTurn();

        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit the game?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    squares[row, col].Text = "";
                    squares[row, col].Enabled = true;
                }
            }

            moves = 0;
            movesLabel.Text = "Moves: 0";
        }

        private void GameOver()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    squares[row, col].Enabled = false;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
