using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideLvl3 : MonoBehaviour
{
    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.name == "player")
        {
            Application.LoadLevel("Level3FindCorrectPath");
        }
    }

}