using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMapMoving : MonoBehaviour {


    public float mapSpeed;

	void Update ()
    {
        transform.Translate(0, mapSpeed * Time.deltaTime, 0);
        if(transform.localPosition.y >1272)
        {
            transform.localPosition = new Vector3(0, 0, 0);
        }
	}
}
