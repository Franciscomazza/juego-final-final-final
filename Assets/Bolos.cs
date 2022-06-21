using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bolos : MonoBehaviour
{
    public GameObject Bola;



    // Start is called before the first frame update
    void Start()
    {
        
        Bola.SetActive(true);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "bolos")
        {
            Bola.SetActive(false);
         
       
        }
    }
}
