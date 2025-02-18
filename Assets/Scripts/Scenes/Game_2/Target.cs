using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Target : MonoBehaviour
{
    float End;
    [SerializeField] float Speed = 5f;

    void Start()
    {
        End = transform.position.z - 40;
    }
    void Update()
    {
        if(transform.position.z > End)
        {
            transform.position = transform.position + Vector3.back * Speed * Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
