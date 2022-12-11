using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool canSpawn;
    public float levelTime = 30f;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    private IEnumerator LevelTimer()
    {
        yield return new WaitForSeconds(levelTime);
        //spawn level boss here
    }

    public void EndLevel()
    {
        //end current level
        //show result panel
        //go next level

    }
}
