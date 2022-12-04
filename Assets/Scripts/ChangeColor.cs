using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Color TargetColor;
    public Material mat1;
    public Material mat2; 

    void OnTriggerEnter(Collider col)
    {
        if(col.name == "LeftHandAnchor" || col.name == "RightHandAnchor")
        {
            gameObject.GetComponent<Renderer>().material = mat1;
        }
    }


    private void OnTriggerExit(Collider col)
    {
        if (col.name == "LeftHandAnchor" || col.name == "RightHandAnchor")
        {
            gameObject.GetComponent<Renderer>().material = mat2;
        }
    }
}
