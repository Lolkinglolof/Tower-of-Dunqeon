using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    int damage = 50;
    private void OnTriggerEnter(Collider other)
    {
        HitTarget(other);
    }
    virtual public void HitTarget(Collider other)
    {
        other.gameObject.GetComponent<Health>().OnTakeDamage(damage);
    }
}
