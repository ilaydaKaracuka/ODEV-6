using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volume : MonoBehaviour    //bu scripti ilk sahnede main camera(sesin old. obje),2.sahnede image (sesin old. obje) objesine att�m
{
    private AudioSource audioSrc;

    private float musicVolume = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        audioSrc.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}