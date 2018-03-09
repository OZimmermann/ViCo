using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;
using UnityEngine.SceneManagement;

public class ExerciseManager : MonoBehaviour {

    public AudioSource uni;
    public AudioSource prototyp;
    public AudioSource angstDavor;
    public AudioSource beginn;

    public KeywordManager keywordManager;

    private int counter; // for keyboard input

    public int stage;

    // Use this for initialization
    void Start()
    {
        stage = 1;
        keywordManager = GetComponent<KeywordManager>();
        uni.Play();
        Debug.Log("Sag: yes");
    }

    void Update()
    {
        switch(stage)
        {
            case 1:
                if(!uni.isPlaying)
                {
                    keywordManager.StartKeywordRecognizer();
                }
                break;
            case 2:
                if (!prototyp.isPlaying)
                {
                    keywordManager.StartKeywordRecognizer();
                }
                break;
            case 3:
                if (!angstDavor.isPlaying)
                {
                    keywordManager.StartKeywordRecognizer();
                }
                break;
            case 4:
                if (!beginn.isPlaying)
                {
                    Debug.Log("Scene 'Panik' will be loaded");
                    SceneManager.LoadScene("panikuebung", LoadSceneMode.Single);
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
                vorschlagprototyp();
            }
            else if (counter == 2)
            {
                angstvorher();
            }
            else if (counter == 3)
            {
                aufgabe();
            }
        }

    }

    public void vorschlagprototyp()
    {
        stage++; // 2
        keywordManager.StopKeywordRecognizer();
        prototyp.Play();
        Debug.Log("Sag: okay");
    }

    public void angstvorher()
    {
        stage++; // 3
        keywordManager.StopKeywordRecognizer();
        angstDavor.Play();
        Debug.Log("Sag: nine");
    }

    public void aufgabe()
    {
        stage++; // 4
        keywordManager.StopKeywordRecognizer();
        beginn.Play();
    }

}
