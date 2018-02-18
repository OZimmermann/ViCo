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


	public void BaseMenue(){
		Erinnerung.SetActive(false);
		SurvivalKit.SetActive(false);
		Graph.SetActive(false);
		Pyramide.SetActive(false);	

		Anker.SetActive(true);	
		Pokal.SetActive(true);	
		Hantel.SetActive(true);	
	}

	public void AnkerMenue(){
		Graph.SetActive(false);
		Pyramide.SetActive(false);	
		Anker.SetActive(false);	
		Pokal.SetActive(false);	
		Hantel.SetActive(false);	

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
	}

	public void PokalMenue(){
		SurvivalKit.SetActive(false);
		Graph.SetActive(false);
		Anker.SetActive(false);	
		Pokal.SetActive(false);	
		Hantel.SetActive(false);	

		Erinnerung.SetActive(true);
		Pyramide.SetActive(true);	
	}


}


