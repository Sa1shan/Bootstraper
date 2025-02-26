using UnityEngine;

namespace Source.Script.Game
{
    public class ClickHandler : MonoBehaviour
    {
        private Score _score;
        private int _scoreChange;

        public void Initialize(Score score, int scoreChange)
        {
            this._score = score;
            this._scoreChange = scoreChange;
        }

        private void OnMouseDown()
        {
            _score.Value += _scoreChange;
        }
    }
}