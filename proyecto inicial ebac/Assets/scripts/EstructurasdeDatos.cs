using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EstructurasdeDatos : MonoBehaviour
{
    List<int> listaNumeros = new List<int>();
    List<string> listaStrings = new List<string>();
    HashSet<int> hashetInts = new HashSet<int>();
    Queue<string> colaStrings = new Queue<string>();
    Stack<string> pilaStrings = new Stack<string>();
    Dictionary<string, float> poderArmas = new Dictionary<string, float>();

 // Start is called before the first frame update
    void Start()
    {
        DemoDictionary("Pistola");
        DemoDictionary("Espada");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DemoListas()
    {
        for (int i = 0; i < 30; i++)
        {
            listaNumeros.Add(Random.Range(0, 30));
        }
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
        //esto es para dar acomodo en reversa
        listaNumeros.Sort();
        listaNumeros.Reverse();
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }





        listaStrings.Add("Laura");
        listaStrings.Add("Carlos");
        listaStrings.Add("Javier");
        listaStrings.Add("Andrea");
        listaStrings.Add("Juan");
        listaStrings.Add("Ivan");
        foreach (var nombre in listaStrings)
        {
            Debug.Log(nombre);
        }
        listaStrings.RemoveAt(2);

        foreach (var nombre in listaStrings)
        {
            Debug.Log(nombre);
        }
    }
    public void DemoHashset()
    {
        for (int i = 0; i < 30; i++)
        {
            hashetInts.Add(i);
        }
        if (hashetInts.Contains(5))
        {
            hashetInts.Remove(5);
        }
        else
        {
            Debug.Log("El HashSet no contiene ese elemento");
        }
    }

    public void DemoColas()
    {
        ///firs in first out = fifo

        colaStrings.Enqueue("Proyectil1");
        colaStrings.Enqueue("Proyectil2");
        colaStrings.Enqueue("Proyectil3");
        colaStrings.Enqueue("Proyectil4");
        colaStrings.Enqueue("Proyectil5");
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
    }
    public void DemoPilas()
    {
        ///first in last out = filo
        pilaStrings.Push("As");
        pilaStrings.Push("CincoEspadas");
        pilaStrings.Push("TresCorazones");
        pilaStrings.Push("CuatroTrebol");
        pilaStrings.Push("ReyEspadas");
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
    }

    public void DemoDictionary(string arma)
    {
        float temporal = 0;
        if(!poderArmas.ContainsKey("Pistola"))
        {
            poderArmas.Add("Pistola", 3.0f);
        }
        if(!poderArmas.ContainsKey("rifle"))
        {
            poderArmas.Add("rifle", 5.0f);
        }
        if(!poderArmas.ContainsKey("escopeta"))
        {
            poderArmas.Add("Escopeta", 7.0f);
        }
        if(!poderArmas.ContainsKey("Francotirador"))
        {
            poderArmas.Add("Francotirador", 10.0f);
        }
        




        if (poderArmas.TryGetValue(arma, out temporal))
        {
            Debug.Log(temporal);
        }
        else
        {
            Debug.Log("Esa arma no existe");
        }
    }



}
