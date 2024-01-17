using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bool5 : MonoBehaviour
{

    public Bool3 bool3;
    public Bool4 bool4;
    public bool variable5;


    private void FixedUpdate()
    {
        if (bool3.variable3 && bool4.variable4)
        {
            Debug.Log("la variable es verdadera");
            Color c = Color.white;
            gameObject.GetComponent<MeshRenderer>().material.color = c;
            variable5 = true;
        }
        else
        {
            Debug.Log("la variable es falsa");
            Color c = Color.black;
            gameObject.GetComponent<MeshRenderer>().material.color = c;
            variable5 = false;
        }



    }
}
