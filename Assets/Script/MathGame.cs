using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MathGame : MonoBehaviour
{
    [SerializeField] private TMP_Text _number1Text,_number2Text;
    [SerializeField] private TMP_InputField _answerInputField;
    private int _number1;
    private int _number2;
    private int _sum;
    private bool _correct=false;


    private void Start()
    {
        _number1 = Random.Range(0, 50);
        _number2 = Random.Range(0, 50);
        _number1Text.text = _number1.ToString();
        _number2Text.text = _number2.ToString();
        _sum = _number1 + _number2;
    }

    private void Update()
    {
        if (_correct)
        {
            _correct = false;
            _number1 = Random.Range(0, 50);
            _number2 = Random.Range(0, 50);
            _number1Text.text = _number1.ToString();
            _number2Text.text = _number2.ToString();
            _sum = _number1 + _number2;
        }
    }

    public void GetUserAnswer()
    {
        int.TryParse(_answerInputField.text, out int answer);
       
        if (answer == _sum)
        {
            _correct = true;
            Debug.Log("You are Correct");
        }
        else
        {
            _answerInputField.text = "";
            Debug.Log("You are Wrong");
        }

    }
}
