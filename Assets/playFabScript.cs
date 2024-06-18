using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
using TMPro;

public class playFabScript : MonoBehaviour
{
    public TextMeshProUGUI messageText;
    public TMP_InputField emailinput;
    public TMP_InputField  passwordinput;
    public TMP_InputField usernameinput;

    public GameObject loginScreen;
    public GameObject usernameScreen;
    // Start is called before the first frame update
    void Start()
    {
       // Login();
    }

    // Update is called once per frame
    void Login()
    {
        var request = new LoginWithCustomIDRequest { CustomId = SystemInfo.deviceUniqueIdentifier, CreateAccount = true };
        PlayFabClientAPI.LoginWithCustomID(request, Onloginsuccess, Onfail);
    }

    void Onloginsuccess(LoginResult result)
    {
        messageText.text = ("logged in");
        Debug.Log("successful login/account created");
        //loginScreen.SetActive(false);
    }

    void Onfail(PlayFabError error)
    {
        Debug.Log("error while logging in");
        Debug.Log(error.GenerateErrorReport());
    }

    public void LoginButton()
    {
        var request = new LoginWithEmailAddressRequest
        {
            Email = emailinput.text,
            Password = passwordinput.text
        };
        PlayFabClientAPI.LoginWithEmailAddress(request, Onloginsuccess, Onerror);
     // loginScreen.SetActive(false);
    }
    public void RegisterButton()
    {
        if (passwordinput.text.Length<6)
        {
            messageText.text = ("password too short");
            return;
        }
        var request = new RegisterPlayFabUserRequest
        {
            Email = emailinput.text,
            Password = passwordinput.text,
            RequireBothUsernameAndEmail = false,
              
        };  
        PlayFabClientAPI.RegisterPlayFabUser( request, OnRegisterSuccess, Onerror);
    }

    public void UsernameButton()
    {
      
        var request = new UpdateUserTitleDisplayNameRequest
        {
          
            DisplayName = usernameinput.text

        };
        PlayFabClientAPI.UpdateUserTitleDisplayName(request, OnUseranmeSuccess, Onerror);
    }

    void OnUseranmeSuccess(UpdateUserTitleDisplayNameResult result)
    {
        Debug.Log("username set");
    }
    void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        messageText.text = ("registered and logged in");
       
    }
     public void cancelbuttonLogin()
    {
        loginScreen.SetActive(false);
    }

    public void cancelbuttonUsername()
    {
        usernameScreen.SetActive(false);
    }
    void Onerror(PlayFabError error)
    {
        messageText.text = error.ErrorMessage;
        Debug.Log(error.GenerateErrorReport());
    }
}
