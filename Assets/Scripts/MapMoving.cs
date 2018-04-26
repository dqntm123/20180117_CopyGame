using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMoving : MonoBehaviour
{

    public GameObject mapMV;
    public float mapSpeed ;
    //public bool isDown = false;
    public GameObject player;

    void Update()
    {
        if (player.transform.localPosition.y < -50)
        {
            transform.Translate(0, mapSpeed * Time.deltaTime, 0);
        }
        if (transform.localPosition.y >2400)
        {
            transform.localPosition = new Vector3(0,-1240,0);
        }
    }
}
