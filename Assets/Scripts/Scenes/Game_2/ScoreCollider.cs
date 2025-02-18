using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollider : MonoBehaviour
{
    [SerializeField] Score S_UpdateScore;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "RTarget" || other.gameObject.tag == "LTarget")
        {
            S_UpdateScore.score++;
            Destroy(other.gameObject);
        }
    }
}
