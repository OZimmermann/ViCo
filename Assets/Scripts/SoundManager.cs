using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;

public class SoundManager : MonoBehaviour {

	public AudioSource introduction;
	public KeywordManager keywordManager;

	void Start () {
		introduction = GetComponent<AudioSource>();
		keywordManager = GetComponent<KeywordManager> ();

		introduction.Play ();
		Debug.Log ("Ich spiele introduction ab");
		//source.Play(44100);
	}

	void Update () {
		if (!introduction.isPlaying) {
			keywordManager.StartKeywordRecognizer ();
			//Debug.Log ("KeywordManager started");
		}
	}

	public void Gender () {
		Debug.Log ("männlich");
	}
}