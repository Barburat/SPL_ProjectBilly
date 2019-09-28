using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelephoneSceneManager : MonoBehaviour
{

    public GameObject GoBackButton;
    public Text InventorTalk;
    public GameObject QuestionPanel;
    

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
        QuestionPanel.SetActive(false);

    }

    public void WrongAnswer()
    {
        InventorTalk.text = "Bah! Do you really think i would give away my precious to an uneducated scoundrel like yourself? Get out of my sight!";
        GoBackButton.SetActive(true);
        QuestionPanel.SetActive(false);
    }


}
