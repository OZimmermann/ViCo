using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;
using UnityEngine.SceneManagement;

public class TherapyTaskManager : MonoBehaviour {

    public AudioSource intro;
    public AudioSource sortieren;
    public AudioSource fertig;

    public GameObject Steine;

    public KeywordManager keywordManager;

    private int counter; // for keyboard input

    public int stage;
    /* 
     * stage = 1 // Angst Intro
     * stage = 2 // Ängste sortieren
     * stage = 3 // Pyramide fertig
     */

	// Use this for initialization
	void Start () {
        keywordManager = GetComponent<KeywordManager>();
        stage = 1;
        Steine.SetActive(false);
        intro.Play();
        Debug.Log("Sag: okay");
	}
	
	// Update is called once per frame
	void Update () {
		switch (stage)
        {
            case 1:
                if(!intro.isPlaying)
                {
                    keywordManager.StartKeywordRecognizer();
                    // Debug.Log("KeywordManager started");
                }
                break;
            case 2:
                if(!sortieren.isPlaying)
                {
                    keywordManager.StartKeywordRecognizer();
                    // Debug.Log("KeywordManager started");
                }
                break;
            case 3:
                if(!fertig.isPlaying)
                {
                    // Debug.Log("new Scene will be loaded");
                    SceneManager.LoadScene("hausaufgabe", LoadSceneMode.Single);
                }
                break;
            default:
                break;
        }

        // Keyboard input instead of speach input
        if (Input.GetKeyDown("space"))
        {
            counter++;

            if (counter == 1)
            {
                angstSortieren();
            }
            else if (counter == 2)
            {
                pyramideFertig();
            }
        }

    }

    public void angstSortieren()
    {
        stage++; // 2
        sortieren.Play();
        Steine.SetActive(true);
        Debug.Log("Sag: ready");
    }

    public void pyramideFertig()
    {
        stage++; // 3
        fertig.Play();
    }
}
