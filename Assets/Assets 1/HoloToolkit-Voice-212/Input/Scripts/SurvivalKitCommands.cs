using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;
using UnityEngine.SceneManagement;

public class SurvivalKitCommands : MonoBehaviour
{ 
    void OnSelect()
    {
        Debug.Log("Scene 'Survival Kit' will be loaded");
        SceneManager.LoadScene("survivalKit", LoadSceneMode.Single);
    }
}
