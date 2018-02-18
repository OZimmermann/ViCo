using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCommands : MonoBehaviour
{
	// Use this for initialization
	void Awake()
	{
		GetComponent<MenueController> ().BaseMenue ();
	}

}
