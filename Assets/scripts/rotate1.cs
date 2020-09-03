using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate1 : MonoBehaviour
{
    int tmp;
    public Transform tr;
    public float speed2;
    public float l;
    // Update is called once per frame
    private void Start()
    {
        int x = Random.Range(-1, 2);
        Debug.Log(x);
        speed2 = Random.Range(50, 100);
        speed2 = speed2 * x;
        l = Random.Range(0, 360);
       
        tr.rotation = Quaternion.Euler(0, 0,Random.Range(0,360));
    }
    void FixedUpdate()
    {
            tr.rotation = Quaternion.Euler(0, 0, (l = l - speed2) * Time.deltaTime);

    }
}
