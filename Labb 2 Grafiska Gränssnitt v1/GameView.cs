using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labb_2_Grafiska_Gränssnitt_v1
{
    public partial class GameView : Form, IObserver
    {
        private int turn = 0;
        private GameControl _GC;
        private GameModel _GM;
        public GameView()
        {
            InitializeComponent();
            _GM = new GameModel();
            _GM.addObserver(this);
            _GC = new GameControl(_GM);
        }


        public void update(IObservable io, string arg)
        {
            //Console.WriteLine(_GM.playerTwo);
            if (_GM.isPlayerNamesSet)
            {
                turn = 1;
                playerOne_label.Text = _GM.playerOne;
                playerTwo_label.Text = _GM.playerTwo;
            }
            if (_GM.checkTurn())
            {
                currentPlayer_label.Text = _GM.playerOne+" spelar nu";
            }
            else
            {
                currentPlayer_label.Text = _GM.playerTwo+" spelar nu";
            }
            if(_GM.checkForWin()){
                //Console.WriteLine(arg);
                _GC.playerHasWon(arg);
            }
        }
        private void newGame_btn_Click(object sender, EventArgs e)
        {
            string tempPlayerOne = "";//playerOne_label.Text;
            string tempPlayerTwo = "";//playerTwo_label.Text;

            if (InputBox.Show("Spelare ett", "Namn:", ref tempPlayerOne) == DialogResult.OK){
                if(InputBox.Show("Spelare två", "Namn", ref tempPlayerTwo) == DialogResult.OK){
                    _GC.setNewGame(tempPlayerOne, tempPlayerTwo);
                }
            }
            game_btn0.Enabled = true;
            game_btn0.Text = "";
            game_btn1.Enabled = true;
            game_btn1.Text = "";
            game_btn2.Enabled = true;
            game_btn2.Text = "";
            game_btn3.Enabled = true;
            game_btn3.Text = "";
            game_btn4.Enabled = true;
            game_btn4.Text = "";
            game_btn5.Enabled = true;
            game_btn5.Text = "";
            game_btn6.Enabled = true;
            game_btn6.Text = "";
            game_btn7.Enabled = true;
            game_btn7.Text = "";
            game_btn8.Enabled = true;
            game_btn8.Text = "";
        }
        private void game_btn0_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                _GC.läggTillSymbol("X", 0);
                Button tempButton = (Button)sender;
                tempButton.Text = "X";
                tempButton.Enabled = false;
                turn = 2;
            }
            else if(turn == 2)
            {
                _GC.läggTillSymbol("O", 0);
                Button tempButton = (Button)sender;
                tempButton.Text = "O";
                tempButton.Enabled = false;
                turn = 1;
            }
        }
        private void game_btn1_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                _GC.läggTillSymbol("X", 1);
                Button tempButton = (Button)sender;
                tempButton.Text = "X";
                tempButton.Enabled = false;
                turn = 2;
            }
            else if (turn == 2)
            {
                _GC.läggTillSymbol("O", 1);
                Button tempButton = (Button)sender;
                tempButton.Text = "O";
                tempButton.Enabled = false;
                turn = 1;
            }
        }
        private void game_btn2_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                _GC.läggTillSymbol("X", 2);
                Button tempButton = (Button)sender;
                tempButton.Text = "X";
                tempButton.Enabled = false;
                turn = 2;
            }
            else if (turn == 2)
            {
                _GC.läggTillSymbol("O", 2);
                Button tempButton = (Button)sender;
                tempButton.Text = "O";
                tempButton.Enabled = false;
                turn = 1;
            }
        }
        private void game_btn3_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                _GC.läggTillSymbol("X", 3);
                Button tempButton = (Button)sender;
                tempButton.Text = "X";
                tempButton.Enabled = false;
                turn = 2;
            }
            else if (turn == 2)
            {
                _GC.läggTillSymbol("O", 3);
                Button tempButton = (Button)sender;
                tempButton.Text = "O";
                tempButton.Enabled = false;
                turn = 1;
            }
        }
        private void game_btn4_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                _GC.läggTillSymbol("X", 4);
                Button tempButton = (Button)sender;
                tempButton.Text = "X";
                tempButton.Enabled = false;
                turn = 2;
            }
            else if (turn == 2)
            {
                _GC.läggTillSymbol("O", 4);
                Button tempButton = (Button)sender;
                tempButton.Text = "O";
                tempButton.Enabled = false;
                turn = 1;
            }
        }
        private void game_btn5_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                _GC.läggTillSymbol("X", 5);
                Button tempButton = (Button)sender;
                tempButton.Text = "X";
                tempButton.Enabled = false;
                turn = 2;
            }
            else if (turn == 2)
            {
                _GC.läggTillSymbol("O", 5);
                Button tempButton = (Button)sender;
                tempButton.Text = "O";
                tempButton.Enabled = false;
                turn = 1;
            }
        }
        private void game_btn6_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                _GC.läggTillSymbol("X", 6);
                Button tempButton = (Button)sender;
                tempButton.Text = "X";
                tempButton.Enabled = false;
                turn = 2;
            }
            else if (turn == 2)
            {
                _GC.läggTillSymbol("O", 6);
                Button tempButton = (Button)sender;
                tempButton.Text = "O";
                tempButton.Enabled = false;
                turn = 1;
            }
        }
        private void game_btn7_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                _GC.läggTillSymbol("X", 7);
                Button tempButton = (Button)sender;
                tempButton.Text = "X";
                tempButton.Enabled = false;
                turn = 2;
            }
            else if (turn == 2)
            {
                _GC.läggTillSymbol("O", 7);
                Button tempButton = (Button)sender;
                tempButton.Text = "O";
                tempButton.Enabled = false;
                turn = 1;
            }
        }
        private void game_btn8_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                _GC.läggTillSymbol("X", 8);
                Button tempButton = (Button)sender;
                tempButton.Text = "X";
                tempButton.Enabled = false;
                turn = 2;
            }
            else if (turn == 2)
            {
                _GC.läggTillSymbol("O", 8);
                Button tempButton = (Button)sender;
                tempButton.Text = "O";
                tempButton.Enabled = false;
                turn = 1;
            }
        }
    }
}
