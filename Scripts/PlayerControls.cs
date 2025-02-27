using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    [SerializeField] float torqueAmount = 1f; //Serialized field e variáveis public tem a similaridade de que podem ser acessadas pelo painel da Unity, 
                                              // porém as variáves public podem ser alteradas acidentalmente posteriormente através de códigos
                                              //enquanto os parametros Serialized field não podem.
    [SerializeField] float boostSpeed = 50f;
    [SerializeField] float baseSpeed = 20f;
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    bool canMove = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); //GetComponent é para componentes do objeto no qual se encontra o script.
        surfaceEffector2D = FindFirstObjectByType<SurfaceEffector2D>(); //FindFirstObjectByType encontrará o primeiro objeto de determinado tipo.
    }                                                                                           

    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
    }

    public void DisableControls() //Public pode ser utilizado caso seja necessário acessar este procedimento atravéz de outro script
    {
        canMove = false;
    }

    void RespondToBoost()
    {
       if(Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else if (!Input.GetKey(KeyCode.UpArrow)) //Alternativas para esta linha: else
        {
            surfaceEffector2D.speed = baseSpeed;
        }

    }

    void RotatePlayer()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
             rb2d.AddTorque(torqueAmount);
        }
        
        else if(Input.GetKey(KeyCode.RightArrow))
        {
             rb2d.AddTorque(-torqueAmount);
        }
    }
}
