using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float ReloadDelay = 1f;
    [SerializeField] ParticleSystem finishEffect;


    void OnTriggerEnter2D(Collider2D other) //procedimento para gatilho em colisão
    {
        if (other.tag == "Player")
        {
           Invoke("ReloadScene", ReloadDelay);
           finishEffect.Play();
        }    
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
