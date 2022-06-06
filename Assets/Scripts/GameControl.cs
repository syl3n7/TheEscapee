using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    //public AudioSource MasterAudio;
    //[Range(1, 100)]
    //public float masterVolume = 50;
    Scene sCene;

    void Start()
    {
        Application.targetFrameRate = 60;
        sCene = SceneManager.GetActiveScene();
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
    
    //void pauseCamOnPause()
    //{

    //}
}
