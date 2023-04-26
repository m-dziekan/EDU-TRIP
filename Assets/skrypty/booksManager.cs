using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class booksManager : MonoBehaviour {

    public static int books;
    Text tekst;
    
    // Use this for initialization
	void Start ()
    {
        tekst = GetComponent<Text>();
        int y = PlayerPrefs.GetInt("Books");
        books = y;
    }
	
	// Update is called once per frame
	void Update ()
    {
        

        tekst.text = "" + books;
	}

    public static void AddBook(int booksToAdd)
    {
        books += booksToAdd;
        PlayerPrefs.SetInt("Books", booksManager.books);
    }

    public static void BooksReset()
    {
        books = 0;
    }
}
