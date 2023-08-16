using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton_Script : MonoBehaviour
{
    public Button restartButton; // 게임의 결과를 표시해줄 Text Ui
    // Start is called before the first frame update
    public void OnClick_Retry() // '재도전' 버튼을 클릭하며 호출 되어질 함수
    {
        SceneManager.LoadScene(0);
    }

}
