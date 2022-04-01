using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//7. Realizá un programa que al ingresar por Inspector tres números enteros num1, num2 y  num3
//muestre el valor del mayor de todos. 
//En caso de igualdad entre los tres imprimir "Los números son iguales". 
public class Ejercicio7 : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;
    // Start is called before the first frame update
    void Start()
    {
       if (num1 > num2 && num1 > num3)
        {
            Debug.Log("El mayor de tods es " + num1);
        }
       else if (num2 > num1 && num2 > num3)
        {
            Debug.Log("El mayor de todos es " + num2);
        }
       else if (num3 > num1 && num3 > num2)
        {
            Debug.Log("El mayor de todos es " + num3);
        }
       else if (num3 == num2 && num3 == num1)
        {
            Debug.Log("Los tres número son iguales");
        }
       else
        {
            Debug.Log("Ingrese un número válido");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
