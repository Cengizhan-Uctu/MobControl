using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class WaveWall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.SetParent(gameObject.transform);
            other.transform.DORotate(new Vector3(0, transform.rotation.y, 0), 0.2f, RotateMode.FastBeyond360);
        }
       
    }
}
