﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.y > 0.6f){
			transform.Translate (0, -2.5f * Time.deltaTime, 0, Space.World);
		
		}
	}
}
