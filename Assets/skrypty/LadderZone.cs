﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderZone : MonoBehaviour {

    private movement thePlayer;

	// Use this for initialization
	void Start ()
    {
        thePlayer = FindObjectOfType<movement>();
	}

     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            thePlayer.onLadder = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            thePlayer.onLadder = false;
        }
    }
}
