using UnityEngine;

public class ItemController : MonoBehaviour
{
    private ColliderHandler colliderHandler;
    private ScoreManager scoreManager;
    private AudioManager audioManager;

    void Start()
    {
        colliderHandler = new ColliderHandler(gameObject);
        scoreManager = new ScoreManager();
        audioManager = new AudioManager(GetComponent<AudioSource>());
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!scoreManager.IsScoreTextAssigned())
        {
            Debug.LogError("Score Text is not assigned in the Inspector!");
            return;
        }

        // ������ṹ����ѻവ��ͤ���
        scoreManager.AddScore();

        // ������§
        audioManager.PlaySound();

        // ����� GameObject ��ѧ�ҡ������
        Destroy(gameObject, 0.5f);
    }
}