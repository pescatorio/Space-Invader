using UnityEngine;

public class soundManager : MonoBehaviour
{
    public AudioClip fighterExplosionSoundClip;
    public AudioClip enemyExplosionsSoundClip; //재생할 소리를 변수로 담습니다.
    public AudioClip fighterColisionSoundClip;
    AudioSource soundEffectSource; //AudioSorce 컴포넌트를 변수로 담습니다.
    public static soundManager instance;  //자기자신을 변수로 담습니다.
    void Awake() //Start보다도 먼저, 객체가 생성될때 호출됩니다
    {
        if (soundManager.instance == null) //incetance가 비어있는지 검사합니다.
        {
            soundManager.instance = this; //자기자신을 담습니다.
        }
    }
    void Start()
    {
        if (soundEffectSource == null)
        {
            soundEffectSource = this.GetComponent<AudioSource>();  //AudioSource 오브젝트를 변수로 담습니다.
        }
    }
    public void PlayEnemyExplosionSound()
    {
        soundEffectSource.PlayOneShot(enemyExplosionsSoundClip); //효과음을 재생합니다.
    }
    public void PlayFighterExplosionSound()
    {
        soundEffectSource.PlayOneShot(fighterExplosionSoundClip); //효과음을 재생합니다.
    }
    public void PlayFighterColisionSound()
    {
        soundEffectSource.PlayOneShot(fighterColisionSoundClip); //효과음을 재생합니다.
    }
    void Update()
    {

    }
}