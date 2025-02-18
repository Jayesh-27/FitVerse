using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCollider : MonoBehaviour
{
    [SerializeField] Score S_UpdateScore;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RTarget")
        {
            S_UpdateScore.score++;
            Destroy(other.gameObject);
        }
        else if(other.gameObject.tag == "LTarget")
        {
            S_UpdateScore.score = 0;
        }
    }
}
