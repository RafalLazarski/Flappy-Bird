using Assets.Scripts;
using TMPro;
using UnityEngine;

public class ScoreReader : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    [SerializeField]
    private PipesCounter pipesCounter;

    public int BestScore;
    private PlayerBestScore playerBestScore;

    public void SaveScore()
    {
        SaveRecords.SaveRecord(new PlayerBestScore(this));
    }

    public void LoadScore()
    {
        playerBestScore = SaveRecords.LoadRecord();
        if(playerBestScore != null)
        {
            BestScore = playerBestScore.Score;
        }
        else
        {
            BestScore = 0;
        }
    }

    private void Start()
    {
        LoadScore();
    }

    private void Update()
    {
        scoreText.text = $"The best score: {BestScore}\nCurrent score: {pipesCounter.Score}";

        if(BestScore < pipesCounter.Score)
        {
            BestScore = pipesCounter.Score;
            SaveScore();
        }
    }

}



