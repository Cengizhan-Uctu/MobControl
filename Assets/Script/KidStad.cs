using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KidStad : MonoBehaviour
{
    [SerializeField] int KidHealt = 100;
    public bool IsPassDor;
    public void KidHealtDecrease()
    {
        if (KidHealt <= 0)
        {
            Destroy(gameObject);
        }
        KidHealt -= 50;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyKid"))
        {
            KidHealtDecrease();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        
        if (other.CompareTag("Gate") && IsPassDor)
        {
            for (int i = 0; i < 2; i++)
            {

                GameObject child = Instantiate(gameObject, transform.position, Quaternion.identity);
                child.GetComponent<KidStad>().IsPassDor = false;

            }
            IsPassDor = false;
        }
    }
}
