using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables
    private float Speed = 15.0f;
    private float TurnSpeed = 80.0f;
    private float HorizontalInput;
    private float ForwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get the player Input using keys in the keyboard (arrows,A,S,D,W)
        HorizontalInput = Input.GetAxis("Horizontal");
        ForwardInput = Input.GetAxis("Vertical");
        // move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * ForwardInput);
        // Enables the user to move sideward the vehicle.
        transform.Rotate(Vector3.up, TurnSpeed * HorizontalInput *Time.deltaTime);
    }
}
