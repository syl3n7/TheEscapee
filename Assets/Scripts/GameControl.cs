using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    private InputManager inputManager;
    public GameObject panel;
    //public AudioSource MasterAudio;
    //[Range(1, 100)]
    //public float masterVolume = 50;
    Scene sCene;

    void Start()
    {
        Application.targetFrameRate = 60;
        sCene = SceneManager.GetActiveScene();
        if (sCene.name != "Menu") panel.SetActive(false);
        inputManager = GetComponent<InputManager>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (sCene.name != "Menu")
        {
            //pauseCamOnPause();
            pauseMenu();
        }
    }

    //public void audioControl()
    //{

    //}

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
        if (inputManager.onFoot.Pause.triggered)
        {
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            panel.SetActive(!panel.activeSelf);
        }
    }
    
    //void pauseCamOnPause()
    //{

    //}
}
