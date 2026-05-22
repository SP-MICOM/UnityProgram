using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator animator;
    public AnimatorStateInfo animatorStateInfo;

    public void Die()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (animator.IsInTransition(0) || animatorStateInfo.IsName("Die"))
        {
            return;
        }

        animator.SetTrigger("Die");
    }

    public void Attack()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if(animatorStateInfo.IsName("Walk"))
        {
            animator.SetBool("Walk", false);
        }
        else if(animatorStateInfo.IsName("Idle"))
        {
            animator.SetBool("Idle", false);
        }
        else
        {
            animator.SetBool("Idle", true);
        }

        animator.SetBool("Attack", !animator.GetBool("Attack"));
    }

    public void Walk()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if(animatorStateInfo.IsName("Attack"))
        {
            animator.SetBool("Attack", false);
        }
        else if(animatorStateInfo.IsName("Idle"))
        {
            animator.SetBool("Idle", false);
        }
        else
        {
            animator.SetBool("Idle", true);
        }

        animator.SetBool("Walk", !animator.GetBool("Walk"));
    }

    public void Idle()
    {
        animator.SetBool("Idle", true);
        animator.SetBool("Attack", false);
        animator.SetBool("Walk", false);
    }
}
