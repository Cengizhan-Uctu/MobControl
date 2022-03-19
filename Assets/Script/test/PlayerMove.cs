using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class PlayerMove : MonoBehaviour
{
    [SerializeField] GameObject[] trasformNewPoint;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.DOMove(trasformNewPoint[2].transform.position, 2);
        }
    }
}
