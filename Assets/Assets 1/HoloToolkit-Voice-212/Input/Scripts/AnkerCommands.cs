using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnkerCommands : MonoBehaviour
{
    void OnSelect()
    {
		GetComponentInParent<MenueController> ().AnkerMenue ();
    }
}
