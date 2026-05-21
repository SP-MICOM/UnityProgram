using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator animator;

    public void Die()
    {
        animator.SetTrigger("Die");
    }

    public void Attack()
    {
        animator.SetBool("Attack", !animator.GetBool("Attack"));
    }

    public void Walk()
    {
        animator.SetBool("Walk", !animator.GetBool("Walk"));
    }

    public void Idle()
    {
        animator.SetBool("Attack", false);
        animator.SetBool("Walk", false);
    }
}
