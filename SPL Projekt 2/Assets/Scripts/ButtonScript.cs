using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameManager gameManager;
    public SoundManager sound;
    public int CorrectYear;
    public int SceneIndex;
    public string InfoText;
    public string[] mentorTips;
    public string[] WrongYearTips;

    public static int phoneAttempts;
    public static int vaccineAttempts;
    public static int steamAttempts;
    public static int lightAttempts;
    
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(Clicked);
    }

    public void Clicked()
    {
        gameManager.selectedButton = this.gameObject;
        gameObject.GetComponent<Button>().Select();
        Debug.Log("Clicked " + gameObject.name);
        Debug.Log("Year: " + CorrectYear + " Scene Index: " + SceneIndex);
        gameManager.MentorText.text = InfoText;
        playSoundEffect();
    }

    public static void AddAttempt(string name)
    {
        switch (name)
        {
            case "TelephoneScene":
                phoneAttempts++;
                break;
            case "VaccineScene":
                vaccineAttempts++;
                break;
            case "SteamScene":
                steamAttempts++;
                break;
            case "LightbulbScene":
                lightAttempts++;
                break;
        }
    }

    private void playSoundEffect()
    {
        if (this.gameObject.name == "Invention1") // telefon
        {
            sound.playTelephone();
        }
        if (this.gameObject.name == "Invention2") // vaccin
        {
            sound.playVaccine();
        }
        if (this.gameObject.name == "Invention3") // steam
        {
            sound.playSteam();
        }
        if (this.gameObject.name == "Invention4") // lampa
        {
            sound.playlamp();
        }

    }

}
