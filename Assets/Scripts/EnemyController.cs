using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public GameObject player;
    public float speedDown;
    public float speedUp;
    public float coolTime;
    public float respawnTime;
    public float coolT2;
    public float resPawn2;
    public bool speedDN = false;
    public GameObject[] button;
    void Update ()
    {
        coolTime += Time.deltaTime;
        transform.Translate(0, -speedDown * Time.deltaTime, 0);
        if (player.transform.localPosition.y < -50)
        {
            transform.Translate(0, speedUp * Time.deltaTime, 0);
        }
        if(coolTime >respawnTime)
        {
            coolTime = 0;
            speedDown += 0.4f;
            speedDN = true;
        }
        if(speedDN ==true)
        {
            coolTime = 0;
            coolT2 += Time.deltaTime;
            if(coolT2 >resPawn2)
            {
                coolT2 = 0;
                speedDown -= 0.4f;
                speedDN = false;
            }
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag =="Player")
        {
            player.SetActive(false);
            Time.timeScale = 0;
            button[0].SetActive(true);
            button[1].SetActive(true);
            button[2].SetActive(true);
            button[3].SetActive(true);
            button[4].SetActive(true);
        }
    }
}
