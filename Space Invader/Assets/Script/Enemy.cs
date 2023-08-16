using System;
using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int HP;
    private Enemy_Data enemyData;
 //   bool IsEnemyAlive = true;


    // Start is called before the first frame update
    void Start()
    {
        enemyData = new Enemy_Data(HP);

    }

    void FixedUpdate()
    {
        //적이 죽을때
        if (enemyData.getHP() <= 0)
        {
            soundManager.instance.PlayEnemyExplosionSound(); //soundManager를 통해 효과음 발생
            ScoreText_Script.instance.IncreaseScore();
            Destroy(gameObject,0.1f);
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //부딫히는 collision을 가진 객체의 태그가 Player_Missile일 경우
        if (collision.CompareTag("Player_Missile"))
        {
            enemyData.decreaseHP(10);

        }

        if (collision.CompareTag("Freindly"))
        {
            Destroy(gameObject,-0.1f);

        }
    }
 /*   IEnumerator EnemyCycleControl()
    {
        IsEnemyAlive = true;
        //1초 후에
        yield return new WaitForSeconds(1);
        IsEnemyAlive = false;
    }*/

}
