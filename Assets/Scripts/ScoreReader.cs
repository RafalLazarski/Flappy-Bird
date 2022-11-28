using TMPro;
using UnityEngine;

public class ScoreReader : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    [SerializeField]
    private PipesCounter pipesCounter;

    public int BestScore;

    void Update()
    {
        scoreText.text = "Score: " + pipesCounter.Score;

        if(BestScore < pipesCounter.Score)
        {
            BestScore = pipesCounter.Score;
        }
    }

}



