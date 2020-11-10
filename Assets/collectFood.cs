using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class collectFood : MonoBehaviour
{

    public Text puntaje;

    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        puntaje.text = "Puntaje: " + score;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        score++;
    }
}
