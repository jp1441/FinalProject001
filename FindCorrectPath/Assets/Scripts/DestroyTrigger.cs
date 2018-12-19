using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrigger : MonoBehaviour {

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "trigger")
        {
            Destroy(col.gameObject);
            GetComponent<AudioSource>().Play();
        }
    }
}
