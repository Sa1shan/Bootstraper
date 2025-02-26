using TMPro;
using UnityEngine;

namespace Source.Script.Game
{
    public class ScoreDisplay : MonoBehaviour
    {
        private TextMeshProUGUI _scoreText;
        private Score _score;

        public void Initialize(Score score)
        {
            this._score = score;
            _scoreText = GetComponent<TextMeshProUGUI>();
            score.OnScoreChanged += UpdateScore;
            UpdateScore(score.Value);
        }

        private void UpdateScore(int newScore)
        {
            _scoreText.text = $"Score: {newScore}";
        }
    }
}