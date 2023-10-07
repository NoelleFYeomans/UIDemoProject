using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject LevelManager;
    public GameObject UIManager;

    private LevelManager _levelManager;
    private UI_Manager _UIManager;

    public enum GameState
    {
        TitleScreen,
        Gameplay,
        Pause,
        GameOver,
        Win,
        Credits
    }

    private GameState gameState;
    //private GameState lastGameState; //no use yet, might be useful later


    // Start is called before the first frame update
    void Start()
    {
       _UIManager = UIManager.GetComponent<UI_Manager>();
       _levelManager = LevelManager.GetComponent<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState) //this is the gameManager itself essentially.
        {
            case GameState.TitleScreen:
                Time.timeScale = 1f;

                _UIManager.TitleScreenActive();
                break;
            case GameState.Gameplay:
                Time.timeScale = 1f;

                _UIManager.GameplayActive();

                if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
                {
                    gameState = GameState.Pause;
                }

                if (Input.GetKeyDown(KeyCode.F1))
                {
                    gameState = GameState.Win;
                }

                if (Input.GetKeyDown(KeyCode.F2))
                {
                    gameState = GameState.GameOver;
                }
                break;
            case GameState.Pause:
                Time.timeScale = 0f;

                _UIManager.PauseActive();

                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Unpause();
                }
                break;
            case GameState.GameOver:
                Time.timeScale = 0f;

                _UIManager.GameOverActive();
                break;
            case GameState.Win:
                Time.timeScale = 0f;

                _UIManager.WinActive();
                break;
            case GameState.Credits:
                Time.timeScale = 0f;

                _UIManager.CreditsActive();
                break;
        }
    }

    public void Unpause()
    {
        Time.timeScale = 1f;
        gameState = GameState.Gameplay;
        _UIManager.GameplayActive();
    }

    public void LoadGameplay() 
    {
        _levelManager.loadGameplay();
        gameState = GameState.Gameplay;
    }

    public void LoadTitleScreen()
    {
        _levelManager.loadTitleScreen();
        gameState = GameState.TitleScreen;
    }

    public void CreditsButton()
    {
        gameState = GameState.Credits;
    }

    public void TitleButton()
    {
        gameState = GameState.TitleScreen;
    }

    public void QuitGame()
    {
        _levelManager.quitGame();
    }
}