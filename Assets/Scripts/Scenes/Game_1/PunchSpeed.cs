using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchSpeed : MonoBehaviour
{
    public float Speed = 0f;
    private Vector3 lastPosition;
    void Update()
    {
        Speed = (transform.position - lastPosition).magnitude / Time.deltaTime;
        lastPosition = transform.position;
    }
}
