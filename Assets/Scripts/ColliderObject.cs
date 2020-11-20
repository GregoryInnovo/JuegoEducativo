using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderObject : MonoBehaviour
{


    public void OnTriggerEnter2D(Collider2D collision)
    {
       Debug.Log("Entro algo");
        //worklist.instance.setTarea1(true);
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
       Debug.Log("Salio algo");
    }


    public void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("El objeto se queda ahi");
    }

}
