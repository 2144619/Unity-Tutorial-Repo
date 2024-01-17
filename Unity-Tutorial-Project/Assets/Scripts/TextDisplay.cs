using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextDisplay : MonoBehaviour
{
    [SerializeField]
    TMP_Text myText = null;
    // Start is called before the first frame update
    void Start()
    {
        myText.text = "nuts";
        //myText.color = new Color (Random.value,Random.value,Random.value);
    }

    // Update is called once per frame
    void Update()
    {
      int[] color = null;
        for (int i = 0; i < 3; i++)
        {
            // float colour1 = 0;
            // float colour2 = 0;
            // float colour3 = 0;
            // color[i] = Random.Range({0f,0.255f});
            //color
            //myText.color[(color[1], color[2], color[3]);
            myText.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
