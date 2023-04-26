using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class load : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {



        float x= PlayerPrefs.GetFloat("PlayerX");
        float y = PlayerPrefs.GetFloat("PlayerY");
        transform.position = new Vector3(x, y, 0);


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
