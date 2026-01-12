using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestWeapon : Weapon
{
    // Start is called before the first frame update
    void Start()
    {
        damage = 20;
        targetTag = "enemy";
    }
}
