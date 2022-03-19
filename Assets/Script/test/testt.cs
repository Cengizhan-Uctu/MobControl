using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class testt : MonoBehaviour
{
    Sequence seki;
   [SerializeField] GameObject veri;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            seki.Append(transform.DOMove(veri.transform.position, 1)).OnComplete(()=> Debug.Log("sdasd"));
        }
    }
}
