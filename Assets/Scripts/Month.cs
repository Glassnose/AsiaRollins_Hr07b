using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{
    int x = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        if (x <= 12)
        {

            Debug.Log("Just another Month" + x);
         
        }
        else if (x >= 2)
        {
            Debug.Log("It's my Birthday 1-15" + x );
            x = x + 1;
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
