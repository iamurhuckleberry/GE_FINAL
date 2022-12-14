using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] public Player player;
    [SerializeField] TMP_Text CoinNumber;
    private void Update()
    {
        CoinNumber.text = "" + player.currentCoin;
    }
}
