using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    public string texto;

    // Start is called before the first frame update
    void Start()
    {
        //print("Hello World!");
    }

    void Update()
    {
        print("Hello World!\n");
        print(texto);
    }
}
