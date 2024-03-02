namespace Score
{
    public class ScoreModel
    {
        #region Properties
        
        public int CurrentScore { get; private set; }
        public int MaxScore { get; private set; }

        #endregion

        #region Methods

        public ScoreModel()
        {
            CurrentScore = 0;
        }

        public void IncreaseScore() => CurrentScore++;

        #endregion
    }
}