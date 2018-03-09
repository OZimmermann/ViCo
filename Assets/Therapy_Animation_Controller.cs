using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Therapy_Animation_Controller : MonoBehaviour {

    private TherapyTaskManager therapyTaskManager;

    Animator anim;

    int fliegen = Animator.StringToHash("Fliegen");

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        therapyTaskManager = GameObject.Find("Manager").GetComponent<TherapyTaskManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (therapyTaskManager.stage == 3)
        {
            anim.SetTrigger(fliegen);
        }
    }
}
