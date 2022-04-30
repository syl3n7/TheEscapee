using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    
    public AudioSource MasterAudio;
    [Range(1, 100)] 
    public float masterVolume = 50;

    public void audioControl()
    {

    }

    public GameObject panel;
    private void Start()
    {
        Scene sCene = SceneManager.GetActiveScene();
        if (sCene.name != "Menu") panel.SetActive(false);
    }
    void Update()
    {
        pauseMenu();
    }
    void pauseMenu()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) panel.SetActive(!panel.activeSelf);
        while (panel.activeSelf)
        {
            Time.timeScale = 0f;
        } Time.timeScale = 1f;
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
