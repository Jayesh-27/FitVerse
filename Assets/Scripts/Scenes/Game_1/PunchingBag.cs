using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PunchingBag : MonoBehaviour
{
    [SerializeField] PunchSpeed S_PunchSpeed;
    [SerializeField] Animator PunchingBag_animator;
    [SerializeField] private TMP_Text textMeshPro;

    private int Score;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(S_PunchSpeed.Speed);
        PunchingBag_animator.SetBool("Animation2", false);
        PunchingBag_animator.SetBool("Animation1", true);

        Score = Mathf.Clamp(Mathf.RoundToInt(S_PunchSpeed.Speed * 66.6f), 0, 999);

        textMeshPro.text = Score.ToString("000");

        StartCoroutine(DelayFunction(2f));
    }

    IEnumerator DelayFunction(float delay)
    {
        yield return new WaitForSeconds(delay);
        Debug.Log("Delay finished!");
        PunchingBag_animator.SetBool("Animation1", false);
        PunchingBag_animator.SetBool("Animation2", true);
    }
}
