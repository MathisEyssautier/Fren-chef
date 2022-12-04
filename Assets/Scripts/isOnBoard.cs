using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isOnBoard : MonoBehaviour
{
    public bool isOn = false;

    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "Meat")
        {
            isOn = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.name == "Meat")
        {
            isOn = false;
        }
    }
}
