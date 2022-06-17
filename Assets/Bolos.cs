using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolos : MonoBehaviour
{
    public GameObject Bola;
    // Start is called before the first frame update
    void Start()
    {
        Bola.SetActive(true);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "bolos")
        {
            Bola.SetActive(false);
        }
    }
}
