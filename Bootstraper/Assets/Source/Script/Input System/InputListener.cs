using Source.Script.Game;
using UnityEngine;

namespace Source.Script.Input_System
{
    public class InputListener : MonoBehaviour
    {
        private Games _game;

        public void Initialize(Games game)
        {
            this._game = game;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                _game.ExitGame();
            }
        }
    }
}