using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool canSpawn;
    public float levelTime = 30f;
    public float Level1Time = 10f;
    public Timer TimeCounter;


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
        if(TimeCounter.timeStart >= Level1Time)
        {
            SceneManager.LoadScene("Lv2");
        }
        DontDestroyOnLoad(this.gameObject);

    }

    private void Update()
    {
        EndLevel();
    }

}
