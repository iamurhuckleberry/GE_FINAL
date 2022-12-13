using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dimond : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<Player>();
        if (player)
        {
            player.AddEXP();
            Destroy(gameObject);
        }
    }
}
