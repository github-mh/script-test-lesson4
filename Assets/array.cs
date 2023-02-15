using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[5];

        array[0] = 100;
        array[1] = 200;
        array[2] = 300;
        array[3] = 400;
        array[4] = 500;

        for (int i = 0; i<5; i++)
        {
            Debug.Log(array[i]);
        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
