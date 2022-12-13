using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwap : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject weaponPlayer1;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            if (GameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        weaponPlayer1.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }

    public void Pause()
    {
        weaponPlayer1.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }
    public void unfreeze()
    {
        Debug.Log("unfreeze");
        Time.timeScale = 1f;
    }
}
