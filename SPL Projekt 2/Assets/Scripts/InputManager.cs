﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class InputManager : MonoBehaviour
{
    public GameObject BookPanel;
    public GameManager gameManager;
    public GameObject WrongYearPanel;
    public GameObject creditsPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        GameManager.LastVisitedScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Main");
    }

    public void MainMenu()
    {
        GameManager.LastVisitedScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("mainMenu");
    }

    public void StartTutorial()
    {
        GameManager.LastVisitedScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Tutorial");
    }

    public void RestartGame()
    {
        gameManager.ResetVariables();
        SceneManager.LoadScene("mainMenu");
    }


    public void SubmitInput()
    {
        gameManager.StartTimeMachine();
    }
   

    public void OpenBook()
    {
        BookPanel.SetActive(true);
    }

    public void CloseBook()
    {
        BookPanel.SetActive(false);
    }

    public void WrongYear()
    {
        WrongYearPanel.SetActive(false);
    }

    public void ToggleCredits()
    {
        if (creditsPanel.active == false)
        {
            creditsPanel.SetActive(true);
        }
        else
        {
            creditsPanel.SetActive(false);
        }
        
    }

}
