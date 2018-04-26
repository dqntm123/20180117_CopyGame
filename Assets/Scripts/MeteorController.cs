using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour {


    public float meteorSpeed;
	
	
	void Update ()
    {
        transform.Rotate(0,0,-meteorSpeed * Time.deltaTime);		
	}
}
