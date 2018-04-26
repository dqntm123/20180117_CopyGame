using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour {

    public GameObject reTurnBTN;
    public GameObject windowS;
    public GameObject backLoad;
    public GameObject escapeCT;
    public GameObject gameOver;
    public GameObject reTurnPlay;
    public int a;

    public void PauseCT()
    {
        Time.timeScale = 0;
        reTurnBTN.SetActive(true);
        windowS.SetActive(true);
        backLoad.SetActive(true);
        escapeCT.SetActive(true);
    }
    public void ReTurnBT()
    {
        Time.timeScale = 1;
        reTurnBTN.SetActive(false);
        windowS.SetActive(false);
        backLoad.SetActive(false);
        escapeCT.SetActive(false);
        gameOver.SetActive(false);
    }
    public void BackLoad()
    {
        Application.LoadLevel(0);
        Time.timeScale = 1;
    }
    public void RePlaye()
    {
        Application.LoadLevel(a);
        Time.timeScale = 1;
        reTurnPlay.SetActive(false);
        windowS.SetActive(false);
        backLoad.SetActive(false);
        escapeCT.SetActive(false);
        gameOver.SetActive(false);
    }
    public void ESCape()
    {
        Application.Quit();
        //Debug.Log("Finsih");
    }
}
