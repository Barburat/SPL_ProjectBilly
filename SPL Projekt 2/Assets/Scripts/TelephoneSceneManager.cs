﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelephoneSceneManager : MonoBehaviour
{

    int chances = 1; // vi kan skriva ut frågor tills chanses är slut (om spelaren svarar fel), sen kastas spelaren tbx när chanses är  0 och svaret är fel.
    public GameObject GoBackButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RightAnswer()
    {
        // print last comment from inventor, add button to go home. 
    }

    public void WrongAnswer()
    {
        if(chances == 0)
        {
            SceneManager.LoadScene("Main");
        }
        else
        {
            chances--;
            // print new question. And dissapointed comemnt from inventor
            
        }
    }


}