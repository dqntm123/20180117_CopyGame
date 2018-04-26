using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour {


    public float fireSpeed;

    void Update ()
    {
        transform.Translate(0,-fireSpeed * Time.deltaTime, 0);
        if (transform.position.y<-5)
        {
            Destroy(gameObject);
        }
	}
}
