using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController_Script : MonoBehaviour
{
    public Text text;
    public static float score;
    public static float HP;
    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score : " + score.ToString();
    }
}
