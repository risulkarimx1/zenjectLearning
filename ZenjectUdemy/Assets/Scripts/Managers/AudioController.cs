using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioController : IAudioController
{
    float _volume;
    public float Volume
    {
        get => _volume;
        set
        {
            _volume = value;
        }
    }

    public void playDead()
    {
        Debug.Log($"Dead Sound with volume {_volume}");
    }

    public void PlayFire()
    {
        Debug.Log($"FireSound with {_volume}");
    }
}
