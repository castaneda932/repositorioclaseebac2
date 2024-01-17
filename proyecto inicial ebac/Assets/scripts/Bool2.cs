using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bool2 : MonoBehaviour
{
    public bool variable2 = true;
   
    private void FixedUpdate()
    {
        
        if (variable2)
        {
            Debug.Log("la variable es verdadera");
            Color c = Color.white;
            gameObject.GetComponent<MeshRenderer>().material.color = c;
            variable2 = true;
        }
        else
        {
            Debug.Log("la variable es falsa");
            Color c = Color.black;
            gameObject.GetComponent<MeshRenderer>().material.color = c;
            variable2 = false;
        }

    }
}
