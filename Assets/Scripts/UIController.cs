using Assets.Scripts;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class UIController : MonoBehaviour
{
    [SerializeField] private Button MenuBtn;
    [SerializeField] private Button PauseBtn;
    [SerializeField] private Button RepeatBtn;
    private GameObject menuBtnObj;
    private GameObject pauseBtnObj;
    private GameObject repeatBtnObj;

    [SerializeField] private GameObject menuObj;

    private bool isMenuOpened = false;
    public bool IsMenuOpened { get { return isMenuOpened; } }

    void Start()
    {
        menuBtnObj = MenuBtn.gameObject;
        pauseBtnObj = PauseBtn.gameObject;
        repeatBtnObj = RepeatBtn.gameObject;


        MenuBtn.onClick.AddListener(() =>
        {
            HideMenu();
            ShowMenu(false);
        });

        PauseBtn.onClick.AddListener(() =>
        {
            HideMenu();
            TimeController.PauseGame();
        });

        RepeatBtn.onClick.AddListener(() => 
        {
            TimeController.RestartGame();
            ShowMenu(true);
        });
    }

    public void HideMenu()
    {
        if (isMenuOpened)
        {
            menuBtnObj.SetActive(true);
            menuObj.SetActive(false);
            isMenuOpened = false;
        }
    }

    public void ShowMenu(bool hasMenuToBeOpen)
    {
        if(Time.timeScale > 0f)
        {
            TimeController.PauseGame();
        }

        if (!isMenuOpened || hasMenuToBeOpen)
        {
            menuBtnObj.SetActive(false);
            menuObj.SetActive(true);
            isMenuOpened = true;
        }
    }
}
