using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnkerCommands : MonoBehaviour
{
    // Menu hirachy level 1
    public GameObject Pokal;
    public GameObject Hantel;

    // Menu hirachy level 2
    public GameObject Erinnerung;
    public GameObject SurvivalKit;

    // Other menu items
    /*public GameObject Draußen;
    public GameObject Drinnen;
    public GameObject Einkaufen;
    public GameObject Telefon;*/
    public GameObject Graph;
    public GameObject Pyramide;

    void Awake()
    {
        // Menu items on second and further hirachy level are disabled
        Erinnerung = GameObject.FindWithTag("Erinnerung");
        Erinnerung.SetActive(false);
        SurvivalKit = GameObject.FindWithTag("SurvivalKit");
        SurvivalKit.SetActive(false);

        // Further menu items are disabled
        /*  Draußen = GameObject.FindWithTag("Draußen");
          Draußen.SetActive(false);
          Drinnen = GameObject.FindWithTag("Drinnen");
          Drinnen.SetActive(false);
          Einkaufen = GameObject.FindWithTag("Einkaufen");
          Einkaufen.SetActive(false);
          Telefon = GameObject.FindWithTag("Telefon");
          Telefon.SetActive(false);*/
        Graph = GameObject.FindWithTag("Graph");
        Graph.SetActive(false);
        Pyramide = GameObject.FindWithTag("Pyramide");
        Pyramide.SetActive(false);
    }

    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        // Menu disappears when the user selects one option
        gameObject.SetActive(false); // gameObject: Anker
        Pokal = GameObject.FindWithTag("Pokal");
        Pokal.SetActive(false);
        Hantel = GameObject.FindWithTag("Hantel");
        Hantel.SetActive(false);

        // Next menu items appear
        Erinnerung.SetActive(true);
        SurvivalKit.SetActive(true);
    }
}
