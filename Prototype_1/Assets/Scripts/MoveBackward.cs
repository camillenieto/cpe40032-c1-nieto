using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackward : MonoBehaviour
{
    public float Speed = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the objects(rocks) backward.
        transform.Translate(Vector3.back * Time.deltaTime * Speed);
    }
}
