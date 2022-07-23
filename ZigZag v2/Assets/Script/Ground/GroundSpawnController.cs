using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnController : MonoBehaviour
{
    public GameObject lastGrObj;
    [SerializeField] private GameObject groundPrefabs;
    private GameObject newObj;

    private int groundDirection;

    private void Start()
    {
        GenerateRandomNewGorunds();
    }

    public void GenerateRandomNewGorunds()
    {
        for (int i = 0; i < 75; i++)
        {
            CreateNewGround();
        }
    }


    private void CreateNewGround()
    {
        groundDirection = Random.Range(0,2);


        if (groundDirection == 0)
        {
            newObj = Instantiate(groundPrefabs, new Vector3(lastGrObj.transform.position.x - 1f, lastGrObj.transform.position.y, lastGrObj.transform.position.z), Quaternion.identity);
            lastGrObj = newObj;
        }
        else
        {
            newObj = Instantiate(groundPrefabs, new Vector3(lastGrObj.transform.position.x, lastGrObj.transform.position.y, lastGrObj.transform.position.z + 1f), Quaternion.identity);
            lastGrObj = newObj;
        }


    }






}
