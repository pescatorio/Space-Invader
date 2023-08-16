using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Data : MonoBehaviour
{
    private int HP;
    public Enemy_Data(int _HP) 
    {
        HP = _HP;
    }
    //Enemy_Data enemy = new Enemy_Data(50);
    public void decreaseHP(int damage)
    {
        HP -= damage;
    }
    // Enemy_Data enemy = new Enemy_Data(50);
    //Enemy_Data.decreaseHP(20);

    public int getHP()
    {
        return HP;
    }

}
