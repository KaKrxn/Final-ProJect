using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // เพิ่ม namespace นี้สำหรับ SceneManager

public class GAMECON2 : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName); // ใช้สำหรับเปลี่ยนซีน
    }

    public void ExitGame()
    {
        Debug.Log("Exiting Game...");
        Application.Quit(); // ใช้สำหรับออกจากเกม
    }
}