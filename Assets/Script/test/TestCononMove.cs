using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class TestCononMove : MonoBehaviour
{
    [SerializeField] GameObject[] RoadTransform;
    Sequence sequence;
    int i;

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
            CannonMove(i);
        }
        
    }
    void CannonMove(int i)
    {
        if (i < RoadTransform.Length - 1)
        {
            float rotateY = RoadTransform[i + 1].transform.localEulerAngles.y;
            sequence.Append(transform.DOMove(RoadTransform[i].transform.position, 3)
            .OnComplete(() => transform.DOLocalRotate(new Vector3(0, rotateY, 0), 0.3f, RotateMode.FastBeyond360)));

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        // dotween OnComplete de bagzi hatalar 
        if (other.CompareTag("Point"))
        {
            i++;
            sequence.Append(transform.DOMove(RoadTransform[i].transform.position, 3).OnComplete(()=>Debug.Log("sdasd")));
            i++;

        }
        if (other.CompareTag("Base"))
        {
            transform.SetParent(other.transform);
        }
    }
}
