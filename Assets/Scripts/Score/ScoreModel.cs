namespace Score
{
    public class ScoreModel
    {
        public int CurrentScore { get; private set; }
        public int MaxScore { get; private set; }
        public void CreateModel()
        {
            CurrentScore = 0;
        }

        public void UpdateScore() => CurrentScore++;
    }
}