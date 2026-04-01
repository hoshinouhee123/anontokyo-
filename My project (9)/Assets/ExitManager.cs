using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitManager : MonoBehaviour
{
    // 여기에 아까 만든 도움말 패널(HelpPanel)을 연결할 겁니다.
    public GameObject helpPanel;

    public void GameStart()
    {
        SceneManager.LoadScene("TitleScene");
    }

    // 도움말 켜기 함수 (버튼 누르면 실행)
    public void OpenHelp()
    {
        helpPanel.SetActive(true); // 팝업창을 보이게(true) 함
    }

    // 도움말 끄기 함수 (닫기 버튼 누르면 실행)
    public void CloseHelp()
    {
        helpPanel.SetActive(false); // 팝업창을 안 보이게(false) 함
    }
}