using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private GameObject player;
    public GameObject Weapon;
    [SerializeField] private float CDTime, CDRate, CDCurrent;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject;
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
}
