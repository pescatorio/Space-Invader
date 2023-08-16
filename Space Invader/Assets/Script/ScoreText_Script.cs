using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreText_Script : MonoBehaviour
{
    public static ScoreText_Script instance; //싱글턴을 통해 score변수를 가져오는 스크립트
    public Text scoreText;
    public int score;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

    public void IncreaseScore()
    {
        //score++;
        //Debug.Log($"{score}");
        //scoreText.text = score.ToString();
        //score Text UI에 문자열이 들어가지 않으면서 인스턴스가 무한반복되는 에러가 발생.
    }

}
