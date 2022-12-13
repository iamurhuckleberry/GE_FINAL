using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] int enemyHP;
    [SerializeField] int enemyMaxHP = 3;
    public int damage = 1;

    [SerializeField] GameObject coinPrefab;
    [SerializeField] GameObject dimondPrefab;
    [SerializeField] GameObject heal1Prefab;
    [SerializeField] GameObject healHalfPrefab;

    private float dropRate;

    public bool isTrackingPlayer = true;
    GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Start()
    {     
        enemyHP = enemyMaxHP;
    }

    private void Update()
    {
        if (player != null)
        {
            Vector3 destination = player.transform.position;
            Vector3 source = transform.position;

            Vector3 direction = destination - source;

            if (!isTrackingPlayer)
            {
                direction = new Vector3(1, 0, 0);
            }

            direction.Normalize();
            transform.position += direction * Time.deltaTime * moveSpeed;

            float scaleX = 1;
            if (direction.x > 0)
            {
                scaleX = -1;
            }
            transform.localScale = new Vector3(scaleX, 1, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player player = collision.GetComponent<Player>();
            player.ReceiveDamage();
            Debug.Log("Hit");
        }
    }

    internal void Drop()
    {
        Instantiate(coinPrefab, transform.position, Quaternion.identity);
        dropRate = UnityEngine.Random.Range(0, 1f);

        if (dropRate < 0.5)
        {
            Instantiate(dimondPrefab, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), Quaternion.identity);
        }
        else
        {
            if (this.CompareTag("EnemyT1"))
            {
                Instantiate(heal1Prefab, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), Quaternion.identity);
            }
            else if (this.CompareTag("EnemyT2"))
            {
                Instantiate(healHalfPrefab, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), Quaternion.identity);
            }
        }
    }




}
