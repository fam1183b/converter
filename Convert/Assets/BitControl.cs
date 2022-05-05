using System;
using UnityEngine;
using UnityEngine.UI;

public class BitControl : MonoBehaviour
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
        else
        {
            txt.text = txt.text + s;
        }

        float i = Convert.ToSingle(txt.text);

        switch (chek.text)
        {
            case "б":
                mm.text = txt.text;
                cm.text = (i / 8).ToString();
                m.text = (i / Math.Pow(1024, 1)).ToString();
                km.text = (i / Math.Pow(1024, 2)).ToString();
                mili.text = (i / (3.861 * Math.Pow(1024, 3))).ToString();
                break;
            case "Б":
                mm.text = (i * 8).ToString();
                cm.text = txt.text;
                m.text = (i / Math.Pow(1024, 1)).ToString();
                km.text = (i / Math.Pow(1024, 2)).ToString();
                mili.text = (i / (3.861 * Math.Pow(1024, 3))).ToString();
                break;
            case "КБ":
                mm.text = (i * Math.Pow(1024, 1) * 8).ToString();
                cm.text = (i * Math.Pow(1024, 1)).ToString();
                m.text = txt.text;
                km.text = (i / Math.Pow(1024, 1)).ToString();
                mili.text = (i / (3.861 * Math.Pow(1024, 2))).ToString();
                break;
            case "МБ":
                mm.text = (i * Math.Pow(1024, 2) * 8).ToString();
                cm.text = (i * Math.Pow(1024, 2)).ToString();
                m.text = (i * Math.Pow(1024, 1)).ToString();
                km.text = txt.text;
                mili.text = (i / (3.861 * Math.Pow(1024, 1))).ToString();
                break;
            case "ГБ":
                mm.text = (i * Math.Pow(1024, 3) * 8).ToString();
                cm.text = (i * Math.Pow(1024, 3)).ToString();
                m.text = (i * Math.Pow(1024, 2)).ToString();
                km.text = (i * Math.Pow(1024, 1)).ToString();
                mili.text = txt.text;
                break;
        }
    }
}
