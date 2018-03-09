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

    public int stage;

    // private int counter; // for keyboard input

    // Use this for initialization
    void Start()
    {
        stage = 1;
        keywordManager = GetComponent<KeywordManager>();
        FotoPanik.SetActive(false);
        Debug.Log("Sag: blackout / ready");
    }

    void Update()
    {
        switch (stage)
        {
            case 1:
                keywordManager.StartKeywordRecognizer();
                break;
            case 2:
                if (!panik.isPlaying)
                {
                    keywordManager.StartKeywordRecognizer();
                }
                break;
            case 3:
                if (!übung.isPlaying)
                {
                    keywordManager.StartKeywordRecognizer();
                }
                break;
            case 4:
                if (!panikDanach.isPlaying)
                {
                    keywordManager.StartKeywordRecognizer();
                }
                break;
            case 5:
                if (!angstDanach.isPlaying)
                {
                    keywordManager.StartKeywordRecognizer();
                }
                break;
            case 6:
                if (!belohnung.isPlaying)
                {
                    keywordManager.StartKeywordRecognizer();
                }
                break;
            default:
                break;
        }

        // Keyboard input instead of speach input
        /*if (Input.GetKeyDown("space"))
        {
            counter++;

            if (counter == 1)
            {
                panikabfrage();
            }
            else if (counter == 2)
            {
                panikaufgabe();
            }
            else if (counter == 3)
            {
                panikfertig();
            }
            else if (counter == 4)
            {
                aufgabeFortsetzen();
            }
            else if (counter == 5)
            {
                belohnungVorschlag();
            }
        }*/

    }

    public void panikabfrage()
    {
        stage++; // 2
        keywordManager.StopKeywordRecognizer();
        panik.Play();
        Debug.Log("Sag: help me");
    }

    public void panikaufgabe()
    {
        stage++; // 3
        keywordManager.StopKeywordRecognizer();
        FotoPanik.SetActive(true);
        übung.Play();
        Debug.Log("Sag: thanks");
    }

    public void panikfertig()
    {
        stage++; // 4
        keywordManager.StopKeywordRecognizer();
        FotoPanik.SetActive(false);
        panikDanach.Play();
        Debug.Log("Sag: yes");
    }

    public void aufgabeFortsetzen()
    {
        stage++; // 5
        keywordManager.StopKeywordRecognizer();
        angstDanach.Play();
        Debug.Log("Sag: ready");
    }

    public void belohnungVorschlag()
    {
        stage++; // 6
        keywordManager.StopKeywordRecognizer();
        belohnung.Play();
    }
}
