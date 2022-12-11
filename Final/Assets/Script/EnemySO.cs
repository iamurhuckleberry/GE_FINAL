using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy")]
public class EnemySO : ScriptableObject
{
    public string enemyName;
    public int damage;
    public Sprite sprite;
    public RuntimeAnimatorController animatorController;
}
