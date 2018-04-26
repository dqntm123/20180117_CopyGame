using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBoxController : MonoBehaviour {

    public GameObject player;
    public int random1;
    public int random2;
    public int positionY;
    public float blockSpeed;
    public GameObject[] itemRandom;
    public int boxRandom = 0;
    public float coolTimer;
    public float resPawnTm;
    public bool coolTT = false;
    public GameObject[] hoBak;
    public int rnd;
    public GameObject[] button;
    void Update ()
    {
        if (player.transform.localPosition.y < -50)
        {
            transform.Translate(0, blockSpeed * Time.deltaTime, 0);
        }
        if (transform.localPosition.y > 1000)
        {
            transform.localPosition = new Vector3(random1, -2500, 0);
        }
        if (transform.localPosition.y < -4400)
        {
            transform.localPosition = new Vector3(random1, -3000, 0);
        }
        if(coolTT ==true)
        {
            coolTimer += Time.deltaTime;
            if(coolTimer>resPawnTm)
            {
                coolTimer = 0;
                coolTT = false;
                hoBak[0].SetActive(false);
                hoBak[1].SetActive(false);
                hoBak[2].SetActive(false);
                player.GetComponent<PlayerMoving>().moveSpeed = 0.17f;
                button[0].GetComponent<ButtonMoving>().moveSpeed = 0.17f;
                button[1].GetComponent<ButtonMoving>().moveSpeed = 0.17f;
            }
            if (coolTT ==false)
            {
                player.GetComponent<PlayerMoving>().moveSpeed = 0.17f;
                button[0].GetComponent<ButtonMoving>().moveSpeed = 0.17f;
                button[1].GetComponent<ButtonMoving>().moveSpeed = 0.17f;
            }
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag =="Player")
        {
            transform.localPosition = new Vector3(random2, positionY, 0);
            int rnd = Random.Range(0,4);
            switch (rnd)
            {
                case 0:
                    itemRandom[0].SetActive(true);
                    itemRandom[1].SetActive(false);
                    break;
                case 1:
                    itemRandom[0].SetActive(false);
                    itemRandom[1].SetActive(true);
                    break;
                case 3:
                    player.GetComponent<PlayerMoving>().moveSpeed = -0.17f;
                    button[0].GetComponent<ButtonMoving>().moveSpeed = -0.17f;
                    button[1].GetComponent<ButtonMoving>().moveSpeed = -0.17f;
                    hoBak[0].SetActive(true);
                    hoBak[1].SetActive(true);
                    hoBak[2].SetActive(true);
                    coolTT = true;
                    break;
            }
        }
    }
}
