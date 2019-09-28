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

    void Start()
    {
        
    }

    public void StartTimeMachine(int year)
    {
        if(selectedButton != null && selectedButton.GetComponent<ButtonScript>().CorrectYear == year)
        {
            SceneManager.LoadScene("Tutorial");
        }

        /*
        if(selectedButton.GetComponent<ButtonScript>().CorrectYear == year)
        {
            SceneManager.LoadScene(selectedButton.GetComponent<ButtonScript>().SceneIndex);
        }
        */
        if(year == 0) // MOTHERLOAD
        {
            inputManager.GetComponent<InputManager>().StartTutorial();
        }
        else
        {
            SceneManager.LoadScene("WrongYear");
        }
    }
}
