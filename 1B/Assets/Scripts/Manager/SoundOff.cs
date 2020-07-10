using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOff : MonoBehaviour
{

    [SerializeField] GameObject cameraListener;

    AudioSource mySource;
    bool soundOff;

    public void TurnSoundOff()
    {
        soundOff = !soundOff;
        mySource = cameraListener.GetComponent<AudioSource>();

        if (soundOff == true)
        {
        mySource.volume = 0;
        }
        if (soundOff == false)
        {
            mySource.volume = 0.25f;
        }
    }



}
