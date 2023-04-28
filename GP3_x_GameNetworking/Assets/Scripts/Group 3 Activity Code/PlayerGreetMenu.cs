using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGreetMenu : MonoBehaviour
{
    private PlayerStatsManager _playerstatManager;
    public Text greetingText;
    void Start()
    {
        greetingText.text = "Hello, " + AuthenticationManager2.PlayerName.ToString();
        _playerstatManager.RetrievePlayerStatsOnNewRun();

        Debug.Log("Distance Traveled: " + _playerstatManager._DistanceTraveleved);
        Debug.Log("Obstacles Dodged: " + _playerstatManager._ObstaclesDodged);
        Debug.Log("Coins Collected: " + _playerstatManager._coinsCollected);
    }
}
