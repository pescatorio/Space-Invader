using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter_Missile_Fire : MonoBehaviour
{
    public GameObject PlayerMissile; //복제할 미사일 오브젝트
    public Transform MissileLocation; //미사일 발사위치
    public float FireDelay; //미사일 발사속도
    private bool FireState; //미사일 발사속도 제어변수


    public int MissileMaxPool; //메모리 풀에 저장할 미사일 개수
    private MemoryPool MPool; //메모리 풀
    private GameObject[] MissileArray; //메모리 풀과 연동할 미사일 배열

    //게임 종료시 자동 호출되는 함수
    private void OnApplicationQuit()
    {
        //메모리 풀을 비움.
        MPool.Dispose();
    }
    // Start is called before the first frame update
    void Start()
    {
        FireState = true;

        //메모리 풀 초기화
        MPool = new MemoryPool();
        //PlayerMissile을 MissileMaxPool만큼 생성
        MPool.Create(PlayerMissile, MissileMaxPool);
        //배열도 초기화(모든 값은 null)
        MissileArray = new GameObject[MissileMaxPool];
    }

    // Update is called once per frame
    void Update()
    {
        //프레임마다 미사일 함수를 체크
        playerFire();
    }
    private void playerFire()
    {
        //제어변수가 true라면
        if (FireState)
        {
            if (Input.GetKey(KeyCode.A))
            {
                //코루틴 FireCycleControl이 실행되며
                StartCoroutine(FireCycleControl());
                //PlayerMissile을 MissleLocation의 위치에 MissileLocaion 방향으로 복제
                for (int i = 0; i < MissileMaxPool; i++)
                {
                    if (MissileArray[i] == null)
                    {
                        //Instantiate(PlayerMissile, MissileLocation.position, MissileLocation.rotation);
                        //메모리풀에서 미사일을 가져온다.
                        MissileArray[i] = MPool.NewItem();
                        //해당 미사일의 위치를 미사일 발사지접으로 맞춘다.
                        MissileArray[i].transform.position = MissileLocation.transform.position;
                        //발사 후에 for문을 바로 빠져나간다.
                        break;
                    }
                }
            }
        }

        //미사일이 발사될때마다 미사일을 메모리풀로 돌려보내는 것을 체크
        for(int i= 0;i < MissileMaxPool; i++)
        {
            if (MissileArray[i])
            {
                //미사일[i]의 Collider2D가 비활성 되었다면
                if (MissileArray[i].GetComponent<Collider2D>().enabled == false)
                {
                    //활성화
                    MissileArray[i].GetComponent<Collider2D>().enabled = true;
                    //미사일을 메모리로 돌려보냄
                    MPool.RemoveItem(MissileArray[i]);
                    //가리키는 배열의 해당 항목도 null처리
                    MissileArray[i] = null;
                }
            }
        }
    }

    //코루틴 함수. 일반 메서드와 달리 메인 메서드가 진행되는 동시에 진행되며 return을 만나지 않더라도 내부의 코드가 모두 실행되면 기본 스레드로 돌아감
    IEnumerator FireCycleControl()
    {
        //처음에 FireState를 false로 만듦
        FireState = false;
        //FireDelay초 후에
        yield return new WaitForSeconds(FireDelay);
        //FireState를 true로 만든다.
        FireState = true;
    }
}
