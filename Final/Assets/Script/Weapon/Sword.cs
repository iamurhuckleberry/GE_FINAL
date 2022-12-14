using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : BaseWeapon
{
    [SerializeField] PolygonCollider2D polygonCollider2D;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            collision.GetComponent<EnemyController>().TakeDamage(1);
        }
        else if(collision.tag == "Boss")
        {
            collision.GetComponent<BossController_1>().RecieveDamage(10);
        }
    }
}
