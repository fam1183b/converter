using System;
using UnityEngine;
using UnityEngine.UI;

public class MassControl : MonoBehaviour
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
            case "г":
                a.text = txt.text;
                b.text = (i * 0.001).ToString();
                c.text = (i * 0.000001).ToString();
                d.text = (i * 0.0022).ToString();
                break;
            case "кг":
                a.text = (i * 0.001).ToString();
                b.text = txt.text;
                c.text = (i * 1000).ToString();
                d.text = (i * 2.2).ToString();
                break;
            case "т":
                a.text = (i * 0.000001).ToString();
                b.text = (i * 0.001).ToString();
                c.text = txt.text;
                d.text = (i * 2204).ToString();
                break;
            case "фунт":
                a.text = (i * 453.59).ToString();
                b.text = (i * 0.45).ToString();
                c.text = (i * 0.00045).ToString();
                d.text = txt.text;
                break;
        }
    }
}