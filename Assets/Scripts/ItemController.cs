using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour {

    public GameObject player;
    public float blockSpeed;
    void Update()
    {
        if (player.transform.localPosition.y < -50)
        {
            transform.Translate(0, blockSpeed * Time.deltaTime, 0);
        }
        if(transform.position.y >1.2f)
        {
            Destroy(gameObject);
        }
    }


    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag =="Player")
        {
            Destroy(gameObject);
        }
    }
}
