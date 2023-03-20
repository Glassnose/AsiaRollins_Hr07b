using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenNumbers : MonoBehaviour
{
    int x = 22;
    // Start is called before the first frame update
    void Start()
    {
        while (x <= 100)
        {
            Debug.Log("this is my count" + x);
            x = x + 2;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
