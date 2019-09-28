using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class TutorialManager : MonoBehaviour
{
    [SerializeField] private string[] messages = new string[] { "Hello Hello", "Ree", "Hello again" };
    [SerializeField] private Texture[] images;
    [SerializeField] private int[] IncludeTimmyAt;

    [SerializeField] private GameObject btnForward;
    [SerializeField] private GameObject btnBackwards;
    [SerializeField] private GameObject imageHolder;
    [SerializeField] private GameObject TimmyHolder;

    private static int messageIndex = 0;
    private Text textField;    
    private Button b1;
    private Text b1Txt;
    private Button b2;
    

    RawImage img;

    // Start is called before the first frame update
    void Start()
    {

        textField = gameObject.GetComponent<Text>();
        textField.text = messages[0];

        b1 = btnForward.GetComponent<Button>();
        b1.onClick.AddListener(Forward);
        b1Txt = btnForward.GetComponentInChildren<Text>();

        b2 = btnBackwards.GetComponent<Button>();
        b2.onClick.AddListener(Backwards);

        img = imageHolder.GetComponent<RawImage>();
        ChangeUI();

    }


    public void Forward()
    {
        if (messageIndex < messages.Length - 1)
        {
            messageIndex++;
            ChangeUI();
        }else
            changeScene();
    }

    public void Backwards()
    {
        if (messageIndex > 0)
        {
            messageIndex--;
            ChangeUI();
        }

    }

    /*Se till att det alltid finns lika många element i indexHasImage som det finns messages or errors will fuck you in the ass*/
    public void ChangeUI()
    {
        textField.text = messages[messageIndex];

        if (IncludeTimmyAt.Contains(messageIndex))
            TimmyHolder.SetActive(true);
        else
            TimmyHolder.SetActive(false);


        if (messageIndex == messages.Length - 1)
            b1Txt.text = "I'm ready Rick!";


        if (images[messageIndex] != null)
        {
            imageHolder.SetActive(true);
            img.texture = images[messageIndex];
        }
        else
            imageHolder.SetActive(false);
    }

    void changeScene()
    {
        SceneManager.LoadScene("Main");
    }

}
