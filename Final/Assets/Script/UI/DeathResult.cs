using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathResult : MonoBehaviour
{
    [SerializeField] TMP_Text CoinResult;
    [SerializeField] TMP_Text ExpResult;
    public Player player;
    void Update()
    {
        CoinResult.text = player.currentCoin.ToString();
        ExpResult.text = player.currentLevel.ToString();
    }
}
