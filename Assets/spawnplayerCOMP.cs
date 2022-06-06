using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnplayerCOMP : MonoBehaviour

{
    public float speed;
    public bool toright;

    // Start is called before the first frame update
    void Start()
    {
        toright = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (toright)
       
            // -2 y 1.8
        {
            transform.position += new Vector3(0, 0, speed);

        }
        else
        {
            transform.position -= new Vector3(0, 0, speed);
        }

        if (transform.position.z > 2)
        {
            toright = false;
        }
        if (transform.position.z < -2.4)  
        {
            toright = true;
        }

        //es en el eje Z el movimiento porque lka pista está al revez
    }
}
