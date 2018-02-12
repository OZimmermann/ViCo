using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {
	TextMesh textMesh;
	// Use this for initialization
	void Start () {
		textMesh = GetComponent<TextMesh> ();
	}
	
	// Update is called once per frame
	public void blue () {
		textMesh.color = Color.blue;
	}

	public void red () {
		textMesh.color = Color.red;
	}

	public void green () {
		textMesh.color = Color.green;
	}
}
