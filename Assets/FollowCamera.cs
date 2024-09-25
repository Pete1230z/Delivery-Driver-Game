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
    //LateUpdate ensures the camera smoothly follows the car
    void LateUpdate()
    {
        //Set the position of this object (camera) to be the same as the thingToFollow plus some offset on the z axis
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
