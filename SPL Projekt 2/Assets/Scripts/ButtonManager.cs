using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ButtonManager : MonoBehaviour
{
    public void FirstInvention()
    {
        EventSystem.current.currentSelectedGameObject.GetComponent<Button>().Select();
        
    }
    public void SecondInvention()
    {
        EventSystem.current.currentSelectedGameObject.GetComponent<Button>().Select();
    }
    public void ThirdInvention()
    {
        EventSystem.current.currentSelectedGameObject.GetComponent<Button>().Select();
    }
    public void FourthInvention()
    {
        EventSystem.current.currentSelectedGameObject.GetComponent<Button>().Select();
    }


}
