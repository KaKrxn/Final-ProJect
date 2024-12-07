using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private string sceneName; // ��������������纪��ͫչ

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // �ѧ��ѹ����Ѻ��Ŵ�չ����к�
    public void LoadGame()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName); // ��Ŵ�չ������ͷ���˹�� Inspector
        }
        else
        {
            Debug.LogError("Scene name is not assigned!");
        }
    }
}

