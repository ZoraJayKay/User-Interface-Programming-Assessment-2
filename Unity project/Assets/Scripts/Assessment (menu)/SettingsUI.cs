using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// A UI to display the member variables of a Settings object (may be a MonoBehaviour or a ScriptableObject) to the player as sliders

public class SettingsUI : MonoBehaviour
{
    public Slider musicVolumeSlider;
    public Slider soundFxVolumeSlider;

    // A settings object from which to obtain back-end music and FX values
    public Settings settings;

    // Assign the sliders values from the back-end Settings object


    // When the sliders move, write to the back-end variables

    public void Start()
    {
        // Add an event listener that listens for the OnMusicVolumeChanged function
        musicVolumeSlider.onValueChanged.AddListener(OnMusicVolumeChanged);
        musicVolumeSlider.onValueChanged.AddListener(OnFxVolumeChanged);

        //// Alternatively, add a C# lambda function for the same effect
        //musicVolumeSlider.onValueChanged.AddListener(
        //    (float value) => { settings.musicVolume = value; });
    }

    // Any time the music volume gets changed, pass the change back to the Settings object
    public void OnMusicVolumeChanged(float volume)
    {
        // Make the float value of the Settings object equal to any passed in value
        settings.musicVolume = volume;
    }

    // Any time the fx volume gets changed, pass the change back to the Settings object
    public void OnFxVolumeChanged(float volume)
    {
        // Make the float value of the Settings object equal to any passed in value
        settings.soundFxVolume = volume;
    }
}
