using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class booksFinalScore : MonoBehaviour {

    public TextMeshProUGUI tekst;

	// Use this for initialization
	void Start () {
        int y = PlayerPrefs.GetInt("Books");
        tekst = GetComponent<TextMeshProUGUI>();
        tekst.text="" + y;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
