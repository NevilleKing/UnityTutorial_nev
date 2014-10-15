﻿using UnityEngine;
using System.Collections;

public class ColourChange : MonoBehaviour {

	bool onFloor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "floor"){
			this.renderer.material.color = new Color(0,1,0);
			onFloor = true;
		}
	}
}
