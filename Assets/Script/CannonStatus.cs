using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonStatus : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyKid"))
        {
            GameManager.Instance.GameOver();
        }
    }
}
