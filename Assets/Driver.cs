using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //SerializedField is to make the variable visible in the inspector
    [SerializeField]float steerSpeed = 1f;
    [SerializeField]float moveSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //variable goes in Update() so that it is updated every frame
        //Multiple by steerSpeed to make the steering more responsive to user input
        //Time.deltaTime is to make the steering speed consistent across different frame rates
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed* Time.deltaTime;

        //moveAmount is the amount of movement in the forward direction
        //multiplied by moveSpeed to make the movement more responsive to user input
        //Time.deltaTime is to make the steering speed consistent across different frame rates
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        //f is to denote that is a float
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
