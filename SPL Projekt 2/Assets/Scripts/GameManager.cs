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
    public GameObject DefeatScreen;

    public static string LastVisitedScene;
    public static bool telephoneAcquired;
    public static bool vaccineAcquired;
    public static bool steamMachineAcquired;
    public static bool lightbulbAcquired;

    public Text UsesText;
    private int maximumUses = 10;
    public static int Uses = 10;

    private ArrayList inventions = new ArrayList();


    private void Start()
    {
        
    }

    private void Update()
    {
        if(DefeatScreen != null && Uses <= 0)
        {
            DefeatScreen.SetActive(true);
        }
        if (UsesText != null)
        {
            UsesText.text = "Användningar: " + Uses + "/" + maximumUses;
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
            deactivateInventions();

            if(LastVisitedScene == "TelephoneScene")
            {
                if (telephoneAcquired == true)
                {
                    buttons[0].GetComponent<Button>().interactable = false;
                    MentorText.text = "Bra jobbat Timmy! Välj en ny uppfinning";
                }
                else if(Uses <= 0)
                {
                    DefeatScreen.SetActive(true);
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
                else if (Uses <= 0)
                {
                    DefeatScreen.SetActive(true);
                }
                else
                {
                    MentorText.text = buttons[1].GetComponent<ButtonScript>().mentorTips[ButtonScript.vaccineAttempts - 1];
                }
            }
            if (LastVisitedScene == "SteamScene")
            {
                if (steamMachineAcquired == true)
                {
                    buttons[2].GetComponent<Button>().interactable = false;
                }
                else if (Uses <= 0)
                {
                    DefeatScreen.SetActive(true);
                }
                else
                {
                    MentorText.text = buttons[2].GetComponent<ButtonScript>().mentorTips[ButtonScript.steamAttempts - 1];
                }
            }
            if (LastVisitedScene == "LightbulbScene")
            {
                if (lightbulbAcquired == true)
                {
                    buttons[3].GetComponent<Button>().interactable = false;
                }
                else if (Uses <= 0)
                {
                    DefeatScreen.SetActive(true);
                }
                else
                {
                    MentorText.text = buttons[3].GetComponent<ButtonScript>().mentorTips[ButtonScript.lightAttempts - 1];
                }
            }
            Debug.Log(telephoneAcquired + " " + vaccineAcquired + " " + steamMachineAcquired + " " + lightbulbAcquired);
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
        if (selectedButton == null)
        {
            MentorText.text = "Du måste välja en uppfinning först Timmy!";
        }
        else if (inputField.text == "")
        {
            MentorText.text = "Du måste ange vilket århundrade du ska åka till i kontrollpanelen först!";
        }
        else if (selectedButton != null && inputField.text != "")
        {
            int year = selectedButton.GetComponent<ButtonScript>().CorrectYear;
            int input = int.Parse(inputField.text);
        
            if (selectedButton != null && year == (input - (input % 100)))
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

            else if (input != selectedButton.GetComponent<ButtonScript>().CorrectYear)
            {
                Uses--;
                WrongYearPanel.SetActive(true);
                wrongYearInput();
            }
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

    public void InventionAcquired(string name)
    {
        switch (name)
        {
            case "TelephoneScene":
                telephoneAcquired = true;
                break;
            case "VaccineScene":
                vaccineAcquired = true;
                break;
            case "SteamScene":
                steamMachineAcquired = true;
                break;
            case "LightbulbScene":
                lightbulbAcquired = true;
                break;
        }
    }
    
    private void deactivateInventions()
    {
        if(telephoneAcquired == true)
        {
            buttons[0].GetComponent<Button>().interactable = false;
        }
        if (vaccineAcquired == true)
        {
            buttons[1].GetComponent<Button>().interactable = false;
        }
        if (steamMachineAcquired == true)
        {
            buttons[2].GetComponent<Button>().interactable = false;
        }
        if (lightbulbAcquired == true)
        {
            buttons[3].GetComponent<Button>().interactable = false;
        }
    }


    public void ResetVariables()
    {
        telephoneAcquired = false;
        vaccineAcquired = false;
        steamMachineAcquired = false;
        lightbulbAcquired = false;

        LastVisitedScene = null;
        Uses = maximumUses;

        ButtonScript.phoneAttempts = 0;
        ButtonScript.vaccineAttempts = 0;
        ButtonScript.steamAttempts = 0;
        ButtonScript.lightAttempts = 0;
}

}
