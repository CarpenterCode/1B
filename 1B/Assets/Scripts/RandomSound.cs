using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSound : MonoBehaviour
{
    [SerializeField] AudioClip[] myClips;
    [SerializeField] AudioSource mySource;


    private void Start()
    {
        PlayRandomSound();
    }

    void PlayRandomSound()
    {
        mySource.clip = myClips[Random.Range(0, myClips.Length)];
        mySource.Play();
    }



}
