using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KidMove : MonoBehaviour
{
   
    NavMeshAgent nawMesh;
    GameObject enemyTower;
    void Start()
    {
        nawMesh = GetComponent<NavMeshAgent>();
        enemyTower = GameObject.FindGameObjectWithTag("EnemyTower");
        nawMesh.SetDestination(enemyTower.transform.position);
    }
    

}
