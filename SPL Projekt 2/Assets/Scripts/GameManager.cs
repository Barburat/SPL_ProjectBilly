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

    public static bool telephoneAcquired = false;
    public static bool vaccineAcquired = false;
    public static bool steamMachineAcquired = false;
    public static bool lightbulbAcquired = false;

    private ArrayList inventions = new ArrayList();
    




    void OnLevelWasLoaded()
    {
        if(buttons != null)
        {
            if (telephoneAcquired == true)
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
        
    }

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
    }
}
