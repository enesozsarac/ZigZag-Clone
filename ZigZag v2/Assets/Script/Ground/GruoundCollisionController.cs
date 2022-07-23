using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GruoundCollisionController : MonoBehaviour
{

    [SerializeField] private GroundDataTransmitter groundDataTransmitter;

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            groundDataTransmitter.SetRigidbodyValues();
        }
    }


}
