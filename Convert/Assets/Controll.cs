using System;
using UnityEngine;
using UnityEngine.UI;

public class Controll : MonoBehaviour
{
    private Text txt;
    private Text chek;
    private Text mm;
    private Text cm;
    private Text m;
    private Text km;
    public GameObject MM;
    public GameObject CM;
    public GameObject M;
    public GameObject KM;
    public GameObject CHek;

    private void Start()
    {
        txt = GetComponent<Text>();
        mm = MM.GetComponent<Text>();
        cm = CM.GetComponent<Text>();
        m = M.GetComponent<Text>();
        km = KM.GetComponent<Text>();
        chek = CHek.GetComponent<Text>();
    }

    public void Converter(string s)
    {
        if(txt.text.Substring(0) == "0")
        {
            txt.text = "";
        }
        if (s == "C")
        {
            txt.text = "0";
        }
        else if (s == "," && !txt.text.Contains(","))
        {
            txt.text = txt.text + s;
        }
        else if (s != ",")
        {
            txt.text = txt.text + s;
        }

        float i = Convert.ToSingle(txt.text);

        switch (chek.text)
        {
            case "мм":
                mm.text = txt.text;
                cm.text = (i / 10).ToString();
                m.text = (i / 1000).ToString();
                km.text = (i / 1000000).ToString();
                break;
            case "см":
                mm.text = (i * 10).ToString();
                cm.text = txt.text;
                m.text = (i / 100).ToString();
                km.text = (i / 100000).ToString();
                break;
            case "м":
                mm.text = (i * 1000).ToString();
                cm.text = (i * 100).ToString();
                m.text = txt.text;
                km.text = (i / 1000).ToString();
                break;
            case "км":
                mm.text = (i * 1000000).ToString();
                cm.text = (i * 100000).ToString();
                m.text = (i * 1000).ToString();
                km.text =  txt.text;
                break;
        }
    }
}
