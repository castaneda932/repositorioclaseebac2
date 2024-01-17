using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class update : MonoBehaviour
{

    public GameObject prefabs;
    public int numCubos = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;
        Instantiate(prefabs, transform.position, transform.rotation);
    }
}
