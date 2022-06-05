using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetPos : MonoBehaviour
{
    public Transform p;
    private Vector3 reset;
    private void Start()
    {
        reset = p.transform.position;

    }

    private void OnTriggerEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") p.transform.position = reset;
    }
}
