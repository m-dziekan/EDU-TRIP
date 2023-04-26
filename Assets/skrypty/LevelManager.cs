using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {


    public GameObject currentCheckpoint;
    private movement player;
    public GameObject deathParticle;
    public GameObject respawnParticle;
    public float respawnDelay;
    private smooothcamerafollow camera;
    
    
    //private float startGravityValue;

    // Use this for initialization
    void Start ()
    {
        player = FindObjectOfType<movement>();
        camera= FindObjectOfType<smooothcamerafollow>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }
    
    public IEnumerator RespawnPlayerCo()
    {
        Instantiate(deathParticle, player.transform.position, player.transform.rotation);
        player.GetComponent<BoxCollider2D>().enabled = false;
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        camera.isfollowing = false;
        //startGravityValue = player.GetComponent<Rigidbody2D>().gravityScale;
        //player.GetComponent<Rigidbody2D>().gravityScale = 0f;   
        //player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        Debug.Log("Player Respawn");
        yield return new WaitForSeconds(respawnDelay);
       // player.GetComponent<Rigidbody2D>().gravityScale = startGravityValue;
        player.transform.position = currentCheckpoint.transform.position;
        player.GetComponent<BoxCollider2D>().enabled = true;
        player.enabled = true;
        player.transform.parent = null;
        camera.isfollowing = true;
        player.GetComponent<Renderer>().enabled = true;
        DeadsManager.AddingPoints();
        PlayerPrefs.SetInt("Score", DeadsManager.numberOfDeaths);
        SceneManager.LoadScene("Poziom1");
        
        
    }
}
