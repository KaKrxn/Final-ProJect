using UnityEngine;
using UnityEngine.SceneManagement; // ��ͧ�ա����ҹ SceneManager

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

        // �ѻവ�������͹���
        movement.Move(x, jumpPressed);

        // �ѻവ�͹����ѹ
        animationController.UpdateAnimation(x, movement.IsJumping);
        animationController.FlipDirection(x, transform);
    }

    // �ѧ��ѹ�����������Դ��ê��Ѻ Object
    void OnCollisionEnter2D(Collision2D coll)
    {
        // ��Ǩ�ͺ��ҵ���Фê��Ѻ "�����" �����ѵ�ط���˹�
        if (coll.gameObject.CompareTag("Tree")) // ����¹ "Tree" ���硢ͧ�����
        {
            // ����ͪ��Ѻ����� �����Ŵ�չ����
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // ����Ŵ�չ�Ѩ�غѹ
            Debug.Log("You hit the tree! Reloading scene...");
        }

        movement.ResetJump();
        animationController.SetJumping(false);
    }
}

