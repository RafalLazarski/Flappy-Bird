namespace Assets.Scripts
{
    [System.Serializable]
    public class PlayerBestScore
    {
        public int Score;

        public PlayerBestScore(ScoreReader scoreReader)
        {
            Score = scoreReader.BestScore;
        }
    }
}
