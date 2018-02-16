using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokalCommands : MonoBehaviour
{
    // Menu hirachy level 1
    public GameObject Hantel;
    public GameObject Anker;

    // Menu hirachy level 2
    public GameObject Graph;
    public GameObject Pyramide;

    // Other menu items
    public GameObject Erinnerung;
    public GameObject SurvivalKit;

    void Awake()
    {
        // Menu items on second and further hirachy level are disabled
        /* Graph = GameObject.FindWithTag("Graph");
        Graph.SetActive(false);
        Pyramide = GameObject.FindWithTag("Pyramide");
        Pyramide.SetActive(false);*/

        // Further menu items are disabled
        /* Erinnerung = GameObject.FindWithTag("Erinnerung");
        Erinnerung.SetActive(false);
        SurvivalKit = GameObject.FindWithTag("SurvivalKit");
        SurvivalKit.SetActive(false);*/
    }

    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        // Menu disappears when the user selects one option
        gameObject.SetActive(false); // gameObject: Pokal
        Anker = GameObject.FindWithTag("Anker");
        Anker.SetActive(false);
        Hantel = GameObject.FindWithTag("Hantel");
        Hantel.SetActive(false);

        // Next menu items appear
        Graph.SetActive(true);
        Pyramide.SetActive(true);
    }
}

