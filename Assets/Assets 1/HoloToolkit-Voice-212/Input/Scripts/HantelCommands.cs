using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;


public class HantelCommands : MonoBehaviour
{
	//private KeywordManager keywordManager;

	void OnSelect()
	{
        Debug.Log("Hantel offen");
        GetComponentInParent<MenueController> ().HantelMenue ();
		//skeywordManager.StartKeywordRecognizer ();
	}
}

