using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // ���� namespace �������Ѻ SceneManager

public class GAMECON2 : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName); // ������Ѻ����¹�չ
    }

    public void ExitGame()
    {
        Debug.Log("Exiting Game...");
        Application.Quit(); // ������Ѻ�͡�ҡ��
    }
}