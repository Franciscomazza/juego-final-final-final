using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnplayerCOMP : MonoBehaviour

{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < 1.8)
            // -2 y 1.8
        {
            transform.position += new Vector3(0, 0, speed);

        }
        
        //es en el eje Z el movimiento porque lka pista está al revez
    }
}
