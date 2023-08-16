using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Panel_GameOver : MonoBehaviour
{
    public static Panel_GameOver instance;

    private void Awake()
    {
        transform.gameObject.SetActive(false); // 게임이 시작되면 GameOver 팝업 창을 보이지 않도록 한다.
        if (Panel_GameOver.instance == null) //incetance가 비어있는지 검사합니다.
        {
            Panel_GameOver.instance = this; //자기자신을 담습니다.
        }
    }

    public void Show()
    {
        transform.gameObject.SetActive(true); // GameOver 팝업 창을 화면에 표시 시키고
        
    }


}