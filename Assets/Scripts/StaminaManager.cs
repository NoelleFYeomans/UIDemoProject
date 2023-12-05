using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaManager : MonoBehaviour
{
    public static StaminaManager stamInstance;

    public Image stamBar;
    public float stamAmount = 100f;

    public bool running = false;

    // Start is called before the first frame update
    void Start()
    {
        if (stamInstance != null)
        {
            GameObject.Destroy(gameObject); //destroys the HealthManager if it already exists on start
        }
        else
        {
            GameObject.DontDestroyOnLoad(gameObject); //otherwise makes a HealthManager that doesn't destroy between scenes
            stamInstance = this;
        }
    }

    private void FixedUpdate()
    {

        if (!running && stamAmount < 100f)
        {
            stamAmount += 1f;
            stamBar.fillAmount = stamAmount / 100f;
        }
        else if (running && stamAmount >= 1f)
        {
            stamAmount -= 0.5f;
            stamBar.fillAmount = stamAmount / 100f;
        }
    }
}
