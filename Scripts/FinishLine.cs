using System.Collections;
using System.Collections.Generic;
using Unity Engine;


public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("You've Finished");
    }
}
