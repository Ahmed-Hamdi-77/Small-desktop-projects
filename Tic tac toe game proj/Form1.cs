using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe_game_proj
{
    public partial class TicTacfrm: Form
    {
      
        stGameStatus GameStatues;
        enPlayer PlayerTurn = enPlayer.player1;
        int ScoreP1 = 0;
        int ScoreP2 = 0;

        enum enPlayer
        {
            player1,
            player2,
            NoOne
        }

        enum enWinner
        {
            player1,
     
            player2,
            draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short playCount;

        }

        public void EndGame()
        {
            lblTurn.Text = "Game Over";
            switch(GameStatues.Winner)
            {
                case enWinner.player1:
                    lblWinner.Text = "Player1";
                    break;
                case enWinner.player2:
                    lblWinner.Text = "Player2";
                    break;

                default:
                    lblWinner.Text = "Draw";
                    break;
            }
            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PlayerTurn = enPlayer.NoOne;

        }
        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag == null || btn2.Tag == null || btn3.Tag == null)
                return false;

            if (btn1.Tag.ToString()!="?" && btn1.Tag.ToString()== btn2.Tag.ToString()&& btn1.Tag.ToString()== btn3.Tag.ToString())
            {
                btn1.BackColor = Color.LimeGreen;
                btn2.BackColor = Color.LimeGreen;
                btn3.BackColor = Color.LimeGreen;

                if (btn1.Tag.ToString()=="X")
                {
                    GameStatues.Winner = enWinner.player1;
                    GameStatues.GameOver = true;
                    SetScore();
                    EndGame();
                    return true;
                }
                else if(btn1.Tag.ToString()=="O")
                {
                    GameStatues.Winner = enWinner.player2;
                    GameStatues.GameOver = true;
                    SetScore();
                    EndGame();
                    return true;
                }
            }
            GameStatues.GameOver = false;
            return false;
        }

        public void CheckWinner()
        {
            if (CheckValues(btn1, btn2, btn3))
                return;
            if (CheckValues(btn4, btn5, btn6))
                return;
            if (CheckValues(btn7, btn8, btn9))
                return;
            if (CheckValues(btn1, btn4, btn7))
                return;
            if (CheckValues(btn2, btn5, btn8))
                return;
            if (CheckValues(btn3, btn6, btn9))
                return;
            if (CheckValues(btn1, btn5, btn9))
                return;
            if (CheckValues(btn3, btn5, btn7))
                return;
        }

        public void SetScore()
        {
            
            if (GameStatues.Winner==enWinner.player1)
            {
                ScoreP1++;
                lblP1Score.Tag=ScoreP1;                
                lblP1Score.Text = lblP1Score.Tag.ToString();
            }
            else if(GameStatues.Winner==enWinner.player2)
            {
                ScoreP2++;
                lblP2Score.Tag = ScoreP2;
                lblP2Score.Text = lblP2Score.Tag.ToString();
            }
        }
        public void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString()=="?")
            {
                switch(PlayerTurn)
                {
                    case enPlayer.player1:

                        btn.BackgroundImage = Properties.Resources.X_Sign;
                        btn.Tag = "X";
                        lblTurn.Text = "Player2";
                        GameStatues.playCount++;                        
                        PlayerTurn = enPlayer.player2;
                        CheckWinner();
                        break;
                    case enPlayer.player2:
                        btn.BackgroundImage = Properties.Resources.O_Sign;
                        btn.Tag = "O";
                        lblTurn.Text = "Player1";
                        GameStatues.playCount++;
                        PlayerTurn = enPlayer.player1;
                        CheckWinner();
                        
                        break;
                    case enPlayer.NoOne:
                        MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                                  
            }
            else
            {
                MessageBox.Show("Wrong choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(GameStatues.playCount==9)
            {
                GameStatues.GameOver = true;
                GameStatues.Winner = enWinner.draw;
                EndGame();
            }
        }
        public TicTacfrm()
        {
            InitializeComponent();
        }

        private void TicTacfrm_Paint(object sender, PaintEventArgs e)
        {
            Color black = Color.FromArgb(255, 0, 0, 0);
            Pen pen = new Pen(black, 15);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            
            e.Graphics.DrawLine(pen, 600, 350, 1250, 350);
            e.Graphics.DrawLine(pen, 600, 510, 1250, 510);

            e.Graphics.DrawLine(pen,810,190,810,670);
            e.Graphics.DrawLine(pen, 1040, 190, 1040, 670);
            

        }

        private void btn_Click(object sender, EventArgs e)
        {
            ChangeImage((Button) sender);
        }

        public void RestButton(Button btn)
        {
            btn.Tag = "?";
            btn.BackgroundImage = Properties.Resources.Question_Mark;
            btn.BackColor = Color.Indigo;
            

        }
        public void RestartGame()
        {
            RestButton(btn1);
            RestButton(btn2);
            RestButton(btn3);
            RestButton(btn4);
            RestButton(btn5);
            RestButton(btn6);
            RestButton(btn7);
            RestButton(btn8);
            RestButton(btn9);

            PlayerTurn = enPlayer.player1;
            lblTurn.Text = "Player1";
            GameStatues.Winner = enWinner.GameInProgress;
            lblWinner.Text = "In Progress";
            GameStatues.playCount = 0;
            GameStatues.GameOver = false;
            
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            lblP2Score.Tag = 0;
            lblP2Score.Text = lblP2Score.Tag.ToString();
            lblP1Score.Tag = 0;
            lblP1Score.Text = lblP1Score.Tag.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
