﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Realizá un programa que, dados dos números enteros num1 y num2 cargados desde el
Inspector muestre el resultado de la división del primero por el segundo en la consola
siguiendo el formato num1 + “ / “ + num2 + “ = “ + resultado.
En el caso de que el segundo valor num2 sea cero, mostrar el siguiente mensaje de error:
“No se puede dividir por cero”.*/

public class Ejercicio5 : MonoBehaviour
{
    //Variables:
    public int num1;
    public int num2;

    void Start()
    {
        if (num2 == 0)
        {
            Debug.Log("No se puede dividir por '0'");
        }
        else
        {
            Debug.Log("el resultado de la divición entre " + num1 + " y " + num2 + " da como resultado " + (num1 / num2));
        }
    }
}
