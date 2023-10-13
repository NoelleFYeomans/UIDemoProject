using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript : MonoBehaviour
{
    private FirstPersonController_Sam fps_Sam;

    private float time;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("got in");

        if (other.gameObject.activeSelf)
        {
            
            if (time >= 1)
            {
                time = 0;
                count++;
            }

            if (count >= 2) 
            {
                fps_Sam = GameObject.Find("Sam_FPS").GetComponent<FirstPersonController_Sam>();
                fps_Sam.takeDamage();
                time = 0;
                count = 0;
                Debug.Log("lmfao");
            }
        }
    }
}
