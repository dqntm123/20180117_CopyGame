using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMoving : MonoBehaviour {



    public GameObject player;
    public float moveSpeed;
    public Animator dogjang;
    public float v ;
    public GameObject button;

    public void LButton()
    {
        player.transform.Translate(-moveSpeed, 0, 0);
        if (player.transform.localPosition.x <= -325)
        {
            player.transform.localPosition = new Vector3(-325,player.transform.localPosition.y,player.transform.localPosition.z);
        }
        if (player.transform.localPosition.x >= 325)
        {
            player.transform.localPosition = new Vector3(325, player.transform.localPosition.y, player.transform.localPosition.z);
        }
    }
    public void RButton()
    {
        player.transform.Translate(moveSpeed, 0, 0);
        if (player.transform.localPosition.x >=325)
        {
            player.transform.localPosition = new Vector3(325,player.transform.localPosition.y,player.transform.localPosition.z);
        }
        if (player.transform.localPosition.x <= -325)
        {
            player.transform.localPosition = new Vector3(-325, player.transform.localPosition.y, player.transform.localPosition.z);
        }
    }
}
