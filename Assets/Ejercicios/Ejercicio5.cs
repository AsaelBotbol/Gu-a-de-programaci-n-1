using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
