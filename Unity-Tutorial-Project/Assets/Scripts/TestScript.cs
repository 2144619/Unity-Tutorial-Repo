using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TestScript : MonoBehaviour
{
    // Editor Variables
    [SerializeField]
    string editorString = "Yo";

    [SerializeField]
    float targetScale = 1.0f;

    [SerializeField]
    SpriteRenderer playerSprite = null;

    [SerializeField]
    Color spriteColor = Color.white;

    // Private Variables
    string combinedString;
    //int frameCount = (60);

    Vector3 changingScale = new Vector3(1.0f, 1.0f, 1.0f);


    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log("You have my sword.");
        Debug.Log("And my bow.");
        Debug.Log("And my axe!");
        transform.Translate(-6, 0, 0);
        */

        // Declare a variable called firstString
        string firstString;
        firstString = "You shall not";
        //Debug.Log(firstString);

        string secondString = " PASS!";
        //Debug.Log(secondString);

        combinedString = firstString + secondString;
        //Debug.Log(combinedString);
        //Debug.Log(editorString);

        playerSprite.color = spriteColor;

    }

    // Update is called once per frame
    void Update()
    {
        /*
        Debug.Log("Peter Piper picked a peck of pickled peppers");
        
        transform.Translate(0.1f, 0, 0);
        */

        //Debug.Log(combinedString);

        Debug.Log(targetScale = targetScale + 0.01f);

        changingScale.x = targetScale;
        changingScale.y = targetScale;
        changingScale.z = targetScale;

        transform.localScale = changingScale;

    }
}
