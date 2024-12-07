using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private string sceneName; // เพิ่มตัวแปรเพื่อเก็บชื่อซีน

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // ฟังก์ชันสำหรับโหลดซีนที่ระบุ
    public void LoadGame()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName); // โหลดซีนตามชื่อที่กำหนดใน Inspector
        }
        else
        {
            Debug.LogError("Scene name is not assigned!");
        }
    }
}

