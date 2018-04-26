using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChoice : MonoBehaviour {

    public GameObject[] characterCH;
    public GameObject choiceChang;
    public int cH ;

    void Update()
    {
        LoadedCH();
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void DogIns()
    {
        characterCH[0].SetActive(true);
        characterCH[1].SetActive(false);
        characterCH[2].SetActive(false);
        characterCH[3].SetActive(false);
        characterCH[4].SetActive(false);
        characterCH[5].SetActive(false);
        choiceChang.SetActive(false);
        cH = 1;
        SavedCH();
    }
    public void HumanIns()
    {
        characterCH[0].SetActive(false);
        characterCH[1].SetActive(true);
        characterCH[2].SetActive(false);
        characterCH[3].SetActive(false);
        characterCH[4].SetActive(false);
        characterCH[5].SetActive(false);
        choiceChang.SetActive(false);
        cH = 2;
        SavedCH();
    }
    public void BigHeadIns()
    {
        characterCH[0].SetActive(false);
        characterCH[1].SetActive(false);
        characterCH[2].SetActive(true);
        characterCH[3].SetActive(false);
        characterCH[4].SetActive(false);
        characterCH[5].SetActive(false);
        choiceChang.SetActive(false);
        cH = 3;
        SavedCH();
    }
    public void BabyIns()
    {
        characterCH[0].SetActive(false);
        characterCH[1].SetActive(false);
        characterCH[2].SetActive(false);
        characterCH[3].SetActive(true);
        characterCH[4].SetActive(false);
        characterCH[5].SetActive(false);
        choiceChang.SetActive(false);
        cH = 4;
        SavedCH();
    }
    public void NinjaIns()
    {
        characterCH[0].SetActive(false);
        characterCH[1].SetActive(false);
        characterCH[2].SetActive(false);
        characterCH[3].SetActive(false);
        characterCH[4].SetActive(true);
        characterCH[5].SetActive(false);
        choiceChang.SetActive(false);
        cH = 5;
        SavedCH();
    }
    public void DigiMonIns()
    {
        characterCH[0].SetActive(false);
        characterCH[1].SetActive(false);
        characterCH[2].SetActive(false);
        characterCH[3].SetActive(false);
        characterCH[4].SetActive(false);
        characterCH[5].SetActive(true);
        choiceChang.SetActive(false);
        cH = 6;
        SavedCH();
    }
    public void Loadapp()
    {
        Application.LoadLevel(cH);
        SavedCH();
    }
	void SavedCH()
    {
        PlayerPrefs.SetInt("cH", cH);
    }

    void LoadedCH()
    {
        cH = PlayerPrefs.GetInt("cH", cH);
    }
}
