using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour {

    public int bestScore;
    public int mainScore;
    public GameObject mainText;
    public GameObject bestText;
    public bool rayCast = false;
    void Update ()
    {
        if (rayCast == true)
        {
            Debug.DrawRay(transform.position, transform.right * 0.5f, Color.red);
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.right, out hit, 0.5f))
            {
                Debug.Log(hit.collider.gameObject.name);
            }
        }
        if(rayCast ==false)
        {
           
        }
    }
    //void SaveCoinScore()
    //{
    //    PlayerPrefs.SetInt("best Score",bestScore);
    //}
    //void LoadedCoinScore()
    //{
    //    bestScore = PlayerPrefs.GetInt("best Score", bestScore);
    //}
}
