using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    private static int messageIndex = 0;
    [SerializeField] private string[] messages = new string[] { "Hello Hello", "Ree", "Hello again" };
    private Text textField;
    [SerializeField] private GameObject btnForward;
    [SerializeField] private GameObject btnBackwards;

    Button b1;
    Button b2;

    // Start is called before the first frame update
    void Start()
    {
        textField = gameObject.GetComponent<Text>();
        textField.text = messages[0];

        b1 = btnForward.GetComponent<Button>();
        b1.onClick.AddListener(Forward);

        b2 = btnBackwards.GetComponent<Button>();
        b2.onClick.AddListener(Backwards);
    }


    public void Forward()
    {
        if (messageIndex < messages.Length)
        {
            messageIndex++;
            ChangeMessage();
        }
        else
        {
            //changeScene();
        }

    }

    public void Backwards()
    {
        if(messageIndex > 0)
        {
            messageIndex--;
            ChangeMessage();
        }

    }

    public void ChangeMessage()
    {
        textField.text = messages[messageIndex];
    }


    void changeScene()
    {
        SceneManager.LoadScene(0);
        //remove listeners
    }

}
