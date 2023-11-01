using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaPulls : MonoBehaviour
{
    [SerializeField]
    int startingCurrency=0;
    [SerializeField]
    int pullCost=0;
    [SerializeField]
    float rewardChance = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        int numPulls = 0;
        float chanceRewardInverse = 0.0f;
        float overallRewardInverse = 0.0f;
        float overallRewardChance = 0.0f;

        numPulls = startingCurrency/pullCost;

        Debug.Log(numPulls);

        chanceRewardInverse = 1.0f - rewardChance;

        overallRewardInverse = Mathf.Pow(chanceRewardInverse, numPulls);

        overallRewardChance = 1.0f - overallRewardInverse;

        Debug.Log(overallRewardChance);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
