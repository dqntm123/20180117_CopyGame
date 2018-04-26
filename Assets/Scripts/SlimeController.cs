using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeController : MonoBehaviour {

    public GameObject player;
    public float blockSpeed;
    public int random1;
    public int random2;
    public int positionY;

	void Update ()
    {
        if (player.transform.localPosition.y < -50)
        {
            transform.Translate(0, blockSpeed * Time.deltaTime, 0);
        }
        if (transform.localPosition.y > 1000)
        {
            transform.localPosition = new Vector3(random1, -3000, 0);
        }
        if (transform.localPosition.y < -4400)
        {
            transform.localPosition = new Vector3(random1, -2600, 0);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag =="Player")
        {
            transform.localPosition = new Vector3(random2, positionY, 0);
        }
    }
}
