using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syringe : MonoBehaviour
{
    public GameObject blood1;
    public GameObject blood2;
    public GameObject blood3;
    public GameObject baby;
    public GameObject image;
    public GameObject sucess;
    public GameObject time;
    public GameObject placenta;
    public GameObject cord;
    public GameObject min;
    public GameObject sec;
    public GameObject milsec;
    public GameObject colon;
    public GameObject colon1;
    public void Start()
    {
        //GameObject red = GetComponent<Transcuder>().blood1;
        //GameObject obj1 = GetComponent<Transcuder>().blood2;
        //GameObject obj2 = GetComponent<Transcuder>().blood3;
    }
    /*void OnCollisionEnter(Collision other)
    {
        GameObject red = GetComponent<Transcuder>().blood1;
        GameObject obj1 = GetComponent<Transcuder>().blood2;
        GameObject obj2 = GetComponent<Transcuder>().blood3;
        if (other.gameObject.name == "Blood")
        {
            Destroy(this.gameObject);
            red = null;
        }
        if (other.gameObject.name == "Blood1")
        {
            Destroy(other.gameObject);
            obj1 = null;
        }
        if (other.gameObject.name == "Blood2")
        {
            Destroy(other.gameObject);
            obj2 = null;
        }

    }*/
    private void OnTriggerEnter(Collider other)
    {
        //GameObject red = GetComponent<Transcuder>().blood1;
        //GameObject obj1 = GetComponent<Transcuder>().blood2;
        //GameObject obj2 = GetComponent<Transcuder>().blood3;
        if (other.gameObject.name == "Blood")
        {
            Destroy(other.gameObject);
            blood1 = null;

        }
        if (other.gameObject.name == "Blood1")
        {
            Destroy(other.gameObject);
            blood2 = null;

        }
        if (other.gameObject.name == "Blood2")
        {
            Destroy(other.gameObject);
            blood3 = null;

        }
        if (other.gameObject.name == "baby")
        {
            //Time.timeScale = 0;
            image.gameObject.SetActive(true);
            time.gameObject.SetActive(false);
            blood1.SetActive(false);
            blood2.SetActive(false);
            blood3.SetActive(false);
            baby.SetActive(false);
            placenta.SetActive(false);
            cord.SetActive(false);
            min.SetActive(false);
            sec.SetActive(false);
            milsec.SetActive(false);
            colon.SetActive(false);
            colon1.SetActive(false);

        }
        if (blood1 == null && blood2 == null && blood3 == null)
        {
            //Time.timeScale = 0;
            sucess.gameObject.SetActive(true);
            time.gameObject.SetActive(false);
            blood1.SetActive(false);
            blood2.SetActive(false);
            blood3.SetActive(false);
            baby.SetActive(false);
            placenta.SetActive(false);
            cord.SetActive(false);
            min.SetActive(false);
            sec.SetActive(false);
            milsec.SetActive(false);
            colon.SetActive(false);
            colon1.SetActive(false);
        }
    }
}

