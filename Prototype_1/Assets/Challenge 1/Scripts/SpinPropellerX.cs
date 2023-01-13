using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float propellorSpeed = 1000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Make the propellor rotate at the given speed.
        transform.Rotate(Vector3.forward, propellorSpeed * Time.deltaTime);
    }
}
