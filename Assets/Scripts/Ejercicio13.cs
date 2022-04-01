using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente  manera:  
• Si trabaja 40 horas o menos se le paga $16 por hora (crear una constante para almacenar  el 16) 
• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20  por cada hora extra. (crear una constante para almacenar el 20) 
Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por  pantalla el salario correspondiente. 
*/
public class Ejercicio13 : MonoBehaviour
{
    int Pago = 16;
    int PagoExtra = 20;
    public int HorasTrabajadas;

    // Start is called before the first frame update
    void Start()
    {
        if (HorasTrabajadas < 0)
        {
            Debug.Log("Por favor ingrese una hora válida.Es decir que sea mayor a 0 ");
        }
        else if (HorasTrabajadas <= 40)
        {
            Debug.Log("El salario correspondiente es de ” +HorasTrabajadas * Pago");
        }
        else if (HorasTrabajadas >= 40)
        {
            Debug.Log("El salario correspondiente es de ” +HorasTrabajadas * PagoExtra");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
