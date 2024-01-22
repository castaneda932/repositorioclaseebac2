using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ejerciciosestructuras : MonoBehaviour
{

    List<int> miLista= new List<int>();
    int[] enteros = { 1, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };
    List<int> ordenadosDescendente = new List<int>();


    void Start()
    {

        
        Arreglos();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void listaDeNumeros(int tamaño = 50, int rangoInf = 0, int rangoSup = 50)
    {

        for (int i = 0; i < tamaño; i++)
        {
            miLista.Add(Random.Range(rangoInf, rangoSup));
        }
        foreach (var numero in miLista)
        {
            Debug.Log(numero);
        }

        
    }
    void Arreglos()
    {
       for (int i = 0; i < enteros.Length; i++)
        {
            ordenadosDescendente.Add(i);
        }
       foreach(var numero in ordenadosDescendente)
        {
            Debug.Log(numero);
        }
       //reverse se usa para ordenar la lista previa de manera descendente
       ordenadosDescendente.Reverse();
       foreach (var numero in ordenadosDescendente)
        {
            Debug.Log(numero);
        }

       

        
    }

   
    
    


}
