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
        beginn.Play();
        Debug.Log("Scene 'Panik' will be loaded");
        SceneManager.LoadScene("panikuebung", LoadSceneMode.Single);
    }
}
