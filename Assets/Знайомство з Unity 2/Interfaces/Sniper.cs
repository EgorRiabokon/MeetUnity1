using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : MonoBehaviour, IShootable, IDamageable<float>
{
    //The required method of the IShootable interface
    public void Shoot()
    {
        
    }

    //The required method of the IDamageable interface
    public void Damage(float damageTake)
    {
       
    }
}
