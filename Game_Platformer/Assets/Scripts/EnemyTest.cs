using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : MonoBehaviour
{
    IEnumerator BaseCoroutine()
    {
        EnemyController control = new EnemyController();
        yield return new WaitForSeconds(2);
        if (control.speed == 15f)
            Debug.Log("Enemy speed is correct");
        else
            Debug.Log("Enemy speed is incorrect");
    }
    void Start()
    {
        StartCoroutine(BaseCoroutine());
    }
}
