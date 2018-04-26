using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireManager : MonoBehaviour {


    public GameObject[] fireM;
    public float coolTime;
    public float respawnTime;
	
	void FixedUpdate ()
    {
        coolTime += Time.deltaTime;
        if(coolTime >respawnTime)
        {
            coolTime = 0;
            Instantiate(fireM[0],transform.position=new Vector3(Random.Range(-0.5f,0.5f),2,0),transform.rotation);
            Instantiate(fireM[1], transform.position = new Vector3(Random.Range(-0.25f,0.25f),2, 0), transform.rotation);
        }
	}
}
