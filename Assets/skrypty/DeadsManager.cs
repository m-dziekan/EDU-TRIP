using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadsManager : MonoBehaviour {

    public static int numberOfDeaths;
    public Text Deaths;
    

    // Use this for initialization
    void Start()
    {
        int x = PlayerPrefs.GetInt("Score");
        numberOfDeaths = x;
        Deaths = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        Deaths.text = "" + numberOfDeaths;
    }

    public static void AddingPoints ()
    {
        numberOfDeaths = numberOfDeaths + 1;
        
    }

    public static void DeathsReset()
    {
        numberOfDeaths =0;

    }
}
