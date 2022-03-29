using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    //Variables:
    public int num1;
    public int num2;

    // Start is called before the first frame update
    void Start()
    {
        int suma = num1 + num2;
        Debug.Log("La sume entre " + num1 + " y " + num2 + " da como resultado " + suma);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
