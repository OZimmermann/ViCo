using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour {

	public AudioSource start;
	public AudioSource gender;
	public AudioSource owl;
	public AudioSource end;
	public KeywordManager keywordManager;

    public GameObject Eule;
    public GameObject Leuchtkugel;

	public int stage = 1;
	/*
	 * stage = 1 // introduction
	 * stage = 2 // ChooseGender
	 * stage = 3 // ChooseOwl
	 */

	void Start () {
		keywordManager = GetComponent<KeywordManager> ();

        Eule.SetActive(false);

		start.Play ();
		Debug.Log ("Ich spiele introduction ab");
		//source.Play(44100);
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
				//SceneManager.LoadScene ("therapeuten_uebung", LoadSceneMode.Additive);
				SceneManager.LoadSceneAsync("therapeuten_uebung", LoadSceneMode.Additive);
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
		Debug.Log ("Sag: männlich");
	}

	public void ChooseOwl () {
		stage++;
		keywordManager.StopKeywordRecognizer ();
		owl.Play ();
		Debug.Log ("Sag: Sag Waldkauz/Uhu/Schneeeule");
	}

	public void EndIntroduction () {
        Leuchtkugel.SetActive(false);
        Eule.SetActive(true);

		stage++;
		keywordManager.StopKeywordRecognizer ();
		Debug.Log ("Initialisierung beendet");
		end.Play ();
	}
}