using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Realizá un programa que resuelva el siguiente problema:
Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del
total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
por las tres.
Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
mostrar lo pedido en el siguiente formato:
Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….*/

public class Ejercicio9 : MonoBehaviour
{
    //Variables:
    public int person1;
    public int person2;
    public int person3;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(person1 + "capital aportado" )
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
