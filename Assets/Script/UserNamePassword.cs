using TMPro;
using UnityEngine;


public class UserNamePassword : MonoBehaviour
{
    [SerializeField] TMP_InputField _userNameInputField, _passwordInputField;
    [SerializeField] GameObject _loginCanvas;
    [SerializeField] GameObject _accountCreationgCanvas;
    [SerializeField] TMP_Text _debugText;
    private string _userName = null;
    private string _password = null;

    private void Start()
    {
        DebugTextPrompt("");
        _accountCreationgCanvas.SetActive(false);
    }

    public void CreateAccountButton()
    {
        ChangePlaceHolderText("Create Username...", "Create Password...");
        _loginCanvas.SetActive(false);
        _accountCreationgCanvas.SetActive(true);
        DebugTextPrompt("");
        ResetTextInput();
        _userName = null;
        _password = null;
    }

    private void ChangePlaceHolderText(string username, string password)
    {
        var _userNamePlaceHolder = _userNameInputField.placeholder;
        var _passwordPlaceHolder = _passwordInputField.placeholder;
        _userNamePlaceHolder.gameObject.GetComponent<TextMeshProUGUI>().text = username;
        _passwordPlaceHolder.gameObject.GetComponent<TextMeshProUGUI>().text = password;
    }

    private void DebugTextPrompt(string text) {
        _debugText.text = text;
    }

    public void GetUserName()
    {
       _userName = _userNameInputField.text;
    }

    public void GetPassword()
    {
        _password = _passwordInputField.text;
    }

    public void Login()
    {
        string tempUsername = _userNameInputField.text;
        string tempPassword = _passwordInputField.text;

        if (tempPassword.Equals(_password) && tempUsername.Equals(_userName))
        {
            DebugTextPrompt("Successful Login");
        }
        else
        {
            ResetTextInput();
            DebugTextPrompt("WRONG USERNAME OR PASSWORD");
        }
    }

    public void ConfirmAccountCreation()
    {

        if (_userName.Length < 4)
        {
            DebugTextPrompt("Error Username is too short (Greater Than 4 Characters).");
            ResetTextInput();
            _userName = null;
        }

        else if (_userName != null && _password != null)
        {
            DebugTextPrompt("Account Succesfully Created");
            ChangePlaceHolderText("Enter Username...","Enter Password...");
            ResetTextInput();
            Debug.Log($"{_userName},{_password}");
            _loginCanvas.SetActive(true);
            _accountCreationgCanvas.SetActive(false);
        }
    }

    public void CancelButton()
    {
        ChangePlaceHolderText("Enter Username...", "Enter Password...");
        ResetTextInput();
        _loginCanvas.SetActive(true);
        _accountCreationgCanvas.SetActive(false);

    }

    private void ResetTextInput()
    {
        _userNameInputField.text = "";
        _passwordInputField.text = "";
    }
}
