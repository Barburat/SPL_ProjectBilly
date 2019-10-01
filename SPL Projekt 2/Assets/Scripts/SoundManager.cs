using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;


public class SoundManager : MonoBehaviour
{
    private AudioSource AudioPlayer;

    //public AudioClip main;
    public AudioClip vaccine;
    public AudioClip steam;
    public AudioClip telephone;
    public AudioClip lamp;

    // Start is called before the first frame update
    void Start()
    {
        AudioPlayer = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    
    /*
    public void playMainSoundtrack()
    {
        AudioPlayer.PlayOneShot(main);
    }
    */ 

    public void playVaccine()
    {
        AudioPlayer.PlayOneShot(vaccine);
    }

    public void playSteam()
    {
        AudioPlayer.PlayOneShot(steam);
    }
    public void playTelephone()
    {
        AudioPlayer.PlayOneShot(telephone);
    }
    public void playlamp()
    {
        AudioPlayer.PlayOneShot(lamp);
    }




}
