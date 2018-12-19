using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySphere : MonoBehaviour
{

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere")
        {
            Destroy(col.gameObject);
        }
    }
}
