using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public GameObject panel;
    public AudioSource MasterAudio;
    [Range(1, 100)]
    public float masterVolume = 50;
    Scene sCene;

    void Start()
    {
        Application.targetFrameRate = 60;
        sCene = SceneManager.GetActiveScene();
        if (sCene.name != "Menu") panel.SetActive(false);
    }

    void Update()
    {
        if (sCene.name != "Menu")
        {
            pauseMenu();
        }
    }

    public void QuitGame() //serve para terminar o processo onde o jogo e executado
    {
        Application.Quit();
    }
    public void LoadScene(string sceneName) //serve para carregar as scenes
    {
        SceneManager.LoadScene(sceneName);
    }
    void pauseMenu() //serve para controlar o menu de pausa em todas as scenes exceto main menu
    {
        if (Input.GetKeyUp(KeyCode.Escape)) panel.SetActive(!panel.activeSelf);
        if (panel.activeSelf) Time.timeScale = 0f;
        else Time.timeScale = 1f;
    }
}
