using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thorwing : MonoBehaviour
{
    [SerializeField] GameObject Object1;
    [SerializeField] GameObject Object2;
    [SerializeField] Transform SpawnPosition;
    [SerializeField] float ThrownForce;
    [SerializeField] float ThrownDelay = 2f;
    [SerializeField] bool canThrow;

    void Update()
    {
        if (canThrow)
        {
            Throw();
        }
    }

    void Throw()
    {
        canThrow = false;

        GameObject thrownObject1 = Instantiate(Object1, SpawnPosition.transform.position, SpawnPosition.transform.rotation);        
        Rigidbody rb1 = thrownObject1.GetComponent<Rigidbody>();
        rb1.AddForce(transform.forward * ThrownForce);

        StartCoroutine(DelayCoroutine());
    }

    IEnumerator DelayCoroutine()
    {
        yield return new WaitForSeconds(ThrownDelay);

        GameObject thrownObject2 = Instantiate(Object2, SpawnPosition.transform.position, SpawnPosition.transform.rotation);
        Rigidbody rb2 = thrownObject2.GetComponent<Rigidbody>();
        rb2.AddForce(transform.forward * ThrownForce);
    }
}
