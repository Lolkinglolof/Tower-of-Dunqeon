using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    protected virtual void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && animator.GetCurrentAnimatorStateInfo(0).IsName("New State"))
        {
            animator.SetTrigger("Attack");
        }
    }
}
