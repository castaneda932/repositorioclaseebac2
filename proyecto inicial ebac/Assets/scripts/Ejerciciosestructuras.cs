using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ejerciciosestructuras : MonoBehaviour
{

    List<int> miLista= new List<int>();
    List<int> ordenadosDescendente = new List<int>();


    void Start()
    {
        
        Arreglos();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void listaDeNumeros()
    {

        for (int i = 0; i < 50; i++)
        {
            miLista.Add(Random.Range(0, 50));
        }
        foreach (var numero in miLista)
        {
            Debug.Log(numero);
        }

        
    }
    void Arreglos()
    {
        for (int i = 0; i < 50; i++)
        {
            ordenadosDescendente.Add(i);
        }
        foreach (var numero in ordenadosDescendente)
        {
            Debug.Log(numero);
        }
        ordenadosDescendente.Reverse();
        foreach (var numero in ordenadosDescendente)
        {
            Debug.Log(numero);
        }
    }
    
    


}
