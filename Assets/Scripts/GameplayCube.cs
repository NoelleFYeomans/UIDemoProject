using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0) return;
        this.gameObject.transform.Rotate(1f, 2f, 3f);
    }
}
