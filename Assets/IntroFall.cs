﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroFall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.y > -0.95f)
        {
            transform.Translate(0.0f, -2.5f * Time.deltaTime, 0.0f, Space.World);
        }
        
		
	}
}
