using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    protected float damage = 10, timer = 1f;
    private Animator animator;
    public GameObject Wep;

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
