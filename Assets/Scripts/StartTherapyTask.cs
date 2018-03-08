using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;
using UnityEngine.SceneManagement;

public class StartTherapyTask : MonoBehaviour {

    void OnSelect()
    {
        Debug.Log("Scene 'Therapeuten Übung' will be loaded");
        SceneManager.LoadScene("03_therapeuten_uebung", LoadSceneMode.Single);
    }
}
