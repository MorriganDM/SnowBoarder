using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float ReloadDelay = 1f;
    [SerializeField] ParticleSystem finishEffect;


    void OnTriggerEnter2D(Collider2D other) //procedimento para gatilho em colisão quando duas hitboxes estão no mesmo espaço.
    {
        if (other.tag == "Player")
        {
           
           finishEffect.Play();
           GetComponent<AudioSource>().Play();
           Invoke("ReloadScene", ReloadDelay);

        }    
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
