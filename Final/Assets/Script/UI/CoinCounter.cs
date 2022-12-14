using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] public Player player;
    [SerializeField] TMP_Text CoinNumber;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<Player>();
        if (player)
        {
            Debug.Log("Before");
            CoinNumber.text = "" + player.currentCoin;
            Debug.Log("After");
        }
    }
}
