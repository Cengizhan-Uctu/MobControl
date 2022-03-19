using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPassGate : MonoBehaviour
{
   
    GameObject[] gates;
    List<string> gatesNameList = new List<string>();

    private void Awake()
    {

        gates = GameObject.FindGameObjectsWithTag("Gate");

        for (int i = 0; i < gates.Length; i++)
        {
            gatesNameList.Add(gates[i].name);
          
        }

    }
   
    private void OnTriggerExit(Collider other)
    {
       
        if (gatesNameList.Contains(other.name) && other.CompareTag("Gate"))
        {
            for (int i =0; i<other.GetComponent<GateStatus>().multiplier-1;i++) 
            {
                GameObject newchlid = Instantiate(gameObject, transform.position, transform.rotation);
                newchlid.GetComponent<CheckPassGate>().listdegress(other.name);
                listdegress(other.name);
            }
            
        }
    }
    public void listdegress(string name)
    {
        gatesNameList.Remove(name);

    }
}
