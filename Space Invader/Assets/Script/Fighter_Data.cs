using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter_Data : MonoBehaviour
{
    private int HP;

    public Fighter_Data(int _HP) //constructor
    {
        HP = _HP;
    }
    //Fighter_Data enemy = new Fighter_Data(50);
    public void decreaseHP(int damage)
    {
        HP -= damage;
    }
    // Fighter_Data enemy = new Fighter_Data(50);
    // Fighter_Data.decreaseHP(20);


    public int getHP()
    {
        return HP;
    }


}
