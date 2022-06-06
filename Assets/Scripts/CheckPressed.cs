using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CheckPressed : MonoBehaviour
{
    public ButtonState[] buttons;

    void OnTriggerEnter(Collider Other)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (!buttons[i].pressed) return;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
