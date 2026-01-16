using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ETWeapon : Weapon
{
    // Start is called before the first frame update
    void Start()
    {
        damage = 5;
        targetTag = "player";
    }
}
