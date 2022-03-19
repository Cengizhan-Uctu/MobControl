using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GateMove : MonoBehaviour
{
    [SerializeField] float xPosBegan;
    [SerializeField] float speed;
    private void Start()
    {
        transform.DOLocalMoveX(xPosBegan, speed).SetLoops(-1,LoopType.Yoyo);
        
    }
}
