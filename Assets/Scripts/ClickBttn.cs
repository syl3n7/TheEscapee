using UnityEngine;

public class ClickBttn: MonoBehaviour
{
    public Animator bttn;
    public InputManager inputManager;

    public float dist = 2f;

    private bool press;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * 2);
        if (Physics.Raycast(ray, out hit, dist) && hit.collider.tag == "Button")
        {
            if (inputManager.onFoot.LMB.triggered)
            {
                Debug.Log("you are looking at the button");
                bttn.SetTrigger("Pressed");
            }
        }
    }
}