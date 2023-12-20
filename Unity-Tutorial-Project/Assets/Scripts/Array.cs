using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] myint = { 1, 2, 3, 4, 5, 6, 4643, 2355, 436, 43643};
        int lastValue = myint.Length;


        Debug.Log(myint[lastValue-1 ]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
