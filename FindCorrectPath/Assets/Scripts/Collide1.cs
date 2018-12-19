using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Collide1 : MonoBehaviour
{

    [SerializeField] private string loadLevel;

    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(loadLevel);
        }
    }

}