using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bolos : MonoBehaviour
{
    public GameObject Bola;
    public GameObject cuboclon;

    int cubi = 1;


    // Start is called before the first frame update
    void Start()
    {
        
        Bola.SetActive(true);
    }

    public void BolaChoca()
    {
        while (cubi < 10)
        {
            InstantiateCubitos();
            cubi++;
        }
    }
    void InstantiateCubitos()
    {
        Instantiate(cuboclon, transform.position, transform.rotation);
    }
}
