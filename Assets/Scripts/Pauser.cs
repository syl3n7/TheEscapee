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
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()//serve para controlar o menu de pausa em todas as scenes exceto main menu
    {
        if (sCene.name != "Menu") panel.SetActive(false);
        inputManager = GetComponent<InputManager>();
        Cursor.lockState = CursorLockMode.Locked;
    }
}
