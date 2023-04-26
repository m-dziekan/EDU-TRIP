using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookPickup : MonoBehaviour {

    public int booksToAdd;
    public GameObject respawnParticle;
    private movement player;
    



    private void Start()
    {
        player = FindObjectOfType<movement>();
        booksToAdd = 1;
        
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<movement>()==false)
        {
            return;
        }

        if (other.GetComponent<movement>() == true)
        {
            booksManager.AddBook(booksToAdd);

            Instantiate(respawnParticle, player.transform.position, player.transform.rotation);
            Destroy(gameObject);
            
        }

        
    }
}
