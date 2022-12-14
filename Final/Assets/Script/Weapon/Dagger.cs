using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dagger : BaseWeapon
{
    public int damge = 2;
    public float speed = 20f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyController enmey = hitInfo.GetComponent<EnemyController>();
        if (enmey != null)
        {
            enmey.TakeDamage(damge);
        }
        Destroy(gameObject);
    }
}
