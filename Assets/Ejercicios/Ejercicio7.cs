using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{
    //Variables:
    public int num1;
    public int num2;
    public int num3;

    // Start is called before the first frame update
    void Start()
    {

        if (num1 == num2 && num2 == num3)
        {
            Debug.Log("son los 3 iguales");
        }
        else if (num1 > num2 && num1 > num3)
        {
            Debug.Log(num1);
        }

        else if (num2 > num1 && num2 > num3)
        {
            Debug.Log(num2);
        }

        else if (num3 > num2 && num3 > num1)
        {
            Debug.Log(num3);
        }


        // Update is called once per frame
        void Update()
        {

        }
    }
}
