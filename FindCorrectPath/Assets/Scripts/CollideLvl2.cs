using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideLvl2 : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            Application.LoadLevel("Level2FindCorrectPath");
        }
    }

}