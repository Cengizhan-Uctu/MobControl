using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyToweStatus : MonoBehaviour
{
    [SerializeField] int towerHelat;
    UIManager uıHealt;
    private void Start()
    {
        uıHealt = FindObjectOfType<UIManager>();
        uıHealt.TowerHealtText(towerHelat);
    }
    public void ToverHealtDecrease()
    {
        towerHelat -= 1;
        if (towerHelat < 0)
        {
            GameManager.Instance.GameWin();
            towerHelat = 0;

        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Kid"))
        {
            ToverHealtDecrease();
            uıHealt.TowerHealtText(towerHelat);
            Destroy(other.gameObject);
        }
    }
}
