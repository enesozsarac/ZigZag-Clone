using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{
    [SerializeField] private BallDataTransmitter ballDataTransmitter;


    [SerializeField] private float ballMoveSpeed;

    private void Update()
    {
        SetBallDiretion();
    }

    private void SetBallDiretion()
    {
        transform.position += ballDataTransmitter.GetBallDiretion() *  ballMoveSpeed * Time.deltaTime;
    }
}
