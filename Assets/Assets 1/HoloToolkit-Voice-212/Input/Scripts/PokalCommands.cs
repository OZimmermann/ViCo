using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;


public class PokalCommands : MonoBehaviour
{
	private KeywordManager keywordManager;

    void OnSelect()
	{
		Debug.Log("Pokal offen");
		GetComponentInParent<MenueController> ().PokalMenue ();
		keywordManager.StartKeywordRecognizer ();
    }
}

