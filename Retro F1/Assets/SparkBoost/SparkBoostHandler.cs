using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SparkBoostHandler : MonoBehaviour
{
    public TextMeshProUGUI boostText;

    [Header("Boost Settings")]
    public float speedBoostFactor;

    [Header("Debug")]
    [SerializeField] private float chargePecentage = 0f;

    TopDownCarController topDownCarController;
    
    void Awake()
    {
        topDownCarController = GetComponent<TopDownCarController>();
    }

    private void Update()
    {
        boostText.text = chargePecentage.ToString();
        if(Input.GetKeyDown("space") && chargePecentage >= 10)
        {
            chargePecentage = 0;
            topDownCarController.ApplySpeedBoost(speedBoostFactor);
        }
    }

    private void FixedUpdate()
    {
        if(topDownCarController.atMaxSpeed)
        {
            chargePecentage += 0.1f;
        }
    }

}
