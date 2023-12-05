using DG.Tweening;
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

    public float fadeTime = 1;
    public CanvasGroup pauseGroup;
    public RectTransform pauseTransform;

    //public void FadeIn()
    //{
    //    pauseGroup.alpha = 0f;
    //    pauseTransform.transform.localPosition = new Vector3(0f, -1000f, 0f);
    //    pauseTransform.DOAnchorPos(new Vector2(0f, 0f), fadeTime, false).SetEase(Ease.OutElastic);
    //    pauseGroup.DOFade(1, fadeTime);
    //}

    public void PauseFadeOut()
    {
        pauseGroup.alpha = 1f;
        pauseTransform.transform.localPosition = new Vector3(0f, 0f, 0f);
        pauseTransform.DOAnchorPos(new Vector2(0f, -1000f), fadeTime, false).SetEase(Ease.InOutQuint);
        pauseGroup.DOFade(0, fadeTime);
    }

    //public void FadeIn()
    //{
    //    pauseGroup.alpha = 0f;
    //    pauseTransform.transform.localPosition = new Vector3(0f, -1000f, 0f);
    //    pauseTransform.DOAnchorPos(new Vector2(0f, 0f), fadeTime, false).SetEase(Ease.OutElastic);
    //    pauseGroup.DOFade(1, fadeTime);
    //}

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
        //called every frame
        //FadeIn();
        //pauseGroup.alpha = 0f; //works
        //pauseGroup.DOFade(1, fadeTime); //does not work
        //pauseGroup.DOKill(); //works

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
