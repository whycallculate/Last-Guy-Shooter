using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float playerSpeed = 10f;
    Vector3 playerVector;
    Rigidbody playerRb;

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody>();  
    }


    public void playerMove()
    {
        playerVector = playerRb.velocity;
    }

}
