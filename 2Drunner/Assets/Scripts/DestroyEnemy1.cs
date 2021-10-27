using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy1 : MonoBehaviour
{
    private readonly float TimeToDisable = 15f;

    void Start()
    {
        StartCoroutine(SetDisable());
    }

    IEnumerator SetDisable()
    {
        yield return new WaitForSeconds(TimeToDisable);
        gameObject.SetActive(false);
    }
}
