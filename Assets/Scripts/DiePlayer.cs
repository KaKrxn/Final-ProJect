using UnityEngine;
using UnityEngine.SceneManagement; // อย่าลืมเพิ่ม namespace นี้

public class DiePlayer : MonoBehaviour
{
    [SerializeField] private string sceneName; // เพิ่มตัวแปรสำหรับเก็บชื่อซีน

    public void ReloadScene()
    {
        // โหลดซีนปัจจุบันอีกครั้ง
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadSceneByName()
    {
        // โหลดซีนตามชื่อที่กำหนดในตัวแปร sceneName
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError("Scene name is not assigned in the Inspector!");
        }
    }
}