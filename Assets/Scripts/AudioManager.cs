using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] Slider bgmSlider;
    [SerializeField] Slider sfxSlider;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume") || !PlayerPrefs.HasKey("sfxVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            PlayerPrefs.SetFloat("sfxVolume", 1);
            Load();
        }

        else
        {
            Load();
        }
    }

    private void Update()
    {
        GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<AudioSource>().volume = bgmSlider.value;
        GameObject.FindGameObjectWithTag("SFXSource").gameObject.GetComponent<AudioSource>().volume = sfxSlider.value;
    }

    public void ChangeBGMVolume()
    {
        GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<AudioSource>().volume = bgmSlider.value;
        Save();
    }

    public void ChangeSFXVolume()
    {
        GameObject.FindGameObjectWithTag("SFXSource").gameObject.GetComponent<AudioSource>().volume = sfxSlider.value;
        Save();
    }

    private void Load()
    {
        bgmSlider.value = PlayerPrefs.GetFloat("musicVolume");
        sfxSlider.value = PlayerPrefs.GetFloat("sfxVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", bgmSlider.value);
        PlayerPrefs.SetFloat("sfxVolume", sfxSlider.value);
    }
}
