using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    private InitializationManager initializationManager;

    Animator anim;
    int move = Animator.StringToHash("UebergangEulenauswahl");

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();

        initializationManager = GameObject.Find("Manager").GetComponent<InitializationManager>();
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("initializationManager.stage: " + initializationManager.stage);

        if (initializationManager.stage == 2) {
            anim.SetTrigger(move);
        }
	}
}
