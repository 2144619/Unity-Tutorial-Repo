using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("You have my sword.");
        Debug.Log("And my bow.");
        Debug.Log("And my axe!");
        transform.Translate(-6, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Peter Piper picked a peck of pickled peppers");
        transform.Translate(0.1f, 0, 0);

    }
}
