using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespwan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Instantiate(GameManager.CurrentPlayer, new Vector3(0,0,0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
