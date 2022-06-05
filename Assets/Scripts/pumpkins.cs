using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pumpkins : MonoBehaviour
{
    public Transform target;

    private void Awake()
    {
        target = GameObject.FindWithTag("Player").transform;
    }
    void Update()
    {
        gameObject.transform.LookAt(target);
    }
}
