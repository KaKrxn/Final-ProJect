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
        movementController = new MovementController(rb);  // ���ҧ�Թ�ᵹ��ͧ MovementController
    }

    // Update is called once per frame
    void Update()
    {
        // �ӹǳ��ȷҧ�������͹��� (x)
        dirX = moveRight ? moveSpeed : -moveSpeed;

        // ���¡�� MovementController ���ͨѴ��á������͹���
        movementController.Move(dirX, false); // ��˹� jumpPressed �� false ��������ա�á��ⴴ� Slide

        // �Ǻ�����ȷҧ�������͹���
        if (transform.position.x > 47f)
            moveRight = false;
        if (transform.position.x < 44f)
            moveRight = true;
    }
}
