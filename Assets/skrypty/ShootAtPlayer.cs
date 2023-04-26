using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtPlayer : MonoBehaviour {

    public float playerRange;
    public GameObject enemyStar;
    public movement player;
    public Transform launchPoint;
    
    // Use this for initialization
	void Start ()
    {
        player = FindObjectOfType<movement>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.DrawLine(new Vector3(transform.position.x - playerRange, transform.position.y, transform.position.z), new Vector3(transform.position.x + playerRange, transform.position.y, transform.position.z));

        if (transform.localScale.x < 0 && player.transform.position.x > transform.position.x && player.transform.position.x < transform.position.x + playerRange)
        {
            Instantiate(enemyStar, launchPoint.position, launchPoint.rotation);
        }

        if (transform.localScale.x > 0 && player.transform.position.x < transform.position.x && player.transform.position.x > transform.position.x + playerRange)
        {
            Instantiate(enemyStar, launchPoint.position, launchPoint.rotation);
        }
    }
}
