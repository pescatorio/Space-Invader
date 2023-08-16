using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour
{
    public int HP;
    public float SCORE;
    private Fighter_Data fighterData;

    // Start is called before the first frame update
    void Start()
    {
        fighterData = new Fighter_Data(HP);
    }

    void PlayerGameOver()
    {
        if (fighterData.getHP() <= 0)
        {
            soundManager.instance.PlayFighterExplosionSound();
            Panel_GameOver.instance.Show();
            Destroy(gameObject, 4.0f);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //부딫히는 collision을 가진 객체의 태그가 Enemy일 경우
        if (collision.CompareTag("Enemy"))
        {
            fighterData.decreaseHP(10);
            HPBar.instance.HpBarChangedByHit();
            soundManager.instance.PlayFighterColisionSound();
            if (fighterData.getHP() <= 0)
            {
                PlayerGameOver();
            }
        }
    }

}
