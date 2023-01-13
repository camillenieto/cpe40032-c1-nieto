using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automove : MonoBehaviour
{
    public float Speed = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the npc vehicle forward automatically.
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }
}
