using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Transform tr;
    public float speed = 5;
    public float z = 0;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).position.x < player.transform.position.x)
            {
                tr.rotation = Quaternion.Euler(0, 0, (z = z + speed) * Time.deltaTime);
            }
            if (Input.GetTouch(0).position.x > player.transform.position.x)
            {
                tr.rotation = Quaternion.Euler(0, 0, (z = z - speed) * Time.deltaTime);
            }
        }
    }
}
