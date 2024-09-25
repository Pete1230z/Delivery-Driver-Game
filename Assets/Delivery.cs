using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Macy be careful!");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package") {
            Debug.Log("Package picked up!");
            hasPackage = true;
        } else if (other.tag == "Customer" && hasPackage) {
            Debug.Log("Package delivered!");
            //Once the package is delivered, the customer can not drop it off again
            hasPackage = false;
        }
    }
}
