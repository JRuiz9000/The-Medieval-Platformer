using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectAudio : MonoBehaviour
{
    public AudioSource jumperClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
      {
           jumperClip.Play(); //Plays the sound on Space Key press
      } 
    }
}

