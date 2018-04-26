using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionController : MonoBehaviour {

    public GameObject opTion2;
    public GameObject bgmMuteObj;
    public GameObject effectMuteObj;
    public GameObject storeObj;
    public GameObject missionObj;
    public GameObject characterCho;

    public void OpTionSecond()
    {
        opTion2.SetActive(true);
        storeObj.SetActive(false);
        missionObj.SetActive(false);
        characterCho.SetActive(false);
    }
    public void OpTionDestory()
    {
        opTion2.SetActive(false);
    }
    public void StoreInstance()
    {
        opTion2.SetActive(false);
        bgmMuteObj.SetActive(false);
        effectMuteObj.SetActive(false);
        storeObj.SetActive(true);
        missionObj.SetActive(false);
        characterCho.SetActive(false);
    }
    public void StoreDestory()
    {
        storeObj.SetActive(false);
    }
    public void BGMINS()
    {
        bgmMuteObj.SetActive(true);
        storeObj.SetActive(false);
        missionObj.SetActive(false);
        characterCho.SetActive(false);
    }
    public void EffectINS()
    {
        effectMuteObj.SetActive(true);
        storeObj.SetActive(false);
        missionObj.SetActive(false);
        characterCho.SetActive(false);
        //GameObject effectwindow = Instantiate(effectMuteObj) as GameObject;
        //effectwindow.transform.parent = titleMain.transform;
        //GameObject.Find("BG");
        //effectwindow.transform.localScale = new Vector3(1, 1, 1);
        //effectwindow.transform.localPosition += new Vector3(280, -190, 0);
    }
    public void BGMdestroy()
    {
        bgmMuteObj.SetActive(false);
    }
    public void EffectDestroy()
    {
        effectMuteObj.SetActive(false);
    }
    public void MissionIns()
    {
        opTion2.SetActive(false);
        bgmMuteObj.SetActive(false);
        effectMuteObj.SetActive(false);
        storeObj.SetActive(false);
        missionObj.SetActive(true);
        characterCho.SetActive(false);
    }
    public void MissDestroy()
    {
        missionObj.SetActive(false);
    }
    public void CharacterINS()
    {
        opTion2.SetActive(false);
        bgmMuteObj.SetActive(false);
        effectMuteObj.SetActive(false);
        storeObj.SetActive(false);
        missionObj.SetActive(false);
        characterCho.SetActive(true);
    }
    public void CharacterDes()
    {
        characterCho.SetActive(false);
    }
}
