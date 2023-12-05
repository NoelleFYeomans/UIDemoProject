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
    public float fadeTimeTwo = 2;

    public CanvasGroup pauseGroup;
    public RectTransform pauseTransform;

    public CanvasGroup titleGroup;
    public RectTransform titleTransform;

    public CanvasGroup gameGroup;
    public RectTransform gameTransform;

    public CanvasGroup creditsGroup;
    public RectTransform creditsTransform;



    public void PauseFadeIn()
    {
        pauseGroup.alpha = 0f;
        pauseTransform.transform.localPosition = new Vector3(0f, -1000f, 0f);
        pauseTransform.DOAnchorPos(new Vector2(0f, 0f), fadeTime, false).SetEase(Ease.OutElastic);
        pauseGroup.DOFade(1, fadeTime);
    }
    public void PauseFadeOut()
    {
        pauseGroup.alpha = 1f;
        pauseTransform.transform.localPosition = new Vector3(0f, 0f, 0f);
        pauseTransform.DOAnchorPos(new Vector2(0f, -1000f), fadeTime, false).SetEase(Ease.InOutQuint);
        pauseGroup.DOFade(0, fadeTime).onComplete = GameplayActive;
    }
    public void TitleFadeIn()
    {
        titleGroup.alpha = 0f;
        titleTransform.transform.localPosition = new Vector3(0f, -1000f, 0f);
        titleTransform.DOAnchorPos(new Vector2(0f, 0f), fadeTime, false).SetEase(Ease.OutElastic);
        titleGroup.DOFade(1, fadeTimeTwo);
    }
    public void TitleFadeOut()
    {
        titleGroup.alpha = 1f;
        titleTransform.transform.localPosition = new Vector3(0f, 0f, 0f);
        titleTransform.DOAnchorPos(new Vector2(0f, -1000f), fadeTime, false).SetEase(Ease.InOutQuint);
        titleGroup.DOFade(0, fadeTime).onComplete = GameplayActive;
    }
    public void GameFadeIn()
    {
        gameGroup.alpha = 0f;
        gameTransform.transform.localPosition = new Vector3(0f, -1000f, 0f);
        gameTransform.DOAnchorPos(new Vector2(0f, 0f), fadeTime, false).SetEase(Ease.OutElastic);
        gameGroup.DOFade(1, fadeTime);
    }
    public void GameFadeOut()
    {
        gameGroup.alpha = 1f;
        gameTransform.transform.localPosition = new Vector3(0f, 0f, 0f);
        gameTransform.DOAnchorPos(new Vector2(0f, -1000f), fadeTime, false).SetEase(Ease.InOutQuint);
        gameGroup.DOFade(0, fadeTime).onComplete = PauseActive;
    }

    public void CreditsTransitionIn()
    {
        creditsTransform.transform.DOMove(new Vector3(10, 0, 0), fadeTimeTwo).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);

        creditsGroup.alpha = 0f;
        //creditsTransform.transform.localScale = Vector3.zero;
        creditsTransform.transform.localPosition = new Vector3(0f, -1000f, 0f);
        creditsTransform.DOAnchorPos(new Vector2(0f, 0f), fadeTime, false).SetEase(Ease.OutElastic); //do the tween here
        //creditsTransform.DOScale(1f, fadeTime).SetEase(Ease.OutBounce);
        creditsGroup.DOFade(1, fadeTime);
        creditsTransform.transform.DORotate(new Vector3(359, 359, 359), 2, RotateMode.Fast);
        //StartCoroutine("Animation");
    }

    //IEnumerator Animation()
    //{
    //    creditsTransform.transform.DORotate(new Vector3(359, 359, 359), 2, RotateMode.Fast);
    //}

    public void CreditsTransitionOut()
    {

    }

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
        PauseFadeIn();

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
