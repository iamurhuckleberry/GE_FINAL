using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] BaseWeapon[] weapons;
    
    [SerializeField] public int playerSpeed = 1;
    [SerializeField] public int playerAdDamage;
    [SerializeField] public int playerApDamage;
    HpBar hp;

    private void Awake()
    {
        hp = GetComponent<HpBar>();
    }
    private void Start()
    {
        weapons[0].LevelUp();
        hp.playerHP = hp.playerMaxHP;
    }


    private void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        transform.position += new Vector3(inputX, inputY, 0) * playerSpeed * Time.deltaTime;

        if (inputX != 0)
        {
            transform.localScale = new Vector3(inputX > 0 ? -1 : 1, 1, 1);
        }

        animator.SetBool("IsRunning", inputX != 0 || inputY != 0);

        //Combat
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            Attack();
        }

    }
    public void Attack()
    {
        animator.SetTrigger("Attack");
    }

    public void ReceiveDamage()
    {       
        if(hp.playerHP < 0)
        {
            //Destroy(gameObject);
        }
        else
        {
            hp.playerHP--;
        }
    }
}
