using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FourPractice : MonoBehaviour

{
    [SerializeField]
    int target = 0;

    int count = 0;



    // Start is called before the first frame update
    void Start()
    {
        for(int count = 0;count < target;++count)
        {
            Debug.Log(count);
        } 



    /* while (count < target) 
     * {
            Debug.Log("Shitty Joke");
            count++;
        
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
