using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour {

    public GameObject[] character;

    public void PlayBTN()
    {
        if(character[0] ==true)
        {
            Application.LoadLevel(0);
        }
        if(character[1]==true)
        {
            Application.LoadLevel(1);
        }
    }
}
