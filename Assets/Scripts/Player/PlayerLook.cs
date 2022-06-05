using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;

    public float xSensitivity = 20f;
    public float ySensitivity = 20f;
    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        //apply this to our camera transform
        cam.transform.localRotation = Quaternion.Euler(20f, 0f, 0f);
        // rotate player to look up and down, left and right
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
        transform.Rotate(Vector3.left * (mouseY * Time.deltaTime) * ySensitivity);
    }
}
