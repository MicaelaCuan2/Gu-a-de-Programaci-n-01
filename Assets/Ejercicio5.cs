// Realizá un programa que, dados dos números enteros num1 y num2 cargados desde  el Inspector muestre el resultado de la división del primero por el segundo en un texto UI siguiendo el formato num1 + “ / “ + num2 + “ = “ + resultado.  
//En el caso de que el segundo valor num2 sea cero, mostrar el siguiente mensaje de error:  “No se puede dividir por cero”. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        if (num2 == 0)
        {
            Debug.Log("Por favor ingrese un número válido, que no sea 0");
        }
        else
        {
            double res = System.Convert.ToDouble(num1) / System.Convert.ToDouble(num2);
            Debug.Log("El resultado de la división " + num1 + ":" + num2 + " es " + res);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
