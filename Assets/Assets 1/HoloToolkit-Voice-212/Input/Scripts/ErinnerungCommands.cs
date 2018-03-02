using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;
using UnityEngine.SceneManagement;

public class ErinnerungCommands : MonoBehaviour {

    void OnSelect()
    {
        Debug.Log("Scene 'Erinnerug' will be loaded");
        SceneManager.LoadScene("erinnerug", LoadSceneMode.Single);
    }
}
