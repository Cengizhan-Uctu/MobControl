using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CannonShot : MonoBehaviour
{
    public static bool isSoting;
    [SerializeField] GameObject bigBrother;
    [SerializeField] GameObject gunBarrel;
    [SerializeField] GameObject kid;
    [SerializeField] float shotDelay;
    int bigBrotherCarge;
    UIManager uıCahrge;

    private void Awake()
    {
        uıCahrge = FindObjectOfType<UIManager>();
    }
   
   public void Soting()
    {
        Instantiate(kid, gunBarrel.transform.position, Quaternion.identity);
        bigBrotherCarge++;
        uıCahrge.BigBrotherSiliderChange(bigBrotherCarge);
    }
   
    public void SpawnBigBrother()
    {
        if (bigBrotherCarge >= 10)
        {
            Instantiate(bigBrother, gunBarrel.transform.position, Quaternion.identity);
            bigBrotherCarge = 0;
            uıCahrge.BigBrotherSiliderChange(bigBrotherCarge);
        }
    }
  
}
