using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private BirdMovement bird;
    private bool IsGameOver = false;

    [SerializeField] private AudioSource gameOverSound;
    [SerializeField] private AudioSource backgroundSound;
    [SerializeField] private UIController interfaceController;


    void Start()
    {
        bird = GetComponent<BirdMovement>();
        backgroundSound.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        TimeController.PauseGame();
        IsGameOver = true;
    }

    IEnumerator sceneLoader()
    {
        gameOverSound.Play();

        yield return new WaitForSecondsRealtime(2);
        TimeController.RestartGame();
        interfaceController.ShowMenu(true);
    }

    void Update()
    {
        if(Time.timeScale > 0f)
        {
            bird.Jump();
        }

        if (!IsGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Escape)
            || Input.GetKeyDown(KeyCode.P))
            {
                TimeController.PauseGame();
                interfaceController.HideMenu();
            }
        }
        else
        {
            IsGameOver = false;

            //TimeController.RestartGame();
            //interfaceController.ShowMenu(true);
            StartCoroutine(sceneLoader());
        }
        

        if (Input.GetKeyDown(KeyCode.R))
        {
            TimeController.RestartGame();
            interfaceController.ShowMenu(true);
        }
    }
}
