using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;
using UnityEngine.SceneManagement;

public class SurvivalBoxCommands : MonoBehaviour
{
    void OnSelect()
    {
        Debug.Log("Scene 'SurvivalKit' will be loaded");
        SceneManager.LoadScene("survivalKit", LoadSceneMode.Single);
    }
}
