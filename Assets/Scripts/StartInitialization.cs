using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;
using UnityEngine.SceneManagement;

public class StartInitialization : MonoBehaviour {

    void OnSelect()
    {
        Debug.Log("Scene 'Initialisierung' will be loaded");
        SceneManager.LoadScene("02_initialisierung", LoadSceneMode.Single);
    }
}
