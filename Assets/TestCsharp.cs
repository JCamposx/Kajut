using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCsharp : MonoBehaviour
{
    public int Edad {
        get;
        private set; // Al colocar private set, la propiedad será de solo lectura
    } // Propiedades (getters y setters)

    // Start is called before the first frame update
    void Start()
    {
        int num = 10;
        float peso = 40.5f;
        bool verdad = true;
        string nombre = "Pepe";

        string  numero = num.ToString();

        Debug.Log($"Hola {nombre}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
