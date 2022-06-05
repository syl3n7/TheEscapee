using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public GameObject player;
    public float smooth;

    private Quaternion DoorOpen;
    private Quaternion DoorClosed;

    void OnTriggerEnter(Collider collision)
    {
        DoorClosed = gameObject.transform.rotation;
        DoorOpen = gameObject.transform.rotation = Quaternion.Euler(0, -90, 0);
        gameObject.transform.rotation = Quaternion.Lerp(DoorClosed, DoorOpen, Time.deltaTime * smooth);
    }
}
