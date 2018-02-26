using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenueController : MonoBehaviour
{
	public GameObject Erinnerung;
	public GameObject SurvivalKit;
	public GameObject Pyramide;
	public GameObject Graph;
	public GameObject Anker;
	public GameObject Pokal;
	public GameObject Hantel;
    public GameObject Einkaufen;
    public GameObject Telefon;
    public GameObject Uebung;
	public GameObject SurvivalBox;

	public void HideMenue(){
        Debug.Log("Menü zu");
        Erinnerung.SetActive(false);
		SurvivalKit.SetActive(false);
		Graph.SetActive(false);
		Pyramide.SetActive(false);	
        Einkaufen.SetActive(false);
        Telefon.SetActive(false);
        Uebung.SetActive(false);
        Anker.SetActive(false);	
		Pokal.SetActive(false);	
		Hantel.SetActive(false);
		SurvivalBox.SetActive(false);
	}

	public void BaseMenue(){
		Debug.Log("Menü offen");
		Erinnerung.SetActive(false);
		SurvivalKit.SetActive(false);
		Graph.SetActive(false);
		Pyramide.SetActive(false);
        Einkaufen.SetActive(false);
        Telefon.SetActive(false);
        Uebung.SetActive(false);
		SurvivalBox.SetActive(false);

        Anker.SetActive(true);	
		Pokal.SetActive(true);	
		Hantel.SetActive(true);	
	}

	public void AnkerMenue(){
		Graph.SetActive(false);
		Pyramide.SetActive(false);
        Einkaufen.SetActive(false);
        Telefon.SetActive(false);
        Uebung.SetActive(false);
        Anker.SetActive(false);	
		Pokal.SetActive(false);	
		Hantel.SetActive(false);
		SurvivalBox.SetActive(false);

		Erinnerung.SetActive(true);
		SurvivalKit.SetActive(true);
	}

	public void HantelMenue(){
		Erinnerung.SetActive(false);
		SurvivalKit.SetActive(false);
		Graph.SetActive(false);
		Pyramide.SetActive(false);	
		Anker.SetActive(false);	
		Pokal.SetActive(false);	
		Hantel.SetActive(false);
		SurvivalBox.SetActive(false);

        Einkaufen.SetActive(true);
        Telefon.SetActive(true);
        Uebung.SetActive(true);
    }

	public void PokalMenue(){
		SurvivalKit.SetActive(false);
		Erinnerung.SetActive(false);
        Einkaufen.SetActive(false);
        Telefon.SetActive(false);
        Uebung.SetActive(false);
        Anker.SetActive(false);	
		Pokal.SetActive(false);	
		Hantel.SetActive(false);
		SurvivalBox.SetActive(false);

        Graph.SetActive(true);
		Pyramide.SetActive(true);	
	}

	public void SurvivalKitMenue(){
		SurvivalKit.SetActive(false);
		Erinnerung.SetActive(false);
		Einkaufen.SetActive(false);
		Telefon.SetActive(false);
		Uebung.SetActive(false);
		Anker.SetActive(false);	
		Pokal.SetActive(false);	
		Hantel.SetActive(false);
		Graph.SetActive(false);
		Pyramide.SetActive(false);

		SurvivalBox.SetActive(true);
	}
}


