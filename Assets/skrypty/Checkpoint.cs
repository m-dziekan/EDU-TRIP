using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    public LevelManager levelManager;

    // Use this for initialization
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            levelManager.currentCheckpoint = gameObject;
            Debug.Log("nowy chceckpoint aktywowany!");
            PlayerPrefs.SetFloat("PlayerX", FindObjectOfType<movement>().transform.position.x);
            PlayerPrefs.SetFloat("PlayerY", FindObjectOfType<movement>().transform.position.y);
        }
    }
}
