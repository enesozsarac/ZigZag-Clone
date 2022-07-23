using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPositionController : MonoBehaviour
{
    private GroundSpawnController groundSpawnController;
    private Rigidbody rb;

    [SerializeField] private float endYValue;
    private int groundDirection;
    void Start()
    {
        groundSpawnController =  FindObjectOfType<GroundSpawnController>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        CheckGroundVerticalPos();
    }

    private void CheckGroundVerticalPos()
    {
        if (transform.position.y <= endYValue)
        {
            SetRbValue();
            SetGroundNewPos();
        }    
    }


    private void SetGroundNewPos()
    {
        groundDirection = Random.Range(0,2);
            

        if (groundDirection == 0)
        {
            transform.position = new Vector3(groundSpawnController.lastGrObj.transform.position.x - 1f, groundSpawnController.lastGrObj.transform.position.y, groundSpawnController.lastGrObj.transform.position.z);
        }
        else
        {
            transform.position = new Vector3(groundSpawnController.lastGrObj.transform.position.x, groundSpawnController.lastGrObj.transform.position.y, groundSpawnController.lastGrObj.transform.position.z + 1f);
        }

        groundSpawnController.lastGrObj = gameObject;
    }


    private void SetRbValue()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }




}
