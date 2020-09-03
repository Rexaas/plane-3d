using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public Transform tr;
    public float speed1 = 5;
    public float k = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
            tr.rotation = Quaternion.Euler(0, 0, (k = k + speed1) * Time.deltaTime);
        
        
    }
}
