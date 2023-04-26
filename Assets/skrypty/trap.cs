using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour {

    public GameObject[] spike;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        spike[0].SetActive(true);
        spike[1].SetActive(true);
        spike[2].SetActive(true);
        spike[3].SetActive(true);
        spike[4].SetActive(true);
        spike[5].SetActive(true);
        spike[6].SetActive(true);
        

    }
}
