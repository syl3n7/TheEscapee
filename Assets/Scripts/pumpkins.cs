using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pumpkins : MonoBehaviour
{
    public Transform[] enemies;
    public Transform target;
    public Transform cam;

    private void Awake()
    {
        target = GameObject.FindWithTag("Player").transform;
    }
    void Update()
    {
        pumpkinPos();
    }
    void pumpkinPos()
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].transform.LookAt(target);
        }
    }
}
