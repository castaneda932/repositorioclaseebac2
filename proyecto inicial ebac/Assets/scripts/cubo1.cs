
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo1 : MonoBehaviour
{
    public GameObject GameObject;

    private void Awake()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        gameObject.GetComponent<MeshRenderer>().material.color = c;
    }

    bool variable1;
    bool variable2;
    bool variable3;
    
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void FixedUpdate()
    {
        variable1 = true;
        variable2 = false;

        if (variable1 && variable2)
        {
            Debug.Log("la variable es verdadera");
            Color c = Color.white;
            gameObject.GetComponent<MeshRenderer>().material.color = c;
        }
        else
        {
            Debug.Log("la variable es falsa");
            Color c = Color.black;
            gameObject.GetComponent<MeshRenderer>().material.color = c;

        }
         
        
        


    }
}
