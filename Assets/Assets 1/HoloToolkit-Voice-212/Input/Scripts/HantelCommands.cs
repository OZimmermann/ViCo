﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HantelCommands : MonoBehaviour
{
	// Called by GazeGestureManager when the user performs a Select gesture
	void OnSelect()
	{
		GetComponentInParent<MenueController> ().HantelMenue ();
	}
}

