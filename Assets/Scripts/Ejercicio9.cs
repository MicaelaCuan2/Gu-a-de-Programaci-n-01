using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Realizá un programa que resuelva el siguiente problema:  
//Tres personas aportan diferente capital a una sociedad.
//Se desea saber qué porcentaje del total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado  por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar lo pedido en el siguiente formato:  
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 
//12*100/total (sumar las tres variables)
public class Ejercicio9 : MonoBehaviour
{
    public string persona1;
    public string persona2;
    public string persona3;
    public float aporte1;
    public float aporte2;
    public float aporte3;
    // Start is called before the first frame update
    void Start()
    {
        float AporteTotal = aporte1 + aporte2 + aporte3;
        Debug.Log("Nombre: " + persona1 + ". Capital aportado: " + aporte1 + ". Porcentaje del capital: % " + aporte1 * 100 / AporteTotal + ". Monto total aportado: $" + AporteTotal);
        Debug.Log("Nombre: " + persona2 + ". Capital aportado: " + aporte2 + ". Porcentaje del capital: % " + aporte2 * 100 / AporteTotal + ". Monto total aportado: $" + AporteTotal);
        Debug.Log("Nombre: " + persona3 + ". Capital aportado: " + aporte3 + ". Porcentaje del capital: % " + aporte3 * 100 / AporteTotal + ". Monto total aportado: $" + AporteTotal);
        Debug.Log("El monto total aportado por los tres es de " + aporte1 + aporte2 + aporte3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
