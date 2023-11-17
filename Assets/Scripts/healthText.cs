using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class healthText : MonoBehaviour
{
    public static healthText textInstance;

    string replaceText;

    public GameObject player;
    private FirstPersonController_Sam fps;

    // Start is called before the first frame update
    void Start()
    {
        replaceText = "";
        fps = player.GetComponent<FirstPersonController_Sam>();

        if (textInstance != null)
        {
            GameObject.Destroy(gameObject); //destroys the GameManager if it already exists on start
        }
        else
        {
            GameObject.DontDestroyOnLoad(gameObject); //otherwise makes a GameManager that doesn't destroy between scenes
            textInstance = this;
        }

        replaceText = "";
        replaceText = "Health: ";
        replaceText += fps.health.ToString();

        gameObject.GetComponent<TextMeshProUGUI>().text = replaceText;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setText(float healthAmount)
    {
        replaceText = "";
        replaceText = "Health: ";
        replaceText += healthAmount.ToString();

        gameObject.GetComponent<TextMeshProUGUI>().text = replaceText;
    }
}
