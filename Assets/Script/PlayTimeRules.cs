using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayTimeRules : MonoBehaviour
{
    [SerializeField] private Toggle[] toggles;
    [SerializeField] private Image _currentImage;
    [SerializeField] private Sprite[] _playerTimeImage;
    [SerializeField] private TMP_Text _playerTimeText;

    private void Start()
    {
        _playerTimeText.text = "Do Not Touch The Dinos";
        _currentImage.overrideSprite = _playerTimeImage[0];
    }

    public void Picture1()
    {
        if (toggles[0].isOn == true)  {
            _playerTimeText.text = "Do Not Touch The Dinos";
            _currentImage.overrideSprite = _playerTimeImage[0];
        }
    }

    public void Picture2()
    {
        if (toggles[1].isOn == true)
        {
            _playerTimeText.text = "Dino's Enjoy Playing Hide n Seek";
            _currentImage.overrideSprite = _playerTimeImage[1];
        }
    }

    public void Picture3()
    {
        if (toggles[2].isOn == true)
        {
            _playerTimeText.text = "Have Fun!";
            _currentImage.overrideSprite = _playerTimeImage[2];
        }
    }
}
