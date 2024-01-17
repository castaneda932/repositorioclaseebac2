using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bool4 : MonoBehaviour
{
    public Bool1 bool1;
    public Bool2 bool2;
    public bool variable4 = true;

    
    private void FixedUpdate()
    {
        if (bool1.variable1 || bool2.variable2)
        {
            Debug.Log("la variable es verdadera");
            Color c = Color.white;
            gameObject.GetComponent<MeshRenderer>().material.color = c;
            variable4 = true;
        }
        else
        {
            Debug.Log("la variable es falsa");
            Color c = Color.black;
            gameObject.GetComponent<MeshRenderer>().material.color = c;
            variable4 = false;
        }





    }
}
