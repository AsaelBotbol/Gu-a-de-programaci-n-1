using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    //Variables:
    public int num1 = 4;
    public int num2 = 5;

    // Start is called before the first frame update
    void Start()
    {
        int suma = num1 + num2;
        Debug.Log("La suma da: " + suma);
        int producto = num1 * num2;
        Debug.Log("La multiplicacion da: " + producto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
