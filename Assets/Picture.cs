using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// For when the picture is clicked - hopefully
	private void OnMouseDown() {
		Application.OpenURL("https://www.google.co.uk/maps/place/35%C2%B042'14.7%22N+139%C2%B033'27.8%22E/@35.7040744,139.5577317,3a,75y,287.1h,74.05t/data=!3m6!1e1!3m4!1sgT28ssf0BB2LxZ63JNcL1w!2e0!7i13312!8i6656!4m5!3m4!1s0x0:0x0!8m2!3d35.7040744!4d139.5577317");
	}
}
