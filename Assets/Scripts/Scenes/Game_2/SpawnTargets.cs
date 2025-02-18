using System.Collections;
using UnityEngine;

public class SpawnTargets : MonoBehaviour
{
    [SerializeField] GameObject RTarget;
    [SerializeField] GameObject LTarget;
    [SerializeField] Transform[] R_Spawns;
    [SerializeField] Transform[] L_Spawns;
    [SerializeField] float RSpawnTime = 1f;
    [SerializeField] float LSpawnTime = 1f;
    bool RcanSpawn = true;
    bool LcanSpawn = true;

    void Update()
    {
        if (RcanSpawn)
        {
            RcanSpawn = false;
            StartCoroutine(RDelayedAction());
        }

        if (LcanSpawn)
        {
            LcanSpawn = false;
            StartCoroutine(LDelayedAction());
        }
    }

    IEnumerator RDelayedAction()
    {
        yield return new WaitForSeconds(Random.Range(0.1f, RSpawnTime));
        Transform spawnPoint = R_Spawns[Random.Range(0, R_Spawns.Length)];
        Instantiate(RTarget, spawnPoint.position, Quaternion.identity);
        RcanSpawn = true;
    }

    IEnumerator LDelayedAction()
    {
        yield return new WaitForSeconds(Random.Range(0.5f, LSpawnTime));
        Transform spawnPoint = L_Spawns[Random.Range(0, L_Spawns.Length)];
        Instantiate(LTarget, spawnPoint.position, Quaternion.identity);
        LcanSpawn = true;
    }
}
