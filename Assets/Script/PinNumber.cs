using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PinNumber : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputField;
    private string _password = "1211";
    private string _pinNumber = "";



    public void GetButtonValue(string number)
    {
        _pinNumber += number;
        _inputField.text = _pinNumber;
        Debug.Log(_pinNumber);
    }

    public void Clear()
    {
        _inputField.text = string.Empty;
        _pinNumber = string.Empty;
    }

    public void Enter()
    {
        if(_pinNumber.Equals(_password))
        {
            _pinNumber = string.Empty;
            _inputField.text = "";
            Debug.Log("CORRECT PASSWORD");
        }
        else
        {
             _pinNumber = string.Empty;
            _inputField.text = "";
            Debug.Log("WRONG PIN");
        }
    }
}
