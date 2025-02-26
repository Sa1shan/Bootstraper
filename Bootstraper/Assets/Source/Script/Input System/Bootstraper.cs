using Source.Script.Game;
using TMPro;
using UnityEngine;

namespace Source.Script.Input_System
{
    public class Bootstraper : MonoBehaviour
    {
        [SerializeField] private GameObject targetObject;
        [SerializeField] private GameObject movingObject;
        [SerializeField] private TextMeshProUGUI scoreText;

        private Score _score;
        private Games _games;

        private void Awake()
        {
            _score = new Score();
            _games = new Games(_score);
        
            InputListener inputListener = gameObject.AddComponent<InputListener>();
            inputListener.Initialize(_games);
        
            ClickHandler clickHandler = targetObject.AddComponent<ClickHandler>();
            clickHandler.Initialize(_score, -1);
        
            ClickHandler movingClickHandler = movingObject.AddComponent<ClickHandler>();
            movingClickHandler.Initialize(_score, 1);
        
            ScoreDisplay scoreDisplay = scoreText.gameObject.AddComponent<ScoreDisplay>();
            scoreDisplay.Initialize(_score);
        
            MovingObjects mover = movingObject.AddComponent<MovingObjects>();
            mover.Initialize();
        }
    }
}
