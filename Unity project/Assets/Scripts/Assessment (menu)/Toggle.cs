using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour
{
    float settingsMusicVolume;
    float settingsFXVolume;
    float currentMusicVolume;
    float currentFxVolume;
    SettingsUI settingsUIRef;

    private void Start()
    {
        // Cache memory references to the volumes stored within the Settings object within this object's SettingsUI script
        settingsMusicVolume = GetComponent<SettingsUI>().settings.musicVolume;
        settingsFXVolume = GetComponent<SettingsUI>().settings.soundFxVolume;

        currentMusicVolume = GetComponent<SettingsUI>().musicVolumeSlider.value;
        currentFxVolume = GetComponent<SettingsUI>().soundFxVolumeSlider.value;

        settingsUIRef = GetComponent<SettingsUI>();
    }

    public void ToggleActive()
    {
        // Write the volume settings of the Settings object into the .value members of our Slider objects
        // Get the music volume float from the Settings palette
        currentMusicVolume = settingsMusicVolume;
        settingsUIRef.OnMusicVolumeChanged(currentMusicVolume);
        Debug.Log("Current music volume: " + currentMusicVolume);

        // Get the FX volume float from the Settings palette
        currentFxVolume = settingsFXVolume;
        settingsUIRef.OnFxVolumeChanged(currentFxVolume);
        Debug.Log("Current FX volume: " + currentFxVolume);

        // These are Unity keywords, functions and keyword member variables
        gameObject.SetActive(!gameObject.activeSelf);
        // gameObject is like a 'this' call
        // activeSelf is a parameter of (presumably) every gameObject
        // SetActive is obvious
    }
}
