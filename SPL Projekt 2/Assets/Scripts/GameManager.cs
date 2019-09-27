using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject[] buttons;
    [HideInInspector] public Button selectedButton;


    public void StartTimeMachine(int year)
    {
        if(selectedButton.GetComponent<ButtonScript>().CorrectYear == year)
        {
            SceneManager.LoadScene(selectedButton.GetComponent<ButtonScript>().SceneIndex);
        }
        else
        {
            SceneManager.LoadScene("WrongYear");
        }
    }
}
