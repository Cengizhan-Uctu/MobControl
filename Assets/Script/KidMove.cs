using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;

public class KidMove : MonoBehaviour
{
   
    NavMeshAgent nawMesh;
    GameObject enemyTower;
    void Start()
    {
        transform.DOMoveZ(transform.position.z + 0.5f, 0.2f);
        nawMesh = GetComponent<NavMeshAgent>();
        enemyTower = GameObject.FindGameObjectWithTag("EnemyTower");
        nawMesh.SetDestination(enemyTower.transform.position);
    }
    

}
