using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class save : MonoBehaviour {
    private GameObject player;

	public void SavePosition()
    {
        PlayerPrefs.SetFloat("PlayerX", FindObjectOfType<movement>().transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", FindObjectOfType<movement>().transform.position.y);
       
    }

    
    
    
}
