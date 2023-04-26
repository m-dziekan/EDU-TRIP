using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnStars : MonoBehaviour {

    public GameObject star;
    public float spawnTime;
    private float time;
    

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update ()
    {   
        time -= Time.deltaTime;
        if (time < 0)
        {
            Instantiate(star, transform.position, transform.rotation);
            time = spawnTime;
        }

        
    }
}
