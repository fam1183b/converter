using System;
using UnityEngine;
using UnityEngine.UI;

public class PloshControl : MonoBehaviour
{
    private Text txt;
    private Text chek;
    private Text mm;
    private Text cm;
    private Text m;
    private Text km;
    private Text mili;
    public GameObject MM;
    public GameObject CM;
    public GameObject M;
    public GameObject KM;
    public GameObject MILI;
    public GameObject CHek;

    private void Start()
    {
        txt = GetComponent<Text>();
        mm = MM.GetComponent<Text>();
        cm = CM.GetComponent<Text>();
        m = M.GetComponent<Text>();
        km = KM.GetComponent<Text>();
        mili = MILI.GetComponent<Text>();
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
            case "мм^2":
                mm.text = txt.text;
                cm.text = (i * 0.01).ToString();
                m.text = (i * Math.Pow(10, -6)).ToString();
                km.text = (i * Math.Pow(10, -12)).ToString();
                mili.text = (i *(3.861 * Math.Pow(10, -13))).ToString();
                break;
            case "см^2":
                mm.text = (i * 100).ToString();
                cm.text = txt.text;
                m.text = (i * Math.Pow(10, -4)).ToString();
                km.text = (i * Math.Pow(10, -10)).ToString();
                mili.text = (i * (3.861 * Math.Pow(10, -11))).ToString();
                break;
            case "м^2":
                mm.text = (i * Math.Pow(10, 6)).ToString();
                cm.text = (i * Math.Pow(10, 4)).ToString();
                m.text = txt.text;
                km.text = (i * Math.Pow(10, -6)).ToString();
                mili.text = (i * (3.861 * Math.Pow(10, -7))).ToString();
                break;
            case "км^2":
                mm.text = (i * Math.Pow(10, 12)).ToString();
                cm.text = (i * Math.Pow(10, 10)).ToString();
                m.text = (i * Math.Pow(10, 6)).ToString();
                km.text = txt.text;
                mili.text = (i * (3.861 * Math.Pow(10, -1))).ToString();
                break;
            case "миля^2":
                mm.text = (i * (2.59 * Math.Pow(10, 12))).ToString();
                cm.text = (i * (2.59 * Math.Pow(10, 10))).ToString();
                m.text = (i * (2.59 * Math.Pow(10, 6))).ToString();
                km.text = (i * 2.59).ToString();
                mili.text = txt.text;
                break;
        }
    }
}
