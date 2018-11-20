using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorsePicture : MonoBehaviour {
    // Use this for initialization
    private AudioSource ac;
	void Start () {
        ac = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
 	// For when the picture is clicked - hopefully
	private void OnMouseDown() {
        ac.Play();
	}
}