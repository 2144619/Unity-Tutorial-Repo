using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloning : MonoBehaviour
{
    [SerializeField]
    GameObject toClone;

    [SerializeField]
    int numClones = 0;
    [SerializeField]
    float minPos = 0;
    [SerializeField]
    float maxPos = 0;
    // Start is called before the first frame update
    void Start()
    {
        int cloneCount = 0;
        GameObject clonedObject;
        Vector3 randomPos = Vector3.zero;

        clonedObject = GameObject.Instantiate(toClone);
        

    }

    // Update is called once per frame
    void Update()
    {
        






    }
}
