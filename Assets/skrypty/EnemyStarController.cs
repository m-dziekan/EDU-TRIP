using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStarController : MonoBehaviour {

    public float speed;
    public movement player;
    
    public LevelManager levelManager;
    public float rotationSpeed;
    private Rigidbody2D myrigidbody2D;

    
    private float liveTime;
    public float timeOfLiving;
    public bool lewo;


    // Use this for initialization
    void Start ()
    {
        player = FindObjectOfType<movement>();
        myrigidbody2D = GetComponent<Rigidbody2D>();
        levelManager = FindObjectOfType<LevelManager>();

        
        liveTime = timeOfLiving;



        if (lewo == true) 
        {
            speed = -speed;
            rotationSpeed = -rotationSpeed;

        }
       
        else
           {
            speed = speed;
            rotationSpeed = rotationSpeed;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        myrigidbody2D.velocity = new Vector2(speed, myrigidbody2D.velocity.y);
        myrigidbody2D.angularVelocity = rotationSpeed;


        liveTime -= Time.deltaTime;
        if (liveTime < 0)
        {
            Destroy(gameObject);
            liveTime = timeOfLiving;
        }

    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        if(other.name=="Player")
        {
            levelManager.RespawnPlayer();
        }


        
    }
}
