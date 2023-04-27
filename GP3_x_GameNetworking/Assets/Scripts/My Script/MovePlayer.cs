using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private CharacterController controller;
    public float moveSpeed = 10;

    private float timer = 0f; //checker

    float PosX;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update() //A-D controller
    {

        timer += Time.deltaTime;

        if (timer >= 30f) //for every 30 seconds, it adds an extra speed
        {
            moveSpeed += 0.5f;
            Debug.Log("Speed Increased");
            timer = 0.0f; //resets the timer, therefore checking it again
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, moveSpeed);
        controller.Move(move * Time.deltaTime * moveSpeed);
    }
}


//Script is provided by Raid Shadow Legends ® 2023
