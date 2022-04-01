using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Existen dos reglas que identifican dos conjuntos de valores: 
- El número es de un solo dígito.  
- El número es impar.  
A partir de estas reglas, creá un algoritmo que asigne a las variables booleanas estaEnA,  estaEnB, estaEnAmbos y noEstaEnNinguno el valor verdadero o falso, según corresponda,  para indicar si el valor ingresado pertenece al primer conjunto, al segundo, a ambos o a  ninguno, respectivamente. Definí un lote de prueba de varios números y probá el algoritmo,  escribiendo los resultados. */

public class Ejercicio15 : MonoBehaviour
{
    bool estaEnA;
    bool estaEnB;
    bool estaEnAmbos;
    bool noEstaEnNinguno;
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        if (num < -10 && num > 10 && num % 2 == 0)
        {
            noEstaEnNinguno = true;
            Debug.Log("El número no esta en ningun conjunto de valores");
        }
        else if (num > -10 && num < 10)
        {
            estaEnA = true;
            Debug.Log("El número esta en el conjunto de valores A");
        }
        else if (num % 2 != 0)
        {
            estaEnB = true;
            Debug.Log("El número esta en el conjunto de valores B");
        }
        else if (num > -10 & num < 10 & num % 2 != 0)
        {
            estaEnAmbos = true;
            Debug.Log("El número esta en ambos conjuntos de valores");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
