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
            Destroy(collision.gameObject);
        }
        else if(collision.tag == "Boss")
        {
            collision.GetComponent<BossController_1>().RecieveDamage(10);
        }
    }
}
