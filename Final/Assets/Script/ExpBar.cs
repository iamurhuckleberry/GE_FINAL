using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ExpBar : MonoBehaviour
{
    [SerializeField] public Player player;
    [SerializeField] Image foreground;
    [SerializeField] TMP_Text LevelText;

    private void Update()
    {
        LevelText.text = "" + player.currentLevel;
        float expRatio = (float)player.currentExp / player.expToLevel;
        foreground.transform.localScale = new Vector3(expRatio, 1, 1);
    }


}
