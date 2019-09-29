using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    public GameObject inputManager;
    public GameObject[] buttons;
    public GameObject selectedButton;
    public Text MentorText;
    public InputField inputField;
    public GameObject WrongYearPanel;
    public GameObject VictoryScreen;

    public static string LastVisitedScene;
    public static bool telephoneAcquired = false;
    public static bool vaccineAcquired = false;
    public static bool steamMachineAcquired = false;
    public static bool lightbulbAcquired = false;

    public Text UsesText;
    private int maximumUses = 20;
    public static int Uses;

    private ArrayList inventions = new ArrayList();


    private void Start()
    {
        Uses = maximumUses;
    }

    private void Update()
    {
        if (UsesText != null)
        {
            UsesText.text = "Uses: " + Uses + "/" + maximumUses;
        }
    }

    void OnLevelWasLoaded()
    {
        
        Debug.Log(LastVisitedScene);
        if(telephoneAcquired == true && vaccineAcquired == true && steamMachineAcquired == true && lightbulbAcquired == true)
        {
            VictoryScreen.SetActive(true);
        }

        if(buttons != null && LastVisitedScene != null && SceneManager.GetActiveScene().name == "Main")
        {
            if(LastVisitedScene == "TelephoneScene")
            {
                if (telephoneAcquired == true)
                {
                    buttons[0].GetComponent<Button>().interactable = false;
                    MentorText.text = "Great job Timmy! Choose another invention";
                }
                else
                {
                    Debug.Log(ButtonScript.phoneAttempts);
                    //changeTip(buttons[0]);
                    //fult
                    MentorText.text = buttons[0].GetComponent<ButtonScript>().mentorTips[ButtonScript.phoneAttempts - 1];
                }
            }
            if (LastVisitedScene == "VaccineScene")
            {
                if (vaccineAcquired == true)
                {
                    buttons[1].GetComponent<Button>().interactable = false;
                }
            }
            if (LastVisitedScene == "SteamScene")
            {
                if (steamMachineAcquired == true)
                {
                    buttons[2].GetComponent<Button>().interactable = false;
                }
            }
            if (LastVisitedScene == "LightbulbScene")
            {
                if (lightbulbAcquired == true)
                {
                    buttons[3].GetComponent<Button>().interactable = false;
                }
            }
        }
        
    }
    /* Metod för att skriva ut skit
    private void changeTip(GameObject button)
    {
        
    }
    */
    public void AddInvention(string name)
    {
        inventions.Add(name);
        Debug.Log("new item added");
    }



    public void StartTimeMachine()
    {
        if(selectedButton == null)
        {
            MentorText.text = "You need to select an invention first Billy!";
        }
        else if(inputField.text == "")
        {
            MentorText.text = "You need to select the year Billy!";
        }

        else if(selectedButton != null && selectedButton.GetComponent<ButtonScript>().CorrectYear == int.Parse(inputField.text))
        {
            Debug.Log("Correct input");
            Uses--;
            SceneManager.LoadScene(selectedButton.GetComponent<ButtonScript>().SceneIndex);
        }

        /*
        if(selectedButton.GetComponent<ButtonScript>().CorrectYear == year)
        {
            SceneManager.LoadScene(selectedButton.GetComponent<ButtonScript>().SceneIndex);
        }
        */
        else if (int.Parse(inputField.text) == 0) // MOTHERLOAD
        {
            inputManager.GetComponent<InputManager>().StartTutorial();
        }

        else if(int.Parse(inputField.text) != selectedButton.GetComponent<ButtonScript>().CorrectYear)
        {
            Uses--;
            WrongYearPanel.SetActive(true);
            wrongYearInput();
        }

        inputField.text = "";
    }

    private void wrongYearInput()
    {
        if(selectedButton != null)
        {
            MentorText.text = selectedButton.GetComponent<ButtonScript>().WrongYearTips[Random.Range(0, selectedButton.GetComponent<ButtonScript>().WrongYearTips.Length)];
        }
    }

    public void ResetVariables()
    {
        telephoneAcquired = false;
        vaccineAcquired = false;
        steamMachineAcquired = false;
        lightbulbAcquired = false;

        LastVisitedScene = null;

        ButtonScript.phoneAttempts = 0;
        ButtonScript.vaccineAttempts = 0;
        ButtonScript.steamAttempts = 0;
        ButtonScript.lightAttempts = 0;
}

}
