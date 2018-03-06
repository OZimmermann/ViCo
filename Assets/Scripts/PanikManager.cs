using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;
using UnityEngine.SceneManagement;

public class PanikManager : MonoBehaviour {

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
        FotoPanik.SetActive(false);
        Debug.Log("Sag: blackout / ready");
    }

    void Update()
    {
        keywordManager.StartKeywordRecognizer();
    }

    public void panikabfrage()
    {
        panik.Play();
        Debug.Log("Sag: help me / no");
    }

    public void panikaufgabe()
    {
        FotoPanik.SetActive(true);
        übung.Play();
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
