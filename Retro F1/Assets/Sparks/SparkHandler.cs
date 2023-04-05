using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparkHandler : MonoBehaviour
{
    //Components
    TopDownCarController topDownCarController;
    ParticleSystem system;

    private void Awake()
    {
        topDownCarController = GetComponentInParent<TopDownCarController>();
        system = GetComponent<ParticleSystem>();
    }
    void Update()
    {
       if(topDownCarController.atMaxSpeed)
       {
            system.Play();
       }
    }
}
