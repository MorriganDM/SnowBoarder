using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CrashDetector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) //procedimento para gatilho em colisão
    {
        if (other.tag == "Snow")
        {
            SceneManager.LoadScene(0);
        }    
    }
}
