using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeedX;
    public float moveSpeedY;
    float yMove;
    float xMove; //0이면 수직으로, 0 이외라면 좌우 중 랜덤으로 떨어짐
    int tmp; //랜덤 함수를 위한 임시변수

    // Start is called before the first frame update
    void Start()
    {
        tmp = Random.Range(0, 2);
    }

    void MoveControl()
    {
        yMove = moveSpeedY * Time.deltaTime;
        xMove = moveSpeedX * Time.deltaTime;

        if(tmp == 1)
        {
            transform.Translate(xMove, -yMove, 0);
        }
        else
        {
            transform.Translate(-xMove, -yMove, 0);
        }

    }
    // Update is called once per frame
    void Update()
    {
        MoveControl();
    }
}
