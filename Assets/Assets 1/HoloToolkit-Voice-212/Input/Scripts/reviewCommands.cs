using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;
using UnityEngine.SceneManagement;

public class reviewCommands : MonoBehaviour {

    void OnSelect()
    {
        Debug.Log("Scene 'Wochenrückblick' will be loaded");
        SceneManager.LoadScene("wochenrückblick", LoadSceneMode.Single);
    }
}
