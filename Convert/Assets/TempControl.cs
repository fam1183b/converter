using System;
using UnityEngine;
using UnityEngine.UI;

public class TempControl : MonoBehaviour
{
    private Text txt;
    private Text chek;
    private Text c;
    private Text f;
    private Text k;
    public GameObject C;
    public GameObject F;
    public GameObject K;
    public GameObject CHek;

    private void Start()
    {
        txt = GetComponent<Text>();
        c = C.GetComponent<Text>();
        f = F.GetComponent<Text>();
        k = K.GetComponent<Text>();
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
        else if (s == "+/-")
        {
            if (!txt.text.Contains("-"))
            {
                txt.text = "-" + txt.text;
            }
            else
            {
                txt.text = txt.text.Remove(0, 1);
            }
        }
        else if (s != ",")
        {
            txt.text = txt.text + s;
        }

        float i = Convert.ToSingle(txt.text);

        switch (chek.text)
        {
            case "C":
                c.text = txt.text;
                f.text = ((i * 9 / 5) + 32).ToString();
                k.text = (i + 273.15).ToString();
                break;
            case "F":
                c.text = ((i - 32) * 5 / 9).ToString();
                f.text = txt.text;
                k.text = ((i - 32) * 5 / 9 + 273.15).ToString();
                break;
            case "K":
                c.text = (i - 273.15).ToString();
                f.text = ((i - 273.15) * 9 / 5 + 32).ToString();
                k.text = txt.text;
                break;


        }
    }
}
