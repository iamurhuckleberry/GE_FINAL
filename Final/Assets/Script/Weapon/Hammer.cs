using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : BaseWeapon
{
    [SerializeField] PolygonCollider2D polygonCollider2D;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
