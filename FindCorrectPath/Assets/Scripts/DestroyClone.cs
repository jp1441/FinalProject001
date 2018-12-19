using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyClone : MonoBehaviour
{

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "trigger(Clone)")
        {
            Destroy(col.gameObject);
        }
    }
}
