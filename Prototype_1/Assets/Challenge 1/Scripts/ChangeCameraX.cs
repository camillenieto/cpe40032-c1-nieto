using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraX : MonoBehaviour
{
    public Camera MainCamera;
    public Camera PilotPerspective;
    public KeyCode switchKey;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Pressing the left arrow key, the camera can switch position.
        if (Input.GetKeyDown(switchKey))
        {
            //Enable the game to have two cameras.
            MainCamera.enabled = !  MainCamera.enabled;
            PilotPerspective.enabled = !PilotPerspective.enabled;
        }
    }
}
