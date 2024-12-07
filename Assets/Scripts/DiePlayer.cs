using UnityEngine;
using UnityEngine.SceneManagement; // ����������� namespace ���

public class DiePlayer : MonoBehaviour
{
    [SerializeField] private string sceneName; // �������������Ѻ�纪��ͫչ

    public void ReloadScene()
    {
        // ��Ŵ�չ�Ѩ�غѹ�ա����
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadSceneByName()
    {
        // ��Ŵ�չ������ͷ���˹�㹵���� sceneName
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