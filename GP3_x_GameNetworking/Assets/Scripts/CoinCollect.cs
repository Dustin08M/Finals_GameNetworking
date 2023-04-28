using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public float turnSpeed = 90f;
    bool CoinGrabbed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        //another if statement to check if the coin will collide with an obstacle
        if (other.gameObject.GetComponent<Obstacles>() != null)
        {
            Destroy(gameObject);
            return;
        }
        if (other.gameObject.name != "Player") //check that the object collided is the player
        {
            if (other.CompareTag("Player") && CoinGrabbed)
            {
                PlayerTracker.instance.CountCoinsCollected();
                CoinGrabbed = true;
            }
         return;
        }
        //Add to player's coin 
        GameManager.inst.IncrementCoins();
        PlayerTracker.instance.CountCoinsCollected();

        Destroy(gameObject);//destroy coin
    }
}
