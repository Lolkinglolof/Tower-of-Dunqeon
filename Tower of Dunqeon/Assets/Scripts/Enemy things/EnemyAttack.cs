using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    protected float damage = 10, timer = 1f;
    private Animator animator;

    protected virtual void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && timer < 0)
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
            timer = 0.5f;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
