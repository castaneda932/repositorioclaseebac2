using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crearcubodesdecero : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject objToSpawn;
    Vector3[] vertices = {
        new Vector3(0,0,0), //vertice0
        new Vector3(1,0,0), //vertice1
        new Vector3(1,1,0), //vertice2
        new Vector3(0,1,0), //vertice3
        new Vector3(0,1,1), //vertice4
        new Vector3(1,1,1), //vertice5
        new Vector3(1,0,1), //vertice6
        new Vector3(0,0,1), //vertice7
        };

    int[] triangulos = {
        0, 2, 1, //Cara 1
        0, 3, 2,
        2, 3, 4, //Cara 2
        2, 4, 5,
        1, 2, 5, //Cara 3
        1, 5, 6,
        0, 7, 4, //Cara 4
        0, 4, 3,
        0, 4, 7, //Cara 5
        5, 7, 6,
        0, 6, 7, //Cara 6
        0, 1, 6,
        };


    void Start()
    {
        objToSpawn = new GameObject("nuestro primer cubo");
        objToSpawn.AddComponent<MeshFilter>();
        var mesFilther = objToSpawn.GetComponent<MeshFilter>().mesh;
        mesFilther.Clear();
        mesFilther.vertices = vertices;
        mesFilther.triangles = triangulos;
        mesFilther.Optimize();
        mesFilther.RecalculateNormals();
        objToSpawn.AddComponent<BoxCollider>();
        var boxCollider = objToSpawn.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        objToSpawn.AddComponent<MeshRenderer>();
        var meshRendererMaterial = objToSpawn.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = Color.white;
        objToSpawn.transform.position = Vector3.one;







    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
