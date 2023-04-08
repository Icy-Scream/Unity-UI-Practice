using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TMP_Text _hpNumberText;
    private float _health = 100;
    // Start is called before the first frame update
    void Start()
    {
        _slider.value = _health;
        _hpNumberText.text = _health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            if (_health > 0)
            {
                _health -= 20f;
                _slider.value = _health;
                _hpNumberText.text = _health.ToString();
            }
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (_health <= 99)
            {
                _health += 20f;
                _slider.value = _health;
                _hpNumberText.text = _health.ToString();
            }
        }
    }
}