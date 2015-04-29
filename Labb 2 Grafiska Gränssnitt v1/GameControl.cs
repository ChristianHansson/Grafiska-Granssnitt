﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labb_2_Grafiska_Gränssnitt_v1
{
    class GameControl
    {
        private GameModel _GM;
        public GameControl(GameModel inGameModel)
        {
            _GM = inGameModel;
        }
        public void läggTillSymbol(String inSymbol, int pos)
        {
            
            if(inSymbol == "X"){
                _GM.setBtnValue(pos, inSymbol);
                _GM.turnIsTrue();
            }
            else
            {
                _GM.setBtnValue(pos, inSymbol);
                _GM.turnIsFalse();
            }
            checkForWinControl();
        }
        /**This method, that runs every time user presses a game button, will check the data in the model
	 * to see if any user has won or not. 
	 * */
        public void checkForWinControl()
        {
            for (int outer = 0; outer < _GM.winCombos.Count; outer++)
            {
                if (_GM.btnValues[_GM.winCombos[outer][0]] == _GM.btnValues[_GM.winCombos[outer][1]] &&
                        _GM.btnValues[_GM.winCombos[outer][1]] == _GM.btnValues[_GM.winCombos[outer][2]] &&
                            _GM.btnValues[_GM.winCombos[outer][2]] != null)
                {
                    _GM.winBecomesTrue(_GM.btnValues[_GM.winCombos[outer][0]]);
                }
            }
        }
        /*
         * Method that runs when a user selects a new game. It resets the gameModel and set new usernames.
         */
        public void setNewGame(String inPlayerOne, String inPlayerTwo)
        {
            _GM.setNullGameState();
            _GM.setPlayerOneName(inPlayerOne);
            _GM.setPlayerTwoName(inPlayerTwo);
            _GM.playersIsSet();
        }
        public void playerHasWon(string inWinningPlayer)
        {
            DialogResult d = MessageBox.Show(inWinningPlayer+" vann", "En hars vunnit!", MessageBoxButtons.OK);
        }
    }
}
