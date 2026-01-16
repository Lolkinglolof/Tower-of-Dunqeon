using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    protected float damage = 10, timer = 1f;
    private Animator animator;
    public GameObject Wep;

<<<<<<< HEAD
    private void Start()
    {
        animator = GetComponent<Animator>();
        WeaponHitboxDeactivate();
    }
    protected virtual void OnCollisionStay(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Untagged"))
        {
            if (collision.gameObject.CompareTag("Player") && animator.GetCurrentAnimatorStateInfo(0).IsName("New State"))
            {
                animator.SetTrigger("Attack");
            }
=======
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
>>>>>>> e26e845b4e63a1452e72174e8e09b59d22849414
        }

    }
    public void WeaponHitboxDeactivate()
    {
        Wep.transform.GetChild(0).GetComponent<Collider>().enabled = false;
    }
    public void WeaponHitboxActivate()
    {
        Wep.transform.GetChild(0).GetComponent<Collider>().enabled = true;
    }
}
