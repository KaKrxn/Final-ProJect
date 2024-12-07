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

        // เพิ่มคะแนนและอัปเดตข้อความ
        scoreManager.AddScore();

        // เล่นเสียง
        audioManager.PlaySound();

        // ทำลาย GameObject หลังจากดีเลย์
        Destroy(gameObject, 0.5f);
    }
}