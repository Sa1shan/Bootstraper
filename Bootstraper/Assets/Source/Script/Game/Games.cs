using UnityEngine;

namespace Source.Script.Game
{
    public class Games
    {
        private Score _score;
    
        public Games(Score score)
        {
            this._score = score;
            StartGame();
        }
    
        private void StartGame()
        {
            _score.Value = 5;
        }
    
        public void ExitGame()
        {
            _score.Value = 0;
            Application.Quit();
        }
    }
}