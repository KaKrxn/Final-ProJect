using UnityEngine;

public class MovementController
{
    private Rigidbody2D rb;
    private int jumpCount;
    private const int MaxJump = 2;
    private float speed = 2.5f;

    public bool IsJumping => jumpCount > 0;

    public MovementController(Rigidbody2D rigidbody)
    {
        rb = rigidbody;
        jumpCount = 0;
    }

    public void Move(float x, bool jumpPressed)
    {
        rb.velocity = new Vector2(x * speed, rb.velocity.y);

        if (jumpPressed && jumpCount < MaxJump)
        {
            jumpCount++;
            rb.velocity = new Vector2(rb.velocity.x, 5f);
        }
    }

    public void ResetJump()
    {
        jumpCount = 0;  // ÃÕà«çµ¨Ó¹Ç¹¡ÃÐâ´´
    }
}
