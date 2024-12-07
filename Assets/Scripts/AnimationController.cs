using UnityEngine;

public class AnimationController
{
    private Animator animator;
    private float originalScaleX;

    public AnimationController(Animator anim, float scaleX)
    {
        animator = anim;
        originalScaleX = scaleX;
    }

    public void UpdateAnimation(float speed, bool isJumping)
    {
        animator.SetFloat("speed", Mathf.Abs(speed));
        animator.SetBool("jump", isJumping);
    }

    public void FlipDirection(float x, Transform transform)
    {
        if (x > 0)
        {
            transform.localScale = new Vector3(originalScaleX, transform.localScale.y, transform.localScale.z);
        }
        else if (x < 0)
        {
            transform.localScale = new Vector3(-originalScaleX, transform.localScale.y, transform.localScale.z);
        }
    }

    public void SetJumping(bool isJumping)
    {
        animator.SetBool("jump", isJumping);
    }
}
