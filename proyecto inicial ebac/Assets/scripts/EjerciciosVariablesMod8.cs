using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    public int miVariable = 1;
    public float miVariable1 = 1.0f;

    public GameObject GameObject;

    public GameObject cubo;


   



    private void Start()
    {

        float variable1 = 10.5f;
        float variable2 = 3.75f;

        float resultadoFloat = variable1 / variable2;
        int resultadoEntero = (int)resultadoFloat;

        Debug.Log("El resultado en float es:" + resultadoFloat);
        Debug.Log("El resultado en entero (con casting explicito) es:" + resultadoEntero);

        string colorElegido = "amarillo";

        switch (colorElegido)
        {
            case "verde":
                Debug.Log("El objeto elegido es verde");
                gameObject.GetComponent<Renderer>().material.color = Color.green;
                break;
            case "amarillo":
                Debug.Log("El objeto elegido es amarillo");
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
                break;

        }
        float numeroFlotante = 3.14161516145f;
        string cadenaConPrecision = numeroFlotante.ToString("F4");
        Debug.Log("Numero flotante convertido a cadena con cuatro decimales de precision:" + cadenaConPrecision);

        string nombreCompleto = "JavierdeJesusPerezCastañeda";
        string primerNombre = nombreCompleto.Substring(0, 6);
        string segundoNombre = nombreCompleto.Substring(6, 15);
        string apellidos = nombreCompleto.Substring(21);
        Debug.Log("Primer Nombre:" + primerNombre);
        Debug.Log("Segundo Nombre:" + segundoNombre);
        Debug.Log("Apellidos:" + apellidos);

        string nombreCompleto2 = "Javier de Jesus Perez Castañeda";
        string[] partes = nombreCompleto2.Split(' ');
        foreach (string parte in partes)
        {
            Debug.Log("Parte:" + parte);
        }

        string valor1 = "4000";
        string valor2 = "7000";
        int numerico1;
        int numerico2;
        bool exito1 = int.TryParse(valor1, out numerico1);
        bool exito2 = int.TryParse(valor2, out numerico2);
        if (exito1 && exito2)
        {
            int resultado = numerico1 + numerico2;
            Debug.Log("El resultado de la operacion es:" + resultado);
        }
        else
        {
            Debug.Log("Error al convertir los valores a numericos.");
        }

        string oracion = "Quiero Desarrollar";
        for (int i = 0; i < oracion.Length; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(oracion[i]);
            }

        }

        string oracion2 = "Quiero vacaciones";
        if (oracion2.Length > 5)
        {
            string nuevaOracion = oracion.Substring(5);
            Debug.Log(nuevaOracion);
        }
        
        















    }
    // Update is called once per frame
    void Update()
    {
        miVariable *= 2;
        Debug.Log("El valor actual de la variable es: " + miVariable);
    }

    private void FixedUpdate()
    {
        miVariable1 *= 1.5f;
        Debug.Log("El valor actual de la variable es: " + miVariable1);

        int numero = 8;
        if (numero % 2 == 0) 
        {
            Debug.Log(numero + "es un numero par.");
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else 
        {
            Debug.Log(numero + "es un numero impar.");
            gameObject.GetComponent<Renderer>().material.color = Color.black;
        }

    }
}
