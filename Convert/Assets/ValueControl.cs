using System;
using UnityEngine;
using UnityEngine.UI;

public class ValueControl : MonoBehaviour
{
    private Text txt;
    private Text chek;
    private Text a;
    private Text b;
    private Text c;
    private Text d; 
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject CHek;

    private void Start()
    {
        txt = GetComponent<Text>();
        a = A.GetComponent<Text>();
        b = B.GetComponent<Text>();
        c = C.GetComponent<Text>();
        d = D.GetComponent<Text>();
        chek = CHek.GetComponent<Text>();
    }

    public void Converter(string s)
    {
        if (txt.text.Substring(0) == "0")
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
            case "$":
                a.text = txt.text;
                b.text = (i * 0.92).ToString();
                c.text = (i * 6.37).ToString();
                d.text = (i * 80).ToString();
                break;
            case "€":
                a.text = (i * 1.08).ToString();
                b.text = txt.text;
                c.text = (i * 6.88).ToString();
                d.text = (i * 85.35).ToString();
                break;
            case "¥":
                a.text = (i / 6.37).ToString();
                b.text = (i / 6.88).ToString();
                c.text = txt.text;
                d.text = (i * 14.24).ToString();
                break;
            case "₽":
                a.text = (i / 80).ToString();
                b.text = (i / 85.35).ToString();
                c.text = (i / 14.24).ToString();
                d.text = txt.text;
                break;
            
        }
    }
}