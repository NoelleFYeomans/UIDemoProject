using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public Canvas TitleScreenUI;
    public Canvas GameplayUI;
    public Canvas PauseUI;
    public Canvas GameOverUI;
    public Canvas WinUI;
    public Canvas CreditsUI;

    public void TitleScreenActive()
    {
        TitleScreenUI.gameObject.SetActive(true);
        GameplayUI.gameObject.SetActive(false);
        PauseUI.gameObject.SetActive(false);
        GameOverUI.gameObject.SetActive(false);
        WinUI.gameObject.SetActive(false);
        CreditsUI.gameObject.SetActive(false);

        Cursor.visible = true;
    }

    public void GameplayActive()
    {
        TitleScreenUI.gameObject.SetActive(false);
        GameplayUI.gameObject.SetActive(true);
        PauseUI.gameObject.SetActive(false);
        GameOverUI.gameObject.SetActive(false);
        WinUI.gameObject.SetActive(false);
        CreditsUI.gameObject.SetActive(false);

        AudioListener.volume = 1;

        Cursor.visible = false;
    }

    public void PauseActive()
    {
        TitleScreenUI.gameObject.SetActive(false);
        GameplayUI.gameObject.SetActive(false);
        PauseUI.gameObject.SetActive(true);
        GameOverUI.gameObject.SetActive(false);
        WinUI.gameObject.SetActive(false);
        CreditsUI.gameObject.SetActive(false);

        AudioListener.volume = 0;

        Cursor.visible = true;
    }

    public void GameOverActive()
    {
        TitleScreenUI.gameObject.SetActive(false);
        GameplayUI.gameObject.SetActive(false);
        PauseUI.gameObject.SetActive(false);
        GameOverUI.gameObject.SetActive(true);
        WinUI.gameObject.SetActive(false);
        CreditsUI.gameObject.SetActive(false);

        Cursor.visible = true;
    }

    public void WinActive()
    {
        TitleScreenUI.gameObject.SetActive(false);
        GameplayUI.gameObject.SetActive(false);
        PauseUI.gameObject.SetActive(false);
        GameOverUI.gameObject.SetActive(false);
        WinUI.gameObject.SetActive(true);
        CreditsUI.gameObject.SetActive(false);

        Cursor.visible = true;
    }

    public void CreditsActive()
    {
        TitleScreenUI.gameObject.SetActive(false);
        GameplayUI.gameObject.SetActive(false);
        PauseUI.gameObject.SetActive(false);
        GameOverUI.gameObject.SetActive(false);
        WinUI.gameObject.SetActive(false);
        CreditsUI.gameObject.SetActive(true);
        //Debug.Log("logma bugs");
        Cursor.visible = true;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
