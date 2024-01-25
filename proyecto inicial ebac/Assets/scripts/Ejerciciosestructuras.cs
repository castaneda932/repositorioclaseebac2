using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Ejerciciosestructuras : MonoBehaviour
{

    List<int> miLista= new List<int>();
    int[] enteros = { 14, 32, 56, 19, 12, 85, 8, 21, 52, 27, 31 };
    int[] EnterosOrdenados;
    List<int> listaNumeros = new List<int> { 1, 2, 3, 4, 5, 2, 3, 6, 7, 8, 1 };
    HashSet<int> listaSinRepetidos;
    Stack<string> pila = new Stack<string>();
    Queue<string> cola = new Queue<string>();




    void Start()
    {
        //esto es para llamar a consola el arreglo de enteros de la funcion arreglos
        EnterosOrdenados = Arreglos(enteros);
        foreach (int entero in EnterosOrdenados) 
        {
         Debug.Log(entero);
        }
        //esto es para llamar a consola el hashet sin duplicados
        listaSinRepetidos = CreaHashSetSinDuplicados(listaNumeros);
        foreach (int entero in listaSinRepetidos)
        {
            Debug.Log(entero);
        }

        ListaDeStrings();
        
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
    int[] Arreglos(int[] arregloDeEnteros)
    {
        //esta es la manera de ordenar una lista array de manera descendente
        int[] arregloDeEnterosOrdenados = arregloDeEnteros.OrderByDescending(enteros => enteros).ToArray();

        return arregloDeEnterosOrdenados;    
    }
    //funcion para crear un hashet
    HashSet<T> CreaHashSetSinDuplicados<T>(List<T> inputList)
    {
        // Utilizando LINQ para eliminar duplicados y crear un HashSet
        return new HashSet<T>(inputList.Distinct());

    }
    void ListaDeStrings() 
    {
        pila.Push("Uno");
        pila.Push("Dos");
        pila.Push("Tres");
        Debug.Log(pila.Peek());
        pila.Pop();
        Debug.Log(pila.Peek());
        pila.Pop();
        Debug.Log(pila.Peek());
        pila.Pop();

        cola.Enqueue("Uno");
        cola.Enqueue("Dos");
        cola.Enqueue("Tres");
        Debug.Log(cola.Peek());
        cola.Dequeue();
        Debug.Log(cola.Peek());
        cola.Dequeue();
        Debug.Log(cola.Peek());
        cola.Dequeue();




    }
    









}









 