using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public List<GameObject> food = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float num = 1f;
        InstantiateFood(num);
    }

    public void InstantiateFood(float num)
    {
        if (num == 1f)
        {
            Instantiate(food[0], new Vector2(Random.Range(0.0f, 0.0f), Random.Range(0.0f, 20.0f)), Quaternion.identity);
        }
    }
}
