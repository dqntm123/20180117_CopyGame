using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour {


    public float blockSpeed ;
    public GameObject player;
    //public bool isUp = false;
	
	void FixedUpdate ()
    {
        if (player.transform.localPosition.y <-50)
        {
            transform.Translate(0, blockSpeed * Time.deltaTime, 0);
            //Debug.Log(transform.localPosition);
        }
        if(transform.localPosition.y >1350)
        {
            transform.localPosition = new Vector3(0, -3960, 0);
        }
    }
}
