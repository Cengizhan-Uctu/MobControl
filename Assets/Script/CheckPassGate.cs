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

      
        for (int i = 0; i < gates.Length - 1; i++)
        {
            gatesNameList.Add(gates[i].name);
        }

    }
    public void listdegress(string name)
    {
        gatesNameList.Remove(name);

    }
    private void OnTriggerExit(Collider other)
    {
      
        if (gatesNameList.Contains(other.name) && other.CompareTag("Gate"))
        {
          
            GameObject newchlid = Instantiate(gameObject, transform.position, Quaternion.identity);
            newchlid.GetComponent<CheckPassGate>().listdegress(other.name);
        }
    }
}
