using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivalKitCommands : MonoBehaviour
{
	void OnSelect ()
    {
        Debug.Log("SurvivalKit offen");
        GetComponentInParent<MenueController>().SurvivalKitMenue();
    }
}
