using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public static HealthManager healthInstance;

    public Image healthBar;
    public float healthAmount = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
        if (healthInstance != null)
        {
            GameObject.Destroy(gameObject); //destroys the HealthManager if it already exists on start
        }
        else
        {
            GameObject.DontDestroyOnLoad(gameObject); //otherwise makes a HealthManager that doesn't destroy between scenes
            healthInstance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (healthAmount <= 0)
        {
            healthAmount = 100f;
            Application.LoadLevel(Application.loadedLevel);
            Heal(1);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            TakeDamage(10);
            healthText.textInstance.setText(healthAmount);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Heal(10);
            healthText.textInstance.setText(healthAmount);
        }
    }

    //private void OnGUI()
    //{
    //    if (GUI.Button(new Rect(10, 10, 150, 100), "Heal 10 Health"))
    //    {
    //        Heal(10);
    //    }

    //    if (GUI.Button(new Rect(210, 10, 150, 100), "Lose 10 Health"))
    //    {
    //        TakeDamage(10);
    //    }
    //}

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        healthBar.fillAmount = healthAmount / 100f;
    }

    public void Heal(float healAmount)
    {
        healthAmount += healAmount;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        healthBar.fillAmount = healthAmount / 100f;
    }
}
