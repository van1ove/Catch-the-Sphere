using UnityEngine;
using System;

namespace Score
{
    [RequireComponent(typeof(ScoreView))]
    public class ScoreController : MonoBehaviour
    {
        #region Classes

        private ScoreView _scoreView;
        private ScoreModel _scoreModel;

        #endregion

        #region Delegates
        
        public static Action SetNewScore;

        #endregion

        #region MonoBehaviorMethods

        private void Start()
        {
            _scoreView = GetComponent<ScoreView>();
            _scoreModel = new ScoreModel();
        }

        private void OnEnable()
        {
            SetNewScore += UpdateScore;
        }

        private void OnDisable()
        {
            SetNewScore -= UpdateScore;
        }

        #endregion

        #region OtherMethods

        private void UpdateScore()
        {
            _scoreModel.IncreaseScore();
            _scoreView.UpdateScore(_scoreModel.CurrentScore);
        }

        #endregion
    }
}