using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buff : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] public int AddHp;
    [SerializeField] public int AddAdDamage;
    [SerializeField] public int AddApDamage;
    [SerializeField] public int AddMoveSpeed;
    [SerializeField] public int CoinCost;

    public void IncreaseHp()
    {
        Player.GetComponent<HpBar>().playerMaxHP += AddHp;
        Destroy(this.gameObject);
    }

    public void IncreaseAD()
    {
        Player.GetComponent<Player>().playerAdDamage += AddAdDamage;
        Destroy(this.gameObject);
    }

    public void IncreastAP()
    {
        Player.GetComponent<Player>().playerApDamage += AddApDamage;
        Destroy(this.gameObject);
    }

    public void IncreaseMoveSpeed()
    {
        Player.GetComponent<Player>().playerSpeed += AddMoveSpeed;
        Destroy(this.gameObject);
    }

    public void SpendCoin()
    {

    }
}
