using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomClone : MonoBehaviour
{
    [SerializeField]
    GameObject[] toClone = null;


    [SerializeField]
    float minPos = -10;

    [SerializeField]
    float maxPos = 10;

    // Start is called before the first frame update
    void Start()
    {
        int chosenIndex = 0;
        chosenIndex = Random.Range(0, toClone.Length);

        GameObject chosenToClone = null;




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
