using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private Slider _brightnessSlider;
    [SerializeField] private Slider _volumeSlider;
    [SerializeField] private Light _brightnessLight;
    [SerializeField] private AudioMixer _volumeMixer;
    private bool _isPauseMenuActive = false;
    void Start()
    {
        _pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) {
            PauseMenuSwitch();
        }

        _brightnessLight.intensity = _brightnessSlider.value;
        AdjustVolume();
    }

    public void PauseMenuSwitch() {
        if(!_isPauseMenuActive) {
            _pauseMenu.SetActive(true);
            _isPauseMenuActive=true;
        }
        else if(_isPauseMenuActive){
            _pauseMenu.SetActive(false);
            _isPauseMenuActive=false;
        }
    }

    public void DisableMainMenu() {
        _pauseMenu.SetActive(false);
    }

    public void AdjustVolume() {
        _volumeMixer.SetFloat("BG_Music", _volumeSlider.value);
    }
}
