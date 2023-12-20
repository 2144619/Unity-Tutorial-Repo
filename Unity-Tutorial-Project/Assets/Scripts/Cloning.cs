using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloning : MonoBehaviour
{
    //Editable Variables
    [SerializeField]
    GameObject toClone = null;

    [SerializeField]
    int numClones = 5;
    [SerializeField]
    float minPos = -10;
    [SerializeField]
    float maxPos = 10;
    // Start is called before the first frame update
    void Start()
    {

        for (int cloneCount = 0; cloneCount < numClones; cloneCount++)
        {
            // INITIALIZE clonedObject variable
            GameObject clonedObject = null;
            // CALL the method Instantiate(), using toClone, and store the
            // value in the clonedObject variable
            clonedObject = Instantiate(toClone);
            // INITIALIZE randomPos variable
            Vector3 randomPos = Vector3.zero;
            // SET randomPos’ x value to a randomly generated value between minPos and maxPos
            randomPos.x = Random.Range(minPos, maxPos);
            // SET randomPos’ y value to a randomly generated value between minPos and maxPos
            randomPos.y = Random.Range(minPos, maxPos);
            // SET clonedObject’s transform’s position to randomPos
            clonedObject.transform.position = randomPos;
        } // END FOR

        //int cloneCount = 0;
        //GameObject clonedObject;
        //Vector3 randomPos = Vector3.zero;

       // clonedObject = GameObject.Instantiate(toClone);
        

    }

    // Update is called once per frame
    void Update()
    {
        






    }
}
