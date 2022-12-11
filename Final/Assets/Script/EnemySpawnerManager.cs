using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerManager : MonoBehaviour
{
    [SerializeField] private EnemySO[] enemyDatabase = new EnemySO[5];
    [SerializeField] private GameObject enemyPrefab;

    private void Start()
    {
        StartCoroutine(WaitAndSpawn());
    }

    private IEnumerator WaitAndSpawn()
    {
        while (GameManager.instance.canSpawn)
        {
            yield return new WaitForSeconds(1f);
            SpawnEnemy(new Vector3(1, 1, 0));
        }
    }

    private void SpawnEnemy(Vector3 spawnPosition)
    {
        EnemySO enemyData = enemyDatabase[Random.Range(0, enemyDatabase.Length - 1)];
        GameObject enemyClone = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity, this.transform);
        enemyClone.GetComponent<Animator>().runtimeAnimatorController = enemyData.animatorController;
        enemyClone.GetComponent<EnemyController>().damage = enemyData.damage;
    }
}