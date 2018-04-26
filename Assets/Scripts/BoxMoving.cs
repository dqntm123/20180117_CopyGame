using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMoving : MonoBehaviour {


    public float boxSpeed;
    public float limitX;
    public float limitXX;
	
	void FixedUpdate ()
    {
        gameObject.transform.Translate(boxSpeed*Time.deltaTime , 0, 0);
        if(transform.localPosition.x >limitX)
        {
            boxSpeed = -boxSpeed;
        }
        if (transform.localPosition.x <limitXX)
        {
            boxSpeed = -boxSpeed;
        }
    }
}
