using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GateStatus : MonoBehaviour
{
    public int multiplier;
    [SerializeField] Text multiplierText;
    private void Start()
    {
        multiplierText.text = multiplier.ToString()+"X";
    }
}
