using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class InputManager : MonoBehaviour
{
    public GameObject BookPanel;
    public GameManager gameManager;

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
        SceneManager.LoadScene("Main");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }

    public void StartTutorial()
    {
        SceneManager.LoadScene("Tutorial");
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



}
