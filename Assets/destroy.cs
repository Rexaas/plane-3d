﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    void OnCollisionEnter()
    {
        Destroy(this.gameObject);
        Debug.Log("done!");
    }
}
