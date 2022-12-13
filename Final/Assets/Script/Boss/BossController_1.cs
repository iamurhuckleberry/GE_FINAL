using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController_1 : MonoBehaviour
{
    public enum BossState
    {
        normal,
        berserk
    }


    [SerializeField] float moveSpeed = 1f;
    [SerializeField] int bossHP;
    [SerializeField] int bossMaxHP = 500;
    public int damage = 1;
    GameObject player;
    public BossState bossState = BossState.normal;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        UpdateValue();
        Move();
    }

    public void RecieveDamage(int damage)
    {
        bossHP -= damage;
        if(bossHP <= bossMaxHP * 0.5f)
        {
            bossState = BossState.berserk;
        }
        else if(bossHP <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void UpdateValue()
    {
        if(bossState == BossState.normal)
        {
            this.moveSpeed = 1f;
            this.damage = 5;
        }
        else if(bossState == BossState.berserk)
        {
            this.moveSpeed = 3f;
            this.damage = 10;
        }
    }

    private void Move()
    {
        if (player != null)
        {
            Vector3 destination = player.transform.position;
            Vector3 source = transform.position;

            Vector3 direction = destination - source;

            direction.Normalize();
            transform.position += direction * Time.deltaTime * moveSpeed;

            float scaleX = 1;
            if (direction.x > 0)
            {
                scaleX = -1;
            }
            transform.localScale = new Vector3(scaleX * 1, 1, 1);
        }
    }
}
