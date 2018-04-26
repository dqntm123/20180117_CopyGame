using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public AudioClip[] effectSound;
    public AudioClip[] bgmSound;
    public GameObject optionSound;
    public void EffectMute()
    {

    }
    public void EffectIns()
    {
        
    }
    public void BGmMute()
    {
        //bgmSD = true;
        optionSound.GetComponent<AudioSource>().volume = 0;
    }
    public void BGMIns()
    {
        //bgmSD = false;
        optionSound.GetComponent<AudioSource>().volume = 1;
    }
	
}
