using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCommands : MonoBehaviour
{
    public GameObject Erinnerung;
    public static GameObject SurvivalKit;
    public static GameObject Pyramide;
    public static GameObject Graph;

    // Use this for initialization
    void Awake()
    {
        Erinnerung = GameObject.FindWithTag("Erinnerung");
        Erinnerung.SetActive(false);
        SurvivalKit = GameObject.FindWithTag("SurvivalKit");
        SurvivalKit.SetActive(false);
        Graph = GameObject.FindWithTag("Graph");
        Graph.SetActive(false);
        Pyramide = GameObject.FindWithTag("Pyramide");
        Pyramide.SetActive(false);
    }
}
