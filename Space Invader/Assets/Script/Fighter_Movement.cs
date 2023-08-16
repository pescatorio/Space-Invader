using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter_Movement : MonoBehaviour
{
    public float Speed = 6f;
    //이동제한
    private float uperSideLimit = 4.0f;
    private float downSideLimit = -4.0f;
    private float leftSideLimit = -13.0f;
    private float rightSideLimit = 13.0f;




    void Update()
    {
        Move();
    }
    private void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow)&&transform.position.y < uperSideLimit) // ↑방향키
        {
            //Translate는 현재 위치에서 ()안에 들어간 값만큼 값을 변화시킨다.
            transform.Translate(Vector2.up * Speed * Time.deltaTime);
            //Time.deltaTime은 모든 기기에 같은 속도로 움직이게 하는데 사용
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > downSideLimit) // ↓
        {
            transform.Translate(Vector2.down * Speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow) && transform.position.x < rightSideLimit) // →
        {
            transform.Translate(Vector2.right * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > leftSideLimit) // ←
        {
            transform.Translate(Vector2.left * Speed * Time.deltaTime);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }


}
