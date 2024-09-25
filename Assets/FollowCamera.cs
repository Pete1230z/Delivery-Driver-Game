using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //SerializedField makes it so that you can see this variable in the inspector
    //It is type GameObject, and is called thingToFollow
    [SerializeField] GameObject thingToFollow;
    //this things position (camera) should be the same as the car's position

    // Update is called once per frame
    void Update()
    {
        transform.position = 
    }
}
