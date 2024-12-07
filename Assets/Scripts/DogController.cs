using UnityEngine;
using UnityEngine.SceneManagement; // ต้องมีการใช้งาน SceneManager

public class DogController : MonoBehaviour
{
    private MovementController movement;
    private AnimationController animationController;

    void Start()
    {
        movement = new MovementController(GetComponent<Rigidbody2D>());
        animationController = new AnimationController(GetComponent<Animator>(), transform.localScale.x);
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        bool jumpPressed = Input.GetButtonDown("Jump");

        // อัปเดตการเคลื่อนไหว
        movement.Move(x, jumpPressed);

        // อัปเดตแอนิเมชัน
        animationController.UpdateAnimation(x, movement.IsJumping);
        animationController.FlipDirection(x, transform);
    }

    // ฟังก์ชันที่ใช้เมื่อเกิดการชนกับ Object
    void OnCollisionEnter2D(Collision2D coll)
    {
        // ตรวจสอบว่าตัวละครชนกับ "ต้นไม้" หรือวัตถุที่กำหนด
        if (coll.gameObject.CompareTag("Tree")) // เปลี่ยน "Tree" เป็นแท็กของต้นไม้
        {
            // เมื่อชนกับต้นไม้ ให้โหลดซีนใหม่
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // รีโหลดซีนปัจจุบัน
            Debug.Log("You hit the tree! Reloading scene...");
        }

        movement.ResetJump();
        animationController.SetJumping(false);
    }
}

