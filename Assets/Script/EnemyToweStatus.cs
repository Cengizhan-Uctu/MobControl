using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyToweStatus : MonoBehaviour
{
    [SerializeField] float towerHelat;
    public void ToverHealtDecrease()
    {
        if (towerHelat <= 0)
        {
            Destroy(gameObject);
        }
        towerHelat -= 1;
    }
}
