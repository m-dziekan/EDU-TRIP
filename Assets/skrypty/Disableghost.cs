﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disableghost : MonoBehaviour {

    public GameObject ghost;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        ghost.SetActive(false);
        


    }
}
