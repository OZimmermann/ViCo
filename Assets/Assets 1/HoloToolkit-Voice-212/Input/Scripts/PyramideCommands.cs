using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;
using UnityEngine.SceneManagement;

public class PyramideCommands : MonoBehaviour {

    void OnSelect()
    {
        Debug.Log("Scene 'Pyramide' will be loaded");
        SceneManager.LoadScene("pyramide", LoadSceneMode.Single);
    }
}
