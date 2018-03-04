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
    public AudioSource panik;
    public AudioSource übung;
    public AudioSource panikDanach;
    public AudioSource angstDanach;
    public AudioSource belohnung;

    public KeywordManager keywordManager;

    public GameObject FotoPanik;

    // Use this for initialization
    void Start()
    {
        keywordManager = GetComponent<KeywordManager>();
        uni.Play();
        FotoPanik.SetActive(false);
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
        Debug.Log("Sag: shit");
    }

    public void paniksituation()
    {
        panik.Play();
        Debug.Log("Sag: help me");
    }

    public void panikaufgabe()
    {
        übung.Play();
        FotoPanik.SetActive(true);
        Debug.Log("Sag: thanks");
    }

    public void panikfertig()
    {
        FotoPanik.SetActive(false);
        panikDanach.Play();
        Debug.Log("Sag: no");
    }

    public void aufgabeFortsetzen()
    {
        angstDanach.Play();
        Debug.Log("Sag: ready");
    }

    public void belohnungVorschlag()
    {
        belohnung.Play();
    }

}
