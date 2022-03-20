using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;
public class EnemyKidMove : MonoBehaviour
{
    NavMeshAgent nawMesh;
    GameObject Playercannon;
   
    void Start()
    {
        transform.DOMoveZ(transform.position.z - 0.5f, 0.2f);
        nawMesh = GetComponent<NavMeshAgent>();
        Playercannon = GameObject.FindGameObjectWithTag("Player");
        nawMesh.SetDestination(Playercannon.transform.position);
    }
   
}
