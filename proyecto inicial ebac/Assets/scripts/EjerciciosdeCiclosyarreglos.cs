using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosdeCiclosyarreglos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //parte1
        {
            int[] arr1 = new int[10]; 
            int[] arr2 = new int[10]; 
            int[] arr3 = new int[10]; 

            
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = Random.Range(1, 25); 
                arr2[i] = Random.Range(1, 25);
            }

            
            for (int i = 0; i < 10; i++)
            {
                arr3[i] = arr1[i] + arr2[i];
            }

            
            Debug.Log("arr1: " + string.Join(", ", arr1));
            Debug.Log("arr2: " + string.Join(", ", arr2));
            Debug.Log("arr3: " + string.Join(", ", arr3));
        }


        //parte2

        string[] palabras = new string[]
        {
            "Esto", "es", "muy", "complicado", "de", "hacer"
        };

        string oracionCompleta = "";

        foreach (string palabra in palabras)
        {
            oracionCompleta += palabra + " ";
        }
        Debug.Log(oracionCompleta);




        //parte3

        int[,] arregloBidimensional = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

         
        int[] arregloUnidimensional = new int[2] { 7, 8 };

        
      
        
        int[,] resultado = MultiplicarMatrices(arregloBidimensional, arregloUnidimensional);

        
        Debug.Log("Resultado de la multiplicación:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Debug.Log(resultado[i, j]);
            }
        }
    }

    int[,] MultiplicarMatrices(int[,] matrizA, int[] matrizB)
    {
        int filasA = matrizA.GetLength(0);
        int columnasA = matrizA.GetLength(1);

        int[,] resultado = new int[filasA, columnasA];

        for (int i = 0; i < filasA; i++)
        {
            for (int j = 0; j < columnasA; j++)
            {
                resultado[i, j] = matrizA[i, j] * matrizB[i];
            }
        }

        return resultado;






    }
}
