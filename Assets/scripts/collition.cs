using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collition : MonoBehaviour
{
    public fly fly;
    public move move;
    void OnCollisionEnter()
    {
        fly.enabled = false;
        move.enabled = false;
    }
}
