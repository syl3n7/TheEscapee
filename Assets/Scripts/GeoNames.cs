using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GeoNames : MonoBehaviour
{
    public string serviceLocation;
    public string service;
    public string username;
    public int maxRows = 10;
    [Space]
    public UnityEngine.UI.Text textArea;
    public void Search(UnityEngine.UI.InputField query)
    {
        string serviceURL = serviceLocation + "/" + service + "?q" + query.text + "&maxRows=" + maxRows + "&userName=" + username;
        StartCoroutine(SendQuery(serviceURL));
    }

    IEnumerator SendQuery(string URL)
    {
        UnityWebRequest request = new UnityWebRequest(URL);

        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success) Debug.Log("Erro de comunicação");
        else textArea.text = request.downloadHandler.text;
    }
}
