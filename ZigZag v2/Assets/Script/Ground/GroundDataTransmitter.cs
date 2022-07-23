using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDataTransmitter : MonoBehaviour
{
    [SerializeField] private GroundFallController groundFallController;


    public void SetRigidbodyValues()
    {
        StartCoroutine(groundFallController.SetRigidbodyValues());
    }
}
