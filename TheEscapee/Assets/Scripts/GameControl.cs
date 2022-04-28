using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject panel;
    private void Start()
    {
        panel.SetActive(false);
    }
    void Update()
    {
        pauseMenu();
    }
    void pauseMenu()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) panel.SetActive(!panel.activeSelf);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting"); //Just to make sure its working
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
