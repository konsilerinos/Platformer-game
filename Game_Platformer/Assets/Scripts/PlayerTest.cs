using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    IEnumerator BaseCoroutine()
    {
        PlayerController control = new PlayerController();
        if (control.IsDead == false)
            Debug.Log("Player check for death is correct");
        else
            Debug.Log("Player check for death is incorrect");
        yield return new WaitForSeconds(2);
        if (control.const_speed == 0.0f)
            Debug.Log("Player const_speed is correct");
        else
            Debug.Log("Player const_speed is incorrect");
        if (control.speed == 0.0f)
            Debug.Log("Player speed is correct");
        else
            Debug.Log("Player speed is incorrect");
        if(control.Jump_speed == 0.0f)
            Debug.Log("Player jump speed is correct");
        else
            Debug.Log("Player jump speed is incorrect");
    }
    void Start()
    {
        StartCoroutine(BaseCoroutine());
    }
}
