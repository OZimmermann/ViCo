using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnkerCommands : MonoBehaviour
{
    void OnSelect()
    {
        Debug.Log("Anker offen");
		GetComponentInParent<MenueController> ().AnkerMenue ();
    }
}
