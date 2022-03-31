using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Realizá un programa que resuelva el siguiente problema:  
//Deberá ingresarse por Inspector una fecha de compra(String en el siguiente formato:  YYYYMMDD), un nombre de comprador, un nombre de producto y una cantidad y precio del producto comprado.
//Mostrá a modo de ticket, la información ingresada y el monto a pagar.Modelo de Ticket:  
//Fecha de Compra: YYYYMMDD
//Nombre del Comprador: xxxxx xxxxx
//Producto solicitado: xxxxx
//Cantidad solicitada: xx
//Precio Unitario: $xxx
//Total a Pagar: $xxxxx

public class Ejercicio11 : MonoBehaviour
{
    public string fecha;
    public string NombreComprador;
    public string NombreProducto;
    public int cantidad;
    public float precio;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Fecha de Compra: " + fecha + "\n" + "Nombre del Comprador: " + NombreComprador + "\n" + "Producto solicitado: " + NombreProducto + "\n" + "Cantidad Solicitada: " + cantidad + "\n" + "Precio Unitario: " + precio + "\n" + "Total a Pagar: " + precio*cantidad); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
