using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    public static int playerIndex;
    void Start()
    {
        playerIndex = 0;
        DontDestroyOnLoad(this.gameObject);
    }

}
