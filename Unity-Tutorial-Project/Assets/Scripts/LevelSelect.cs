using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelSelect : MonoBehaviour
{
    [SerializeField]
    TMP_Text[] levelText = null;

    int numLocked = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int levelIndex = 0; levelIndex > levelText.Length; ++levelIndex) ;
        {
            TMP_Text levelToCheck = null;

            levelToCheck = levelIndex.Length;


        }
        
        // INITALISING LEVELTOCHECK
        TMP_Text levelToCheck = null;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
