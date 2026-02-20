using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Planet : MonoBehaviour
{
    const double G = 6.67430e-11;
    const double M_SUN = 1.98847e30; // en kilogrammes (kg)

    public float planetDistance;    // En millions de kilomètres



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float timeMultiplier = 365.0f * 24 * 3600;

        Vector3 rotationAxis = Vector3.up; // axe de rotation

        float truePlanetDistance = planetDistance * (float)Math.Pow(10, 9);

        double thetaRotation = Math.Sqrt((G * M_SUN) / Math.Pow(truePlanetDistance, 3)) * Time.deltaTime * timeMultiplier;

        transform.Rotate(0.0f, (float)thetaRotation * Mathf.Rad2Deg, 0.0f, Space.Self);

        Debug.Log(thetaRotation);


    }
}
