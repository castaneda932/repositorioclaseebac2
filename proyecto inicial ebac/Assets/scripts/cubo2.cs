using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo2 : MonoBehaviour
{
    public GameObject GameObject;

    bool variable1;
    bool variable2;
    bool variable3;


    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        variable2 = false;
        if (variable1 || variable2) Debug.Log("la operacion dio verdadero");
        

    }

    // Update is called once per frame
    void Update()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        gameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
