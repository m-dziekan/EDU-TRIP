using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour {

    public AudioSource enemyDeath;
    public float bounceOnEnemy;
    private Rigidbody2D myRigidbody;

	// Use this for initialization
	void Start ()
    {
        myRigidbody = transform.parent.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="enemyToKill")
        {
            enemyDeath.Play();
            Destroy(other.gameObject);
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, bounceOnEnemy);
            
        }
    }
}
