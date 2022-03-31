using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    //Variables:
    public int num1;

    // Start is called before the first frame update
    void Start()
    {
        if ((num1 % 2) == 0)
        {
            Debug.Log(num1 + " es un número par");
        }
        else
        {
            Debug.Log(num1 + " es un número impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
