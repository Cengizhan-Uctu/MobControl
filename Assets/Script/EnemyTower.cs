using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTower : MonoBehaviour
{
    [SerializeField] GameObject Enemy;
    [SerializeField] float enemySpawnDelay;
    [SerializeField] int waveEnemyCount;
   
    private void Start()
    {
        
        StartCoroutine(SpawnEnemyKid());
    }
    IEnumerator SpawnEnemyKid()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(enemySpawnDelay);
        }

    }
    void Spawn()
    {
        for (int i = 0; i < waveEnemyCount; i++)
        {

            Instantiate(Enemy, transform.position, Quaternion.identity);
        }
    }
   

}
