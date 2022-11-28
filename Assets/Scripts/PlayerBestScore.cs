namespace Assets.Scripts
{
    [System.Serializable]
    internal class PlayerBestScore
    {
        public int score;
        private ScoreReader scoreReader;

        public PlayerBestScore()
        {
            score = scoreReader.BestScore;
        }
    }
}
