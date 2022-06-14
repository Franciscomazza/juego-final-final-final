using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnplayerCOMP : MonoBehaviour
{
    public GameObject flecha;
    public GameObject spawnplayer;

    public float throwPower;
    public float throwSpeed;
    int throwInfluence = 1;

    public bool toright;
    public float horSpeed;
    int influence = 1;

    public float rotSpeed;
    int rotInfluence = 1;

    Rigidbody RB;
    bool setpos = false, setrot = false, setforce = false;

    // Start is called before the first frame update
    void Start()
    {
        spawnplayer.SetActive(false);
        toright = true;
        flecha.SetActive(false);
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //flecha.SetActive(false / true);
        if(setpos == false)
        {
            transform.position += new Vector3(0, 0, 1) * influence * horSpeed * Time.deltaTime;
        }
        if(setpos == true && setrot == true)
        {
            transform.eulerAngles += new Vector3(0,1,0) * rotInfluence * rotSpeed * Time.deltaTime;
        }
        if (setrot == true && setforce == true)
        {
            throwPower += throwInfluence * throwSpeed * Time.deltaTime;
        }

        if (transform.position.z > 2)
        {
            influence *= -1;
            toright = false;
        }
        if (transform.position.z < -2.4)
        {
            influence *= -1;
            toright = true;
        }

        if(transform.eulerAngles.y > 125)
        {
            rotInfluence *= -1;
        }
        if(transform.eulerAngles.y < 55)
        {
            rotInfluence *= -1;
        }

        if(throwPower > 30)
        {
            throwInfluence *= -1;
        }
        if(throwPower < 10)
        {
            throwInfluence *= -1;
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        
        {
            setpos = true;
            if(setpos == true)
            {
                horSpeed =   0;
                flecha.SetActive(true);
                if (setrot == true)
                {
                    rotSpeed = 0;
                    if (setforce == true)
                    {
                        RB.AddForce(transform.forward * throwPower, ForceMode.Impulse);
                        flecha.SetActive(false);
                    }
                    setforce = true;
                }
                setrot = true;
            }
        }
    }

    public void btn()
    {
       
        spawnplayer.SetActive(true);
    }
}
