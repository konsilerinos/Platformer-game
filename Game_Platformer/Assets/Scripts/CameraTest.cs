using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour
{
    IEnumerator BaseCoroutine()
    {
        GameObject control = GameObject.Find("Main Camera");
        yield return new WaitForSeconds(2);
        if (control.transform.position == new Vector3(0.0f, 0.0f, -10f))
            Debug.Log("Camera position is correct");
        else
            Debug.Log("Camera position is incorrect");
    }
    void Start()
    {
        StartCoroutine(BaseCoroutine());
    }
}
