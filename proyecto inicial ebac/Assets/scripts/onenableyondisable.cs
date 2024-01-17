using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onenableyondisable : MonoBehaviour
{
    public GameObject prefabs;

    private void OnEnable()
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


    private void OnDisable()
    {
        
        Instantiate(prefabs, transform.position, transform.rotation);
    }
}
