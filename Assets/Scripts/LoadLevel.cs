using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public string sCene;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") SceneManager.LoadScene(sCene);
    }
}
