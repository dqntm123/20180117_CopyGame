using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour {

    //public Vector3 myCurPos;
    public GameObject player;
    public float moveSpeed;
    public float slimeCool;
    public float respawnTime;
    public bool resPawnTimer = false;
    public GameObject warm;
    public GameObject coinText;
    public int _coin = 0;
    public Animator dogjang;
    public float v;
    public GameObject randomboxed;
    void Start()
    {
        //myCurPos = gameObject.transform.localPosition;
        LoadedCoinScore();
        coinText.GetComponent<UILabel>().text = _coin + "";
    }

    void Update()
    {
        v = Input.GetAxis("Horizontal");
        dogjang.SetFloat("Idle", v);
        //if(randomboxed.GetComponent<RandomBoxController>().rnd ==2)
        //{
            
        //}
        if (resPawnTimer ==true)
        {
            respawnTime += Time.deltaTime;
            if(respawnTime >slimeCool)
            {
                resPawnTimer = false;
                respawnTime = 0;
                moveSpeed = 0.17f;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            dogjang.SetBool("RunL", true);
            transform.Translate(-moveSpeed, 0, 0);
            if(transform.localPosition.x <=-325)
            {
                transform.localPosition = new Vector3(-325, transform.localPosition.y, transform.localPosition.z);
            }
            if (transform.localPosition.x >= 325)
            {
                transform.localPosition = new Vector3(325, transform.localPosition.y, transform.localPosition.z);
            }
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            dogjang.SetBool("RunL", false);
        }
            if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            dogjang.SetBool("RunR", true);
            transform.Translate(moveSpeed, 0, 0);
            if (transform.localPosition.x >= 325)
            {
                transform.localPosition = new Vector3(325, transform.localPosition.y, transform.localPosition.z);
            }
            if (transform.localPosition.x <= -325)
            {
                transform.localPosition = new Vector3(-325, transform.localPosition.y, transform.localPosition.z);
            }
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            dogjang.SetBool("RunR", false);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag =="Slime")
        {
            resPawnTimer = true;
            moveSpeed = 0;
        }
        if (col.gameObject.tag == "Coin")
        {
            _coin += 1;
            coinText.GetComponent<UILabel>().text = _coin +"";
            SaveCoinScore();
        }
    }
    void OnTriggerEnter(Collider col)
    {

    }
    void SaveCoinScore()
    {
        PlayerPrefs.SetInt("coin", _coin);
    }
    void LoadedCoinScore()
    {
        _coin= PlayerPrefs.GetInt("coin", _coin);
    }
}