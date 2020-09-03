using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class InputManager : MonoBehaviour
{
    public Text Score;

    public GameObject CoinEffect;

    public GameObject GameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.GetComponent<GameManager>().GameEnd)
        {
            return;
        }

        if (Input.anyKeyDown &&
            (!Input.GetMouseButton(0) && !Input.GetMouseButton(1) && !Input.GetMouseButton(2)))
        {
            foreach (KeyCode code in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKeyDown(code) &&
                    GameObject.FindGameObjectWithTag(code.ToString()))
                {
                    gameObject.GetComponent<AudioSource>().Play();
                    GameObject Obj = GameObject.FindGameObjectWithTag(code.ToString());
                    Vector3 Pos = new Vector3(Obj.transform.position.x, Obj.transform.position.y, -4);
                    GameObject Efc = Instantiate(CoinEffect, Pos, Quaternion.identity);
                    Destroy(Efc, 1.0f);
                    Destroy(GameObject.FindGameObjectWithTag(code.ToString()));
                    Score.GetComponent<Score>().AddScore();
                    break;
                }
            }
        }
    }
}
