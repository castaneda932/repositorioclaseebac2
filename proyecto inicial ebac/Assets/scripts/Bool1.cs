using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bool1 : MonoBehaviour
{

    public bool variable1;

    private void FixedUpdate()
    {
      
        if (variable1)
        {
            Debug.Log("la variable es verdadera");
            Color c = Color.white;
            gameObject.GetComponent<MeshRenderer>().material.color = c;
            variable1 = true;
        }
        else
        {
            Debug.Log("la variable es falsa");
            Color c = Color.black;
            gameObject.GetComponent<MeshRenderer>().material.color = c;
            variable1 = false;
        }    




    }
}
