using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivalBoxCommands : MonoBehaviour
{
	void OnSelect()
	{
		Debug.Log("SurvivalBox offen");
		GetComponentInParent<MenueController> ().SurvivalKitMenue ();
	}
}
