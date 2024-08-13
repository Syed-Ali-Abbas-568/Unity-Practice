using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{

    private AudioSource bgMusic;
    private AudioSource[] effects;
    private Slider volumeSlider;
    
        void Start()
    {
        volumeSlider=gameObject.GetComponent<Slider>();
        bgMusic=GameObject.Find("Main Camera").GetComponent<AudioSource>();
        effects=GameObject.Find("Audio Manager").GetComponents<AudioSource>();

    }

    void Update(){
        bgMusic.volume=volumeSlider.value;

        foreach(var effect in effects){
            effect.volume=volumeSlider.value;
        }
    

    }


    



}
