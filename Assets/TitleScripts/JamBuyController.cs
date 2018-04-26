using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamBuyController : MonoBehaviour {

    public GameObject jamCountText;
    public GameObject Text2;
    public GameObject[] lockBTN;
    public int count = 0;
    public int gamFive = 500;
    public int gamHun = 1000;
    public int gamFit = 1500;
    public int gamTwoHun = 2000;
    public int a;
    public int b;
    public int c;
    public int d;
    public int e;
    void Start ()
    {
        LoadedCount();
        jamCountText.GetComponent<UILabel>().text = "" + count;
        Text2.GetComponent<UILabel>().text = "" + count;
        if(a ==1)
        {
            lockBTN[0].SetActive(false);
        }
        else
        {
            lockBTN[0].SetActive(true);
        }
        if (b == 2)
        {
            lockBTN[1].SetActive(false);
        }
        else
        {
            lockBTN[1].SetActive(true);
        }
        if (c == 3)
        {
            lockBTN[2].SetActive(false);
        }
        else
        {
            lockBTN[2].SetActive(true);
        }
        if (d == 4)
        {
            lockBTN[3].SetActive(false);
        }
        else
        {
            lockBTN[3].SetActive(true);
        }
        if (e == 5)
        {
            lockBTN[4].SetActive(false);
        }
        else
        {
            lockBTN[4].SetActive(true);
        }
    }
    void Update()
    {
        LoadedCount();
    }
    public void FiveJam()
    {
        LoadedCount();
        count += gamFive;
        jamCountText.GetComponent<UILabel>().text = ""+count;
        Text2.GetComponent<UILabel>().text = "" + count;
        SaveCount();
    }
    public void Hungam()
    {
        LoadedCount();
        count += gamHun;
        jamCountText.GetComponent<UILabel>().text = "" + count;
        Text2.GetComponent<UILabel>().text = "" + count;
        SaveCount();
    }
    public void FivetHunJam()
    {
        LoadedCount();
        count += gamFit;
        jamCountText.GetComponent<UILabel>().text = "" + count;
        Text2.GetComponent<UILabel>().text = "" + count;
        SaveCount();
    }
    public void TwoHunJam()
    {
        LoadedCount();
        count += gamTwoHun;
        jamCountText.GetComponent<UILabel>().text = "" + count;
        Text2.GetComponent<UILabel>().text = "" + count;
        SaveCount();
    }
    void SaveCount()
    { 
        PlayerPrefs.SetInt("jam", count);
    }
    void LoadedCount()
    {
        count = PlayerPrefs.GetInt("jam", count);
        a=PlayerPrefs.GetInt("HumanPaid", a);
        b=PlayerPrefs.GetInt("BigHeadPaid", b);
        c=PlayerPrefs.GetInt("BabyPaid", c);
        d=PlayerPrefs.GetInt("NinjaPaid", d);
        e=PlayerPrefs.GetInt("DigimonPaid", e);
    }
    public void HumanCH()
    {
        if (count >= 500)
        {
            a = 1;
            PlayerPrefs.SetInt("HumanPaid", a);
            lockBTN[0].SetActive(false);
            LoadedCount();
            count -= 500;
            jamCountText.GetComponent<UILabel>().text = "" + count;
            Text2.GetComponent<UILabel>().text = "" + count;
            SaveCount();
        }
    }
    public void BigHeadCH()
    {
        if (count >= 1000)
        {
            b = 2;
            PlayerPrefs.SetInt("BigHeadPaid", b);
            lockBTN[1].SetActive(false);
            LoadedCount();
            count -= 1000;
            jamCountText.GetComponent<UILabel>().text = "" + count;
            Text2.GetComponent<UILabel>().text = "" + count;
            SaveCount();
        }
    }
    public void BabyCH()
    {
        if (count >= 1500)
        {
            c= 3;
            PlayerPrefs.SetInt("BabyPaid", c);
            lockBTN[2].SetActive(false);
            LoadedCount();
            count -= 1500;
            jamCountText.GetComponent<UILabel>().text = "" + count;
            Text2.GetComponent<UILabel>().text = "" + count;
            SaveCount();
        }
    }
    public void NinjaCH()
    {
        if (count >= 2500)
        {
            d = 4;
            PlayerPrefs.SetInt("NinjaPaid", d);
            lockBTN[3].SetActive(false);
            LoadedCount();
            count -= 2500;
            jamCountText.GetComponent<UILabel>().text = "" + count;
            Text2.GetComponent<UILabel>().text = "" + count;
            SaveCount();
        }
    }
    public void DigiMonCH()
    {
        if (count >= 4000)
        {
            e = 5;
            PlayerPrefs.SetInt("DigimonPaid", e);
            lockBTN[4].SetActive(false);
            LoadedCount();
            count -= 4000;
            jamCountText.GetComponent<UILabel>().text = "" + count;
            Text2.GetComponent<UILabel>().text = "" + count;
            SaveCount();
        }
    }
}
