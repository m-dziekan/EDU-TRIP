using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadnewGame : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        transform.position = new Vector3(-4.46f, 1.94f, 0);

        PlayerPrefs.SetInt("Books", 0);

        PlayerPrefs.SetInt("Score", 0);
        DeadsManager.DeathsReset();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
