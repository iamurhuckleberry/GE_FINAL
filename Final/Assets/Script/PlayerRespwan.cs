using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespwan : MonoBehaviour
{
    [SerializeField] GameObject Player1;
    [SerializeField] GameObject Player2;
    public GameObject expBar;
    void Start()
    {
        expBar = GameObject.Find("ExpBar");

        if(PlayerSelect.playerIndex ==0)
        {
            Camera.main.GetComponent<PlayerCamera>().player = Player1;
            expBar.GetComponent<ExpBar>().player = Player1.GetComponent<Player>();
            Player1.SetActive(true);
            Player2.SetActive(false);
        }
        else if(PlayerSelect.playerIndex ==1)
        {
            Camera.main.GetComponent<PlayerCamera>().player = Player2;
            expBar.GetComponent<ExpBar>().player = Player2.GetComponent<Player>();
            Player1.SetActive(false);
            Player2.SetActive(true);
        }

       
    }

    
    void Update()
    {
        
    }
}
