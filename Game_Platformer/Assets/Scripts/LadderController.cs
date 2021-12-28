using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderController : MonoBehaviour
{
    void Update()
    {
        float distance = GameObject.Find("Player").transform.position.x - GetComponent<Transform>().position.x;

        if (Math.Abs(distance) < 200f)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("E");
                GameObject.Find("Player").GetComponent<RectTransform>().transform.position = new Vector3(GameObject.Find("Player").GetComponent<RectTransform>().transform.position.x, GameObject.Find("Player").GetComponent<RectTransform>().transform.position.y + 170f, GameObject.Find("Player").GetComponent<RectTransform>().transform.position.z);
            }
        }
    }
}
