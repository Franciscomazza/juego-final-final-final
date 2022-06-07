using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnplayerCOMP : MonoBehaviour

{
    public float speed;
    public bool toright;
    public GameObject prefab1;
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
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("up arrow key is held down");
        }
        //if (transform.position.x > baseDer.transform.position.x - 1)
        //{
        //    toright = false;
        //    GameObject clon;
        //    clon = Instantiate(prefab1);
        //    clon.transform.position = baseDer.transform.position + new Vector3(0, yOffset, 0);

        //es en el eje Z el movimiento porque lka pista está al revez
    }
}
