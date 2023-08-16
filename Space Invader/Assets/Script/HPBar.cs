using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    public static HPBar instance;
    public Slider hpBar;
    public float maxHP;
    public float currentHP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

    // Update is called once per frame

    
    public void HpBarChangedByHit()
    {
        if (currentHP > 0) 
        {
            currentHP -= 10;
            hpBar.value = currentHP;
        }
    }

}
