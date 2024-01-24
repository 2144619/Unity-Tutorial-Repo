using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelSelect : MonoBehaviour
{
    [SerializeField]
    TMP_Text[] levelText = null;

    [SerializeField]
    int numUnlocked = 0;

    // Start is called before the first frame update
    void Start()
    {
        //FOR each value of levelIndex from 0 to the number of items in the levelText array
        for (int levelIndex = 0; levelIndex < levelText.Length; ++levelIndex)
        {
            //Setting levelToCheck to equal null
            TMP_Text levelToCheck = null;

            //Setting levelToCheck to equal the number of levelText in the array
            levelToCheck = levelText[levelIndex];

            //If levelIndex is not equal to numUnlocked
            if (levelIndex >= numUnlocked)
            {
                //Set levelToCheck text is "Locked"
                levelToCheck.text = "Locked";

                //Set levelToCheck's colour to red
                levelToCheck.color = Color.red;


            }


        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
