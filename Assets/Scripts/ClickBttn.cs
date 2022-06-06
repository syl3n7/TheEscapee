using System.Runtime.CompilerServices;
using UnityEngine;

public class ClickBttn: MonoBehaviour
{
    public InputManager inputManager;
    public float dist = 2f;
    public Camera cam;
    public LayerMask BttnLayer;
    public CheckPressed bttnPressed;


    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, dist,BttnLayer))
        {
            if (inputManager.onFoot.LMB.triggered)
            {
                Debug.Log("Hit");
                hit.transform.gameObject.GetComponent<ButtonState>().pressed = true;
            }
        }
    }
}