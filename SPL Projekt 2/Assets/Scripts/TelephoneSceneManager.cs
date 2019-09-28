using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelephoneSceneManager : MonoBehaviour
{

    int chances = 1; // vi kan skriva ut frågor tills chanses är slut (om spelaren svarar fel), sen kastas spelaren tbx när chanses är  0 och svaret är fel.
    public GameObject GoBackButton;
    public Text InventorTalk;
    

    // Start is called before the first frame update
    void Start()
    {
        GoBackButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RightAnswer()
    {
        // print last comment from inventor, add button to go home. 
        InventorTalk.text = "You seem to know your shit. Here you go. ";
        GameObject.Find("GameManager").GetComponent<GameManager>().AddInvention("Telephone");
        GoBackButton.SetActive(true);
    }

    public void WrongAnswer()
    {
        if(chances == 0)
        {
            // inventor kicks you out
        }
        else
        {
            chances--;
            // print new question. And dissapointed comemnt from inventor
            
        }
    }


}
