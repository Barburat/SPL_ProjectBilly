using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelephoneSceneManager : MonoBehaviour
{
    
    public GameObject GoBackButton;
    public GameObject ContinueButton;
    public GameObject QuestionButton;
    public Text InventorTalk;
    public GameObject QuestionPanel;
    public string WrongFeedback;
    public string RightFeedback;
    public string[] Dialogue;
    public GameObject[] Questions;

    private int currentDialogue;
    private int currentQuestion;
    private GameManager gameManager;
    private Text questionText;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        questionText = QuestionPanel.GetComponentInChildren<Text>();
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
            Questions[currentQuestion].SetActive(true);
            //QuestionPanel.gameObject.SetActive(true);
        }
        else
        {
            currentDialogue++;
            InventorTalk.text = Dialogue[currentDialogue];
        }
    }

    public void NextQuestion()
    {
        Questions[currentQuestion].SetActive(false);
        currentQuestion++;
        Questions[currentQuestion].SetActive(true);
        QuestionButton.SetActive(false);
        
    }


    public void RightAnswer()
    {
        Debug.Log(Questions[currentQuestion].name);
        // print last comment from inventor, add button to go home. 
        InventorTalk.text = RightFeedback;
        //gameManager.AddInvention("Telephone");
        //GameManager.telephoneAcquired = true;
        if (Questions.Length == currentQuestion + 1)
        {
            gameManager.InventionAcquired(SceneManager.GetActiveScene().name);
            GoBackButton.SetActive(true);
            //QuestionPanel.SetActive(false);
        }
        else
        {
            
            QuestionButton.SetActive(true);
        }
        Questions[currentQuestion].SetActive(false);

    }

    public void WrongAnswer()
    {
        InventorTalk.text = WrongFeedback;
        GoBackButton.SetActive(true);
        //QuestionPanel.SetActive(false);
        Questions[currentQuestion].SetActive(false);
        ButtonScript.AddAttempt(SceneManager.GetActiveScene().name);

    }
}
