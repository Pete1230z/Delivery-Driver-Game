using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(255, 0, 0, 255);
    [SerializeField] Color32 noPackageColor = new Color32(0, 255, 0, 255);
    bool hasPackage = false;
    [SerializeField] float destroySpeed = 0.5f;
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Macy be careful!");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        //If player has a package they can not pick up another one
        if (other.tag == "Package" && !hasPackage) {
            Debug.Log("Package picked up!");
            hasPackage = true;
            Destroy(other.gameObject, destroySpeed);
        } else if (other.tag == "Customer" && hasPackage) {
            Debug.Log("Package delivered!");
            //Once the package is delivered, the customer can not drop it off again
            hasPackage = false;
        }
    }
}
