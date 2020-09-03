using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public Transform playertr;
    private float spawnz = 0.0f;
    private float dist = 500.0f;
    private int amountObjOnscreen = 5;

    void Awake()
    {
        for (int i = 0; i < amountObjOnscreen; i++)
        {
            Spawn();
        }

    }
    void fixedUpdate()
    {

        if (playertr != null && playertr.position.z > (spawnz - amountObjOnscreen * dist))
        {
            Spawn();
        }

    }
    private void Spawn()
    {
        GameObject go;
        rand();
        go = Instantiate(obj) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnz;
        spawnz += dist;
    }
    public void rand()
    {
        int rand = Random.Range(1, 6);
        if (rand == 1)
        {
            obj = obj1;
        }
        if (rand == 2)
        {
            obj = obj2;
        }
        if (rand == 3)
        {
            obj = obj3;
        }
        if (rand == 4)
        {
            obj = obj4;
        }
        if (rand == 5)
        {
            obj = obj5;
        }
        if (rand == 6)
        {
            obj = obj6;
        }

    }
}
