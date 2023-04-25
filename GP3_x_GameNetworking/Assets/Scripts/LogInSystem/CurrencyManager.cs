using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
public class CurrencyManager : MonoBehaviour
{
    public Text _BattleCoin;
    public Text _freezePowerUp;
    public Text _InvincibilityPowerUp;
    public Text _MagnetPowerUp;

    [SerializeField] private int FR_Amount; // Freeze
    [SerializeField] private int IN_Amount; // Invincibility
    [SerializeField] private int MG_Amount; // Magnet
    [SerializeField] private int BT_Amount; // BattleCoin

    public static CurrencyManager instance;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        GetVirtualCurrency();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetVirtualCurrency()
    {
        PlayFabClientAPI.GetUserInventory(new GetUserInventoryRequest(), GetUserCurrencySuccess, OnError);
    }


    public void GetUserCurrencySuccess(GetUserInventoryResult result)
    {
        int _BT = result.VirtualCurrency["BT"];
        _BattleCoin.text = _BT.ToString();

        int _FR = result.VirtualCurrency["FR"];
        _freezePowerUp.text = _FR.ToString();

        int _IN = result.VirtualCurrency["IN"];
        _InvincibilityPowerUp.text = _FR.ToString();

        int _MG = result.VirtualCurrency["MG"];
        _MagnetPowerUp.text = _FR.ToString();
    }

    void OnError(PlayFabError error)
    {
        Debug.Log("Error: " + error.ErrorMessage);
    }

    public void GetPlayerInvincibility()
    {
        IN_Amount++;
    }

    public void GetPlayerFreeze()
    {
        FR_Amount++;
    }

    public void GetPlayerMagnet()
    {
        FR_Amount++;
    }
}
