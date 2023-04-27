using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracker : MonoBehaviour
{
    public static PlayerTracker instance;

    private void Awake()
    {
        instance = this;
    }


    [SerializeField] private int CoinsGrabbed;
    public void CountCoinsCollected()
    {
        CoinsGrabbed++;
        Debug.Log($"Coins Collected: {CoinsGrabbed}");
    }
}
