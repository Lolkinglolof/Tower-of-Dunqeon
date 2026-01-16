using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject Weapon;
    [SerializeField] private float CDTime, CDRate, CDCurrent;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CDCurrent += CDRate * Time.deltaTime;
        if (CDCurrent > CDTime)
        {
            CDCurrent = CDTime;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && CDCurrent == CDTime)
        {
            TestAttack();
        }
    }
    void TestAttack()
    {
        animator.SetTrigger("Attack");
    }
    void ChangeWeapon(GameObject newWeapon)
    {
        if (Weapon != null)
        {
            Weapon.SetActive(false);
        }
        Weapon = newWeapon;
        WeaponHitboxDeactivate();
    }
    public void WeaponHitboxDeactivate()
    {
        Weapon.transform.GetChild(0).GetComponent<Collider>().enabled = false;
    }
    public void WeaponHitboxActivate()
    {
        Weapon.transform.GetChild(0).GetComponent<Collider>().enabled = true;
        Weapon.transform.GetChild(0).GetComponent<Weapon>().targets.Clear();
    }
}
