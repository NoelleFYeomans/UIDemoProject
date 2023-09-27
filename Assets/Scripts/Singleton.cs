using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    // Script is attached to GameManager object
    // Script sets itself & all children as Singleton
    // When a new scene is loaded, GameManager & all children will not be destroyed
    // Allows you to carry object functionality between scenes


    static Singleton Instance;

    void Start()
    {
        if (Instance != null)
        {
            GameObject.Destroy(gameObject); //destroys the GameManager if it already exists on start
        }
        else
        {
            GameObject.DontDestroyOnLoad(gameObject); //otherwise makes a GameManager that doesn't destroy between scenes
            Instance = this;
        }
    }
}
