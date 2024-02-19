using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateScore : MonoBehaviour
{
    [SerializeField]
    TMPro.TextMeshPro scoreDisplay = null;
    [SerializeField]
    int debugAdd = 0;


    void AddScore (int toAdd)
    {
        int currentScore = 0;
        currentScore = currentScore + toAdd;
        scoreDisplay = currentScore.ToString();

        return currentScore;

    }

    // Start is called before the first frame update
    void Start()
    {
        int currentScore = 0;
        int newScore = 0;
        AddScore (newScore);

        Debug.Log(newScore);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
