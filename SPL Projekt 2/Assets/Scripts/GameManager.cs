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

    

    void Start()
    {

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
            SceneManager.LoadScene("mainMenu");
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
