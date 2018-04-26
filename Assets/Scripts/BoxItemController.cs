using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxItemController : MonoBehaviour {


    public GameObject enemy;
    public float coolTime;
    public float resPawnTIme;
    public bool coolT = false;
    public GameObject enemyStop;
    public GameObject moveReturn;
    public GameObject player;
    public GameObject[] hoBak;

	void Update ()
    {
		if(coolT==true)
        {
            coolTime += Time.deltaTime;
            if (coolTime > resPawnTIme)
            {
                coolTime = 0;
                coolT = false;
                enemy.GetComponent<EnemyController>(). speedDown = 0.5f;
            }
        }
	}

    public void EnemyStop()
    {
        enemy.GetComponent<EnemyController>().speedDown = 0;
        coolT = true;
        enemyStop.SetActive(false);
        enemy.GetComponent<EnemyController>().coolTime = 0;
    }
    public void MoveReturn()
    {
        moveReturn.SetActive(false);
        player.GetComponent<PlayerMoving>().moveSpeed = 0.17f;
        hoBak[0].SetActive(false);
        hoBak[1].SetActive(false);
        hoBak[2].SetActive(false);
    }
}
