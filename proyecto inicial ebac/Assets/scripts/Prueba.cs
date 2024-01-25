using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackExample : MonoBehaviour
{
    void Start()
    {
        // Ejemplo de uso:
        Stack<string> miPila = new Stack<string>();
        miPila.Push("Elemento 1");
        miPila.Push("Elemento 2");
        miPila.Push("Elemento 3");

        ProcesarPilaDeStrings(miPila);
    }

    // Funci�n que recibe una pila de strings y realiza alguna operaci�n
    void ProcesarPilaDeStrings(Stack<string> pila)
    {
        Debug.Log("Contenidos de la Pila:");

        // Iterar a trav�s de la pila sin modificarla
        foreach (string elemento in pila)
        {
            Debug.Log(elemento);
        }

        // Puedes realizar otras operaciones con la pila aqu�

        // Ejemplo: Imprimir el elemento en la cima de la pila sin quitarlo
        if (pila.Count > 0)
        {
            string elementoEnLaCima = pila.Peek();
            Debug.Log($"Elemento en la cima de la Pila: {elementoEnLaCima}");
        }
    }
}

