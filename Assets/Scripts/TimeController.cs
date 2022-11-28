using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public static class TimeController
    {
        public static void PauseGame()
        {
            if (Time.timeScale > 0f)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1;
            }
        }

        public static void RestartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 0f;
        }
    }
}
