using UnityEngine;

namespace Score
{
    [RequireComponent(typeof(ScoreView))]
    public class ScoreController : MonoBehaviour
    {
        #region Variables

        private ScoreView _scoreView;
        private ScoreModel _scoreModel;

        #endregion
        
        #region MonoBehaviorMethods

        private void Start()
        {
            _scoreView = GetComponent<ScoreView>();
            _scoreModel = new ScoreModel();
        }
        #endregion

        #region OtherMethods

        public void UpdateScore()
        {
            _scoreModel.IncreaseScore();
            _scoreView.UpdateScore(_scoreModel.CurrentScore);
        }

        #endregion
    }
}