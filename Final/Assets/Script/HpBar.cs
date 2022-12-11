using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    public int playerHP;
    public int playerMaxHP;

    public Image[] heart;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    private void Update()
    {
        if(playerHP > playerMaxHP)
        {
            playerHP = playerMaxHP;
        }

        for(int i =0; i < heart.Length; i++)
        {
            if(i < playerHP)
            {
                heart[i].sprite = fullHeart;
            }
            else
            {
                heart[i].sprite = emptyHeart;
            }

            if(i<playerMaxHP)
            {
                heart[i].enabled = true;
            }
            else
            {
                heart[i].enabled = false;
            }
        }
    }
}
