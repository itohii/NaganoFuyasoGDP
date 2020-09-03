using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreTxt;

    int ScoreCnt;

    // Start is called before the first frame update
    void Start()
    {
        ScoreCnt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreTxt.text = "GDP:" + ScoreCnt.ToString() + "円";
    }

    public void AddScore()
    {
        ScoreCnt += 10;
    }
}
