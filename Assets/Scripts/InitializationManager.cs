using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;
using UnityEngine.SceneManagement;

public class InitializationManager : MonoBehaviour {

	public AudioSource start;
	public AudioSource gender;
	public AudioSource owl;
	public AudioSource end;
	public KeywordManager keywordManager;

    public GameObject Eule;
    public GameObject EulenAuswahl;
    public GameObject Leuchtkugel;

	private int stage;
	/*
	 * stage = 1 // start introduction
	 * stage = 2 // ChooseGender
	 * stage = 3 // ChooseOwl
	 * stage = 4 // end introduction and set next scene
	 */

	void Start () {
		stage = 1;
		keywordManager = GetComponent<KeywordManager> ();
		//Debug.Log("Stage: " + stage);

        Eule.SetActive(false);
        EulenAuswahl.SetActive(false);

        start.Play();
        Debug.Log("Sag: yes, okay (,ja)");
    }

    void Update () {
		switch (stage) {
		case 1:
			if (!start.isPlaying) {
				keywordManager.StartKeywordRecognizer ();
				//Debug.Log ("KeywordManager started");
			}
			break;
		case 2: 
			if (!gender.isPlaying) {
				keywordManager.StartKeywordRecognizer ();
				//Debug.Log ("KeywordManager started");
			}
			break;
		case 3: 
			if (!owl.isPlaying) {
				keywordManager.StartKeywordRecognizer ();
				//Debug.Log ("KeywordManager started");
			}
			break;
		case 4:
			if (!end.isPlaying) {
				Debug.Log("new Scene will be loaded");
				SceneManager.LoadScene ("03_therapeuten_uebung", LoadSceneMode.Single);
				//SceneManager.LoadSceneAsync("03_therapeuten_uebung", LoadSceneMode.Single);
			}
			break;
		default:
			break;
		}
	}

	public void ChooseGender () {
		stage++;
		keywordManager.StopKeywordRecognizer ();
		gender.Play ();
		Debug.Log ("Sag: man");
		Debug.Log ("Saveword: two");
	}

	public void ChooseOwl () {
        EulenAuswahl.SetActive(true);

        stage++;
		keywordManager.StopKeywordRecognizer ();
		owl.Play ();
		Debug.Log ("Sag: Sag Waldkauz/Uhu/Schneeeule");
		Debug.Log ("Saveword: four");
	}

	public void EndIntroduction () {
        Leuchtkugel.SetActive(false);
        EulenAuswahl.SetActive(false);
        Eule.SetActive(true);

		stage++;
		keywordManager.StopKeywordRecognizer ();
		Debug.Log ("Initialisierung beendet, warte auf Ende vom Soundfile");
		end.Play ();
	}
}