using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    private static int messageIndex = 0;
    [SerializeField] private string[] messages = new string[] { "Hello Hello", "Ree", "Hello again" };
    [SerializeField] private Texture[] images;
    [SerializeField] private bool[] indexHasImage;

    private Text textField;

    [SerializeField] private GameObject btnForward;
    [SerializeField] private GameObject btnBackwards;
    [SerializeField] private GameObject imageHolder;

    Button b1;
    Button b2;

    RawImage img;

    // Start is called before the first frame update
    void Start()
    {

        textField = gameObject.GetComponent<Text>();
        textField.text = messages[0];

        b1 = btnForward.GetComponent<Button>();
        b1.onClick.AddListener(Forward);

        b2 = btnBackwards.GetComponent<Button>();
        b2.onClick.AddListener(Backwards);

        img = imageHolder.GetComponent<RawImage>();
        img.texture = images[messageIndex];

    }


    public void Forward()
    {
        if (messageIndex < messages.Length-1)
        {
            messageIndex++;
            ChangeUI();
        }
        else
        {
            //changeScene();
        }

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
        if (indexHasImage[messageIndex])
            img.texture = images[messageIndex];

        Debug.Log(messageIndex);

    }


    void changeScene()
    {
        SceneManager.LoadScene(0);
        //remove listeners
    }

}
