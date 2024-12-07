using UnityEngine;

public class Slide : MonoBehaviour
{
    private MovementController movementController;
    private Rigidbody2D rb;
    private float dirX, moveSpeed = 1.5f;
    private bool moveRight = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movementController = new MovementController(rb);  // สร้างอินสแตนซ์ของ MovementController
    }

    // Update is called once per frame
    void Update()
    {
        // คำนวณทิศทางการเคลื่อนที่ (x)
        dirX = moveRight ? moveSpeed : -moveSpeed;

        // เรียกใช้ MovementController เพื่อจัดการการเคลื่อนที่
        movementController.Move(dirX, false); // กำหนด jumpPressed เป็น false เพราะไม่มีการกระโดดใน Slide

        // ควบคุมทิศทางการเคลื่อนที่
        if (transform.position.x > 47f)
            moveRight = false;
        if (transform.position.x < 44f)
            moveRight = true;
    }
}
