using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinPadButton : MonoBehaviour
{
    [SerializeField] private string _buttonValue;
    [SerializeField] private PinNumber _pinNumber;

    public void ReturnNumber()
    {
        _pinNumber.GetButtonValue(_buttonValue);
    }
}
