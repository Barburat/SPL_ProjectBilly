using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelephoneSceneManager : MonoBehaviour
{
    
    public GameObject GoBackButton;
    public GameObject ContinueButton;
    public Text InventorTalk;
    public GameObject QuestionPanel;
    public string[] Dialogue;
    private int currentDialogue;
    private GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        GoBackButton.SetActive(false);
        QuestionPanel.gameObject.SetActive(false);
        if (Dialogue != null)
        {
            InventorTalk.text = Dialogue[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Continue()
    {

        if (currentDialogue == Dialogue.Length - 1)
        {
            ContinueButton.SetActive(false);
            QuestionPanel.gameObject.SetActive(true);
        }
        else
        {
            currentDialogue++;
            InventorTalk.text = Dialogue[currentDialogue];
        }
    }


    public void RightAnswer()
    {
        // print last comment from inventor, add button to go home. 
        InventorTalk.text = "You seem to know your shit. Here you go. ";
        gameManager.AddInvention("Telephone");
        GameManager.telephoneAcquired = true;
        GoBackButton.SetActive(true);
        QuestionPanel.SetActive(false);

    }

    public void WrongAnswer()
    {
        InventorTalk.text = "Bah! Do you really think i would give away my precious to an uneducated scoundrel like yourself? Get out of my sight!";
        GoBackButton.SetActive(true);
        QuestionPanel.SetActive(false);
        ButtonScript.phoneAttempts++;

    }


}
