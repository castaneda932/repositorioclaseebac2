using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;
    // Start is called before the first frame update
    void Start()
    {

        x = 0;

        Debug.LogWarning("algo salio medianamente mal");
        Debug.LogError("algo salio muy mal");
    }

    // Update is called once per frame
    void Update()
    {
        x = x + 1;
        Debug.Log("x");
    }
}
