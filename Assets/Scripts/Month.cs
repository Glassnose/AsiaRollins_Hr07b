using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{
    int x = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        while (x <= 12)
        {

            Debug.Log("Just another Month" + x);
            x = x + 1;
         
        }
        if (x <= 2)
        {
            Debug.Log("It's my Birthday 1-15" );
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
