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
        // INITIALIZE chosenIndex variable
        int chosenIndex = 0;

        // SET chosenIndex to a randomly generated value between zero and the length of the toClone array
        chosenIndex = Random.Range(0, toClone.Length);

        // INITIALIZE chosenToClone variable
        GameObject chosenToClone = null;

        // SET chosenToClone to the chosenIndex GameObject in the toClone array
        chosenToClone = toClone[chosenIndex];

        // INITIALIZE clonedObject variable
        GameObject clonedObject = null;

        // CALL the method Instantiate(), using chosenToClone, and store the value in the clonedObject variable
        clonedObject = Instantiate(chosenToClone);

        // INITIALIZE randomPos variable
        Vector3 randomPos = Vector3.zero;

        // SET randomPos’ x value to a randomly generated value between minPos and maxPos
        randomPos.x = Random.Range(minPos, maxPos);

        // SET randomPos’ y value to a randomly generated value between minPos and maxPos
        randomPos.y = Random.Range(minPos, maxPos);

        // SET clonedObject’s transform’s position to randomPos
        clonedObject.transform.position = randomPos;





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
