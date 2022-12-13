using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ExpBar : MonoBehaviour
{
    [SerializeField] Player Player;
    [SerializeField] Image ExpFiller;
    [SerializeField] int LevelText;
    [SerializeField] int maxExp;
    [SerializeField] int updateExp;
    void Start()
    {
        LevelText = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateUI()
    {
        
    }
}
