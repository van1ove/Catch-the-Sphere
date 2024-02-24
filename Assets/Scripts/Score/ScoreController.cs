using UnityEngine;

namespace Score
{
    [RequireComponent(typeof(ScoreView))]
    public class ScoreController : MonoBehaviour
    {
        #region Classes

        private ScoreView _scoreView;
        private ScoreModel _scoreModel;

        #endregion

        #region Methods

        private void Start()
        {
            _scoreView = GetComponent<ScoreView>();
            _scoreModel.CreateModel();
        }

        private void UpdateScore()
        {
            _scoreModel.UpdateScore();
            _scoreView.UpdateScore(_scoreModel.CurrentScore);
        }

        #endregion
    }
}