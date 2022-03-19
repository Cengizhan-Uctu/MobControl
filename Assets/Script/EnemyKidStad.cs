using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKidStad : MonoBehaviour
{
    [SerializeField] int EnemyKidHelad=100;

    public void EnemyHealtDecrease()
    {
        if (EnemyKidHelad < 0)
        {
            Destroy(gameObject);
        }
        EnemyKidHelad -= 50;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Kid"))
        {
            EnemyHealtDecrease();
        }
    }
   
}
