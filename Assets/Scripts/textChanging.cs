using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class textChanging : MonoBehaviour
{
    float timeElapsed;
    int seconds;
    int minutes;

    string replaceText;

    // Start is called before the first frame update
    void Start()
    {
        timeElapsed = 0;
        seconds = 0;
        replaceText = "";
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        
        if (timeElapsed > 1)
        {
            seconds++;
            timeElapsed = 0;
        }

        if (seconds == 60)
        {
            seconds = 0;
            minutes++;
        }
        replaceText = "";
        replaceText = minutes.ToString();
        replaceText += ":";
        if (seconds.ToString().Length < 2) 
        {
            replaceText += 0;
        }
        replaceText += seconds.ToString();

        gameObject.GetComponent<TextMeshProUGUI>().text = replaceText;
    }
}
