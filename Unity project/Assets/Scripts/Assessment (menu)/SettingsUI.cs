using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

// A UI to display the member variables of a Settings object (may be a MonoBehaviour or a ScriptableObject) to the player as sliders

public class SettingsUI : MonoBehaviour
{
    // +++++++++ IMPLEMENTATION WITH FloatEditor OBJECTS +++++++++
    public FloatEditor musicVolume;
    public FloatEditor fxVolume;

    // ********* IMPLEMENTATION WITH SLIDER OBJECTS ********* 
    //public Slider musicVolumeSlider;
    //public Slider soundFxVolumeSlider;



    // A settings object from which to obtain back-end music and FX values
    public Settings settings;


    private void Start()
    {
        if (musicVolume)
        {
            musicVolume.floatValue = settings.musicVolume;
            musicVolume.onValueChanged.AddListener((float value) =>
            {
                settings.musicVolume = value;
            });
        }

        if (fxVolume)
        {
            fxVolume.floatValue = settings.soundFxVolume;
            fxVolume.onValueChanged.AddListener((float value) =>
            {
                settings.soundFxVolume = value;
            });
        }

        // ********* IMPLEMENTATION WITH SLIDER OBJECTS ********* 
        // Add an event listener that listens for the OnMusicVolumeChanged function
        //musicVolumeSlider.onValueChanged.AddListener(OnMusicVolumeChanged);
        //soundFxVolumeSlider.onValueChanged.AddListener(OnFxVolumeChanged);

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
