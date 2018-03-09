using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HA_Animation_Controller : MonoBehaviour {

    private ExerciseManager exerciseManager;

    Animator anim;

    int fliegen = Animator.StringToHash("Fliegen");
    int sitzen = Animator.StringToHash("Sitzen_Reden");
    int fliegtLos = Animator.StringToHash("Fliegt_Los");

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
        exerciseManager = GameObject.Find("Manager").GetComponent<ExerciseManager>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (exerciseManager.stage == 2)
        {
            anim.SetTrigger(fliegen);
        }

        if (exerciseManager.stage == 3)
        {
            anim.SetTrigger(sitzen);
        }

        if (exerciseManager.stage == 4)
        {
            anim.SetTrigger(fliegtLos);
        }

    }
}
