using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotation = 0f;

    public float Sensitivity = 20f;
    public void ProcessLook(Vector2 input)
    {
        //float mouseX = input.x;
        //float mouseY = input.y;
        ////apply this to our camera transform
        //cam.transform.localRotation = Quaternion.Euler(20f, 0f, 0f);
        //// rotate player to look up and down, left and right
        //transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * Sensitivity);
        //cam.transform.Rotate(Vector3.right * (mouseY * Time.deltaTime) * Sensitivity);

        float mouseX = input.x;
        float mouseY = input.y;
        //calculate camera rotation for looking up and down
        xRotation -= (mouseY * Time.deltaTime) * Sensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        //apply this to our camera transform
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        // rotate player to look left and right
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * Sensitivity);
    }
}
