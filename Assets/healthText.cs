using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class healthText : MonoBehaviour
{
    string replaceText;

    public GameObject player;
    private FirstPersonController_Sam fps;

    // Start is called before the first frame update
    void Start()
    {
        replaceText = "";
        fps = player.GetComponent<FirstPersonController_Sam>();
    }

    // Update is called once per frame
    void Update()
    {
        replaceText = "";
        replaceText = "Health: ";
        replaceText += fps.health.ToString();

        gameObject.GetComponent<TextMeshProUGUI>().text = replaceText;
    }
}
