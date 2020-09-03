using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //カウントダウン
    public float countdown;

    //時間を表示するText型の変数
    public Text timeText;

    public Text RetryText;

    public bool GameEnd;

    bool IsEndSoundPlay;

    void Start()
    {
        RetryText.enabled = false;
        IsEndSoundPlay = false;
    }

    // Update is called once per frame
    void Update()
    {
        //時間をカウントダウンする
        countdown += Time.deltaTime;

        //時間を表示する
        timeText.text = countdown.ToString("F0") + "時";

        //countdownが0以下になったとき
        if (countdown > 24)
        {
            GameEnd = true;
            timeText.text = "今日も1日\nお疲れ様でした！";

            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

        if (GameEnd &&
            !IsEndSoundPlay)
        {
            RetryText.enabled = true;
            IsEndSoundPlay = true;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
