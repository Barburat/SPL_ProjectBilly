using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookScript : MonoBehaviour
{

    public string[] Entries = new string[5];
    public Texture[] pics = new Texture[5];
    private int bookIndex = 0;
    public Text textfield;
    public RawImage imagefield;

    // save image and at waht bookpage (bookindex) the should show
    //public Dictionary<int, Texture> images = new Dictionary<int, Texture>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextEntry()
    {
        
        if (bookIndex == 4)
        {
            return;
            //bookIndex = 0;
        }
        bookIndex++;
        textfield.text = Entries[bookIndex];
        showImage(bookIndex);
        
    }

    public void PreviousEntry()
    {
        
        if (bookIndex == 0)
        {
            return;
            //bookIndex = 5;
        }
        bookIndex--;
        textfield.text = Entries[bookIndex];
        showImage(bookIndex);
        
    }

    private void showImage(int index)
    {

        imagefield.texture = pics[index];

        /*
        if (images.ContainsKey(index))
        {
            imagefield.texture = images[index];
        }
        */
    }


}
