using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodPractice : MonoBehaviour
{
    [SerializeField]
    string words = "to say";


    void ComputerSays()
    {
        string elf = "but the butter was bitter,so Betty bought some better butter to make the bitter butter better.";
        Debug.Log(elf);
        //Debug.Log(woody);

        //words = "fhfrshbrhedjh";
        //Debug.Log(words);
    }
    // Start is called before the first frame update
    void Start()
    {
        //string woody = "koijoiiuiuiuygiuiugiugiug";
        string elf = " How much wood would a woodchuck chuck";
        Debug.Log(elf);
        ComputerSays();
        //words = "realeyesrealizereallies";
        //Debug.Log(words);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
