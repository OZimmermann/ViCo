using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;
using UnityEngine.SceneManagement;

public class PresentationCommands : MonoBehaviour {

    void OnSelect()
    {
        Debug.Log("Scene 'Hausaufgabe' will be loaded");
        SceneManager.LoadScene("hausaufgabe", LoadSceneMode.Single);
    }
}
