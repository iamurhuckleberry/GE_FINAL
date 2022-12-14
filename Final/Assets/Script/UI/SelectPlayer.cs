using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPlayer : MonoBehaviour
{
    public void SelectPlayer1()
    {
        PlayerSelect.playerIndex = 0;
    }

    public void SelectPlayer2()
    {
        PlayerSelect.playerIndex = 1;
    }


}
