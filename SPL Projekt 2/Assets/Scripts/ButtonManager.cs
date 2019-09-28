using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

//poopy code
public class ButtonManager : MonoBehaviour
{
    public GameManager gameManager;

    public Button b1;
    public Button b2;
    public Button b3;
    public Button b4;

    void Start()
    {
        
    }

    /*
    public void FirstInvention()
    {
        EventSystem.current.currentSelectedGameObject.GetComponent<Button>().Select();
        gameManager.selectedButton = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
    }
    public void SecondInvention()
    {
        EventSystem.current.currentSelectedGameObject.GetComponent<Button>().Select();
        gameManager.selectedButton = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
    }
    public void ThirdInvention()
    {
        EventSystem.current.currentSelectedGameObject.GetComponent<Button>().Select();
        gameManager.selectedButton = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
    }
    public void FourthInvention()
    {
        EventSystem.current.currentSelectedGameObject.GetComponent<Button>().Select();
        gameManager.selectedButton = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
    }

    */
}
