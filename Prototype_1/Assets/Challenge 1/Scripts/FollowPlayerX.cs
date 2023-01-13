using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(30, 3, 10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Will follow the movement of the player in a given x,y,z coordinate.
        transform.position = player.transform.position + offset;
    }
}
