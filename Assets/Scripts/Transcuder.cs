using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transcuder : MonoBehaviour
{
    public GameObject blood1;
    public GameObject blood2;
    public GameObject blood3;
    public GameObject baby;
    public GameObject placenta;
    public GameObject cord;

    // Start is called before the first frame update
    void Start()
    {

    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("body"))
        {
            if (blood1 != null)
            {
                blood1.SetActive(true);
            }
            if (blood2 != null)
            {
                blood2.SetActive(true);
            }
            if (blood3 != null)
            {
                blood3.SetActive(true);
            }

            baby.SetActive(true);
            placenta.SetActive(true);
            cord.SetActive(true);
            ;

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (blood1 != null)
        {
            blood1.SetActive(false);
        }
        if (blood2 != null)
        {
            blood2.SetActive(false);
        }
        if (blood3 != null)
        {
            blood3.SetActive(false);
        }
        baby.SetActive(false);
        placenta.SetActive(false);
        cord.SetActive(false);
    }
}
