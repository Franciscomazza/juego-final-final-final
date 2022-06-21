using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bolos : MonoBehaviour
{
    public GameObject Bola;
    public Text txtganaste;
    public GameObject camara;
    public Text txtgameover;
    public int Contador;
    public GameObject ObjectToClone;
    // Start is called before the first frame update
    void Start()
    {
        txtgameover.enabled = false;
        camara.SetActive(false);
        txtganaste.enabled = false;
        Bola.SetActive(true);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "bolos")
        {
            txtgameover.enabled = true;
            Bola.SetActive(false);
            camara.SetActive(true);
            txtganaste.enabled = true;
        }
        else
        {
            txtgameover.enabled = true;
            camara.SetActive(true);
            while (Contador < 10)
            {
                Instantiate(ObjectToClone);
                ObjectToClone.transform.position = new Vector3(0, 50, 0);
                Contador++;
            }
        }
    }
}
