using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pauser : MonoBehaviour
{
    private InputManager inputManager;
    public GameObject panel;
    Scene sCene;
    // Start is called before the first frame update
    void Start()
    {
        sCene = SceneManager.GetActiveScene();
        inputManager = GetComponent<InputManager>();
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (inputManager.onFoot.Pause.triggered)
        {
            panel.SetActive(!panel.activeSelf);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
            
    }
}
