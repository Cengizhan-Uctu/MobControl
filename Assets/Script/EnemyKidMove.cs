using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyKidMove : MonoBehaviour
{
    NavMeshAgent nawMesh;
    GameObject Playercannon;
   
    void Start()
    {
        nawMesh = GetComponent<NavMeshAgent>();
        Playercannon = GameObject.FindGameObjectWithTag("Player");
        nawMesh.SetDestination(Playercannon.transform.position);
    }
   
}
