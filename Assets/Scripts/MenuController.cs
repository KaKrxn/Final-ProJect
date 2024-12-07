using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // ��ͧ������÷Ѵ�������Ѻ SceneManager

public class MenuController : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit(); // ������Ѻ�͡�ҡ��
    }
}