using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManeContr : MonoBehaviour
{
    public GameObject Mane;
    public GameObject len;
    public GameObject tem;
    public GameObject dolar;
    public GameObject mass;
    public GameObject plosh;
    public GameObject data;
    
    public void Re(string s)
    {
        switch (s)
        {
            case "":
                Mane.SetActive(true);
                len.SetActive(false);
                tem.SetActive(false);
                dolar.SetActive(false);
                mass.SetActive(false);
                plosh.SetActive(false);
                data.SetActive(false);
                break;
            case "l":
                len.SetActive(true);
                Mane.SetActive(false);
                break;
            case "t":
                tem.SetActive(true);
                Mane.SetActive(false);
                break;
            case "d":
                dolar.SetActive(true);
                Mane.SetActive(false);
                break;
            case "m":
                mass.SetActive(true);
                Mane.SetActive(false);
                break;
            case "p":
                plosh.SetActive(true);
                Mane.SetActive(false);
                break;
            case "da":
                data.SetActive(true);
                Mane.SetActive(false);
                break;
        }
    }
}
