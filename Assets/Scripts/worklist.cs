using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worklist : MonoBehaviour
{
    [Header("Lista de tareas")]
    //Tarea 1 atrapar un obj
    public bool atrapar;
    public bool noCaida;
    public bool mitadAtrapa;

    public static worklist instance;


    // Start is called before the first frame update
    void Start()
    {
        atrapar = false;
        noCaida = false;
        mitadAtrapa = false;
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        Destroy(this.gameObject);

    }

    // Update is called once per frame
    void Update()
    {

    }
    
/*     public void cambiarCancion(int nombre)
    {
        if (nombre == 1)
        {
            this.gameObject.GetComponent<AudioSource>().clip = canciones[0];
            controlador.Play();
        } else if (nombre == 2)
        {
            this.gameObject.GetComponent<AudioSource>().clip = canciones[1];
            controlador.Play();
        }
        else if(nombre == 3)
        {
            this.gameObject.GetComponent<AudioSource>().clip = canciones[2];
            controlador.Play();
        }
    } */

    public void DestroyGameObject()
    {
        Destroy(this.gameObject);
    }

    public void setTarea1(bool a){
        this.atrapar = a;
    }
}
