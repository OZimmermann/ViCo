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

    private int stage;

    // Use this for initialization
    void Start()
    {
        keywordManager = GetComponent<KeywordManager>();
        uni.Play();
        Debug.Log("Sag: yes");
    }

    void Update()
    {
        keywordManager.StartKeywordRecognizer();

        switch(stage)
        {
            case 1:
                if (!beginn.isPlaying)
                {
                    Debug.Log("Scene 'Panik' will be loaded");
                    SceneManager.LoadSceneAsync("panikuebung", LoadSceneMode.Single);
                }
                break;
        }
    }

    public void vorschlagprototyp()
    {
        prototyp.Play();
        Debug.Log("Sag: okay");
    }

    public void angstvorher()
    {
        angstDavor.Play();
        Debug.Log("Sag: nine");
    }

    public void aufgabe()
    {
        keywordManager.StopKeywordRecognizer();
        beginn.Play();
        stage++;
    }

}
