using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownX : MonoBehaviour
{
    //adjust this to change speed
    
    float speed = 2.0f;
    //adjust this to change how high it goes
    
    float height = 15.0f;

    Vector3 pos;


    // Start is called before the firstframe update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //calculate what the new Y position will be
        float newY = Mathf.Sin(Time.time * speed) * height + pos.y;
        //set the object's Y to the new calculated Y
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
