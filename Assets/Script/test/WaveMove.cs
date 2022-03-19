using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class WaveMove : MonoBehaviour
{
    [SerializeField] GameObject [] points;
    Sequence sequencemove;
    int i;
    private void Start()
    {
        DOTween.Init();
    }
    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            float rootatePosy = points[i+1].transform.localEulerAngles.y;
            Debug.Log(rootatePosy);
            sequencemove.Append(transform.DOMove(points[i].transform.position, 3f))
                .OnComplete(()=> Debug.Log("asdasd"));
           
            //sequence.Append(transform.DORotate(new Vector3(0, points[i + 1].transform.localEulerAngles.y, 0), 1f, RotateMode.FastBeyond360));
            i++;
        }
    }
}
