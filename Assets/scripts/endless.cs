using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endless : MonoBehaviour
{
    public GameObject[] obj;
    public Transform playertr;
    private float spawnz = 0.0f;
    private float dist = 500.0f;
    private int amountObjOnscreen = 5;

    void Awake()
    {
        for(int i=0; i < amountObjOnscreen; i++)
        {
            Spawn();
        }

    }
    void Update()
    {

            if(playertr != null && playertr.position.z>(spawnz - amountObjOnscreen * dist))
        {
            Spawn();
        }
        
    }
    private void Spawn(int PrefabInd = -1)
    {
        GameObject go;
        go = Instantiate(obj[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnz;
        spawnz += dist;
    }
}

