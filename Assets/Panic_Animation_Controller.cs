using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panic_Animation_Controller : MonoBehaviour {

    private PanikManager panikManager;

    Animator anim;

    int fliegen = Animator.StringToHash("fliegen");

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        panikManager = GameObject.Find("Manager").GetComponent<PanikManager>();
    }
	
	// Update is called once per frame
	void Update () {
        if (panikManager.stage == 6)
        {
            anim.SetTrigger(fliegen);
        }
    }
}
