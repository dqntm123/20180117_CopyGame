using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRayController : MonoBehaviour {


    public int mainScore=0;
    public int bestSocre =0;
    public GameObject mainText;
    public GameObject bestText;
    public int hitCount = 0;
    public Animator dogchang;

    void Start()
    {
        LoadedBestsScore();
        bestText.GetComponent<UILabel>().text = bestSocre + "";

    }
    void Update()
    {
        if(mainScore >bestSocre)
        {
            SaveBestScore();
            bestSocre = mainScore;
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag =="Block")
        {
            hitCount = 1;
        }
    }
    void OnTriggerExit()
    {
        mainScore += hitCount;
        mainText.GetComponent<UILabel>().text = mainScore + "";
        hitCount = 0;
    }
    void SaveBestScore()
    {
        PlayerPrefs.SetInt("Best Score", bestSocre);
    }
    void LoadedBestsScore()
    {
        bestSocre = PlayerPrefs.GetInt("Best Score",bestSocre);
    }
}
