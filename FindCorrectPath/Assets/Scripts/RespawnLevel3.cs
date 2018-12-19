using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnLevel3 : MonoBehaviour
{
    public float threshold;

    void FixedUpdate()
    {
        if (transform.position.y < threshold)
            transform.position = new Vector3(-2, 1, -13);
    }
}