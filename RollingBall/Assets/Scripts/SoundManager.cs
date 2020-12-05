using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip soundCoin;
    AudioSource myAudio;
    
    public static SoundManager instance;

    void Awake()
    {
        if(SoundManager.instance == null)
        SoundManager.instance = this;
    }    
    
    void Start()
    {
        myAudio = GetComponent<AudioSource>();   
    }

    public void PlaySound()
    {
        myAudio.PlayOneShot(soundCoin);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
