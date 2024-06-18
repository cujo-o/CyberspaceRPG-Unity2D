using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;

public class suikaplayFabScript : MonoBehaviour
{

  
    // Start is called before the first frame update
    void Start()
    {
      //  Login();
    }

    // Update is called once per frame
    void Login()
    {
        var request = new LoginWithCustomIDRequest { CustomId = SystemInfo.deviceUniqueIdentifier, CreateAccount = true };
        PlayFabClientAPI.LoginWithCustomID(request, Onsuccess, Onfail);
    }

    void Onsuccess(LoginResult result)
    {
        Debug.Log("successful login/account created");
    }

    void Onfail(PlayFabError error)
    {
        Debug.Log("error while logging in");
        Debug.Log(error.GenerateErrorReport());
    }

    public  void SendLeaderboard (int score)
    {
        var request = new UpdatePlayerStatisticsRequest
        {
            Statistics = new List<StatisticUpdate>
            {
                new StatisticUpdate
                {
                    StatisticName="SuikaGameLeaderboard",
                    Value =score

                }
            }
        };
        PlayFabClientAPI.UpdatePlayerStatistics(request, OnleaderboardUpdate, Onfail);
    }

    void OnleaderboardUpdate(UpdatePlayerStatisticsResult result)
    {
        Debug.Log("successful leaderboard sent");
    }
}
