using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowParticles : MonoBehaviour
{

    [SerializeField] ParticleSystem snowEffect;
    SurfaceEffector2D surfaceEffector2D;

    void Start()
    {
        surfaceEffector2D = FindFirstObjectByType<SurfaceEffector2D>(); //FindFirstObjectByType encontrará o primeiro objeto de determinado tipo.
    }

  

    void OnCollisionEnter2D(Collision2D other) //procedimento para gatilho em colisão, quando duas hitboxes entram contato.
    {
        if (other.gameObject.tag == "Snow")
        {
           snowEffect.Play();
        }    
    }

   void OnCollisionExit2D(Collision2D other) //procedimento para gatilho em colisão, quando duas hitboxes entram contato.
    {
        if (other.gameObject.tag == "Snow")
        {
           snowEffect.Stop();
        }    
    }

}
