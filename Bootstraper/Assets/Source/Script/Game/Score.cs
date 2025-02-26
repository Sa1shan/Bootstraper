using System;
using UnityEngine;

namespace Source.Script.Game
{
    public class Score
    {
        private int _value;
        public event Action<int> OnScoreChanged;

        public int Value
        {
            get => _value;
            set
            {
                this._value = value;
                OnScoreChanged?.Invoke(this._value);
            }
        }
    }
}