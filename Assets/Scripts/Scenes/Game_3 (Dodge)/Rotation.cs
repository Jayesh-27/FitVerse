using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Transform target;  // Assign target in the Inspector
    public float rotationSpeed = 5f;  // Speed of rotation

    void Update()
    {
        // Calculate the direction towards the target
        Vector3 direction = target.position - transform.position;

        // Create the rotation based on that direction
        Quaternion targetRotation = Quaternion.LookRotation(direction);

        // Smoothly rotate using Lerp (interpolation between the current rotation and the target rotation)
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
    }
}
