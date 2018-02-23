using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;

public class AnkerCommands : MonoBehaviour
{	
	public KeywordManager keywordManager;

    void OnSelect()
    {
        Debug.Log("Anker offen");
		GetComponentInParent<MenueController> ().AnkerMenue ();
		keywordManager.StartKeywordRecognizer ();
    }
}
