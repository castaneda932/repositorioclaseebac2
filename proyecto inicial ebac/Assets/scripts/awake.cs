using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awake : MonoBehaviour
{
    public GameObject prefabs;

    private void Awake()
    {
        Instantiate(prefabs, transform.position, transform.rotation);
            

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
