using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesCounter : MonoBehaviour
{
    [SerializeField]
    private GameObject pipesPrefab;

    private static int score;
    public int Score
    {
        get { return score; }
    }

    private void Start()
    {
        score = 0;
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if(trigger.gameObject.name == "PipesPrefab")
        {
            score++;
        }
    }

}
