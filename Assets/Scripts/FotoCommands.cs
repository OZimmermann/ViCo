using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FotoCommands : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        var gazeDirection = Camera.main.transform.forward;

        this.transform.position = gazeDirection;

        Quaternion toQuat = Camera.main.transform.localRotation;
        toQuat.x = 0;
        toQuat.z = 0;
        this.transform.rotation = toQuat;
    }
}
