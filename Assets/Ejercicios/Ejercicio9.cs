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
    public string nom1;
    public string nom2;
    public string nom3;

    public float cap1;
    public float cap2;
    public float cap3;

    // Start is called before the first frame update
    void Start()
    {
        float suma = cap1 + cap2 + cap3;
        float porcen1 = (cap1/suma)*100;
        float porcen2 = (cap2/suma)*100;
        float porcen3 = (cap3/suma)*100;


        Debug.Log(nom1 + ": capital aportado: $" + cap1 + ", Porcentaje del capital: " + porcen1 + "% , Monto total aportado: $" + suma);
        Debug.Log(nom2 + ": capital aportado: $" + cap2 + ", Porcentaje del capital: " + porcen2 + "% , Monto total aportado: $" + suma);
        Debug.Log(nom3 + ": capital aportado: $" + cap3 + ", Porcentaje del capital: " + porcen3 + "% , Monto total aportado: $" + suma);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
