using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] BaseWeapon[] weapons;
    [SerializeField] GameObject DeathUI;
    
    [SerializeField] public int playerSpeed = 1;
    [SerializeField] public int playerAdDamage;
    [SerializeField] public int playerApDamage;
    HpBar hp;

    [SerializeField] internal int currentExp;
    [SerializeField] internal int expToLevel = 5;
    [SerializeField] internal int currentLevel = 1;

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
        if(hp.playerHP <= 0)
        {
            //Destroy(gameObject);
            DeathUI.SetActive(true);
        }
        else
        {
            hp.playerHP--;
        }
    }

    internal void AddEXP()
    {
        if (++currentExp >= expToLevel)
        {
            currentExp = 0;
            expToLevel += 10;
            currentLevel++;

            weapons[0].LevelUp();//Sword
            weapons[1].LevelUp();//Hammer
            weapons[2].LevelUp();//Dagger
        }
    }


    public void Add1Heart()
    {
        hp.playerHP += 1;
        hp.playerHP = hp.playerMaxHP;
    }

    public void Add2Heart()
    {
        hp.playerHP += 2;
        hp.playerHP = hp.playerMaxHP;
    }
}
