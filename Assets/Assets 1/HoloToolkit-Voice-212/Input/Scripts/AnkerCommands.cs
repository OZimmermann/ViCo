using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnkerCommands : MonoBehaviour
{

    public MenuCommands script = GameObject.Find("Erinnerung").GetComponent<MenuCommands>();

    // Menu hirachy level 1
    public GameObject Pokal;
    public GameObject Hantel;

    // Menu hirachy level 2
    public GameObject Erinnerung;
    public GameObject SurvivalKit;

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
        Erinnerung = GameObject.FindWithTag("Erinnerung");
        Erinnerung.SetActive(true);
        SurvivalKit = GameObject.FindWithTag("SurvivalKit");
        SurvivalKit.SetActive(true);
    }
}
