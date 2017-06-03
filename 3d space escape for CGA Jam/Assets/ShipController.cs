using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float baseMoveSpeed = 1;
    public float currentMoveSpeed;
    public float speedIncreaseIncrement = 1f;
    public float maxMoveSpeed = 20f;

    // Use this for initialization
    void Start()
    {
        currentMoveSpeed = baseMoveSpeed;
        InvokeRepeating("IncreaseSpeed", 1, 1);
    }


    void IncreaseSpeed()
    {

        if (currentMoveSpeed <= maxMoveSpeed)
        {
            currentMoveSpeed += speedIncreaseIncrement;
        }

    }
    // Update is called once per frame
    void Update()
    {
        MovePlayerForward();
    }
    void MovePlayerForward()
    {

        transform.position = new Vector3(transform.position.x - (Time.deltaTime * currentMoveSpeed), 2, 2);
    }


}
