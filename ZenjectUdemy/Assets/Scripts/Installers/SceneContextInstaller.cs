using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SceneContextInstaller : MonoInstaller<SceneContextInstaller>
{
    public override void InstallBindings()
    {
        Container.Bind<IAudioController>().To<AudioController>().AsSingle();
    }
}
