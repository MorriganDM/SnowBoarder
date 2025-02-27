using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float RespawnDelay = 0.5f

    void OnTriggerEnter2D(Collider2D other) //procedimento para gatilho em colisão
    {
        if (other.tag == "Snow")
        {
            Invoke("Respawn", RespawnDelay)
        }    
    }

    void Respawn()
    {
        SceneManager.LoadScene(0);
    }
}
