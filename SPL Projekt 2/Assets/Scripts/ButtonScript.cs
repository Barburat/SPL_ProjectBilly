﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameManager gameManager;
    public int CorrectYear;
    public int SceneIndex;
    public string InfoText;
    public string[] mentorTips;
    public string[] WrongYearTips;

    public static int phoneAttempts;
    public static int vaccineAttempts;
    public static int steamAttempts;
    public static int lightAttempts;
    
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(Clicked);
    }

    public void Clicked()
    {
        gameManager.selectedButton = this.gameObject;
        gameObject.GetComponent<Button>().Select();
        Debug.Log("Clicked " + gameObject.name);
        Debug.Log("Year: " + CorrectYear + " Scene Index: " + SceneIndex);
        gameManager.MentorText.text = InfoText;
    }

    public static void AddAttempt(string name)
    {
        switch (name)
        {
            case "TelephoneScene":
                phoneAttempts++;
                break;
            case "VaccineScene":
                vaccineAttempts++;
                break;
            case "SteamScene":
                steamAttempts++;
                break;
            case "LightbulbScene":
                lightAttempts++;
                break;
        }
    }
}
