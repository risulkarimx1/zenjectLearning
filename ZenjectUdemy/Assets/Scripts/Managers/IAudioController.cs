using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IAudioController
{
    float Volume { get; set; }
    void PlayFire();
    void playDead();
}
