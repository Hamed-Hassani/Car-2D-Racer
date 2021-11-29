using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource takeOff, acceleration;

    void Start()
    {
        
    }

    void TurnOnAcceleration()
    {
        takeOff.Stop();
        acceleration.Play();
    }
}
