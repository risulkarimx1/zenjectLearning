using UnityEngine;
using Zenject;

public class SceneContextInstaller : MonoInstaller
{
    [SerializeField] private AudioController _audioController;
    [SerializeField] private Enemy _enemy;
    public override void InstallBindings()
    {
        //Container.Bind<IAudioController>().To<AudioController>().AsSingle();
        //Container.BindInterfacesAndSelfTo<AudioController>().AsSingle();
        //Container.Bind<IAudioController>().FromInstance(_audioController).AsSingle();
        Container.BindInstance(_audioController);
        Container.Bind<Health>().AsTransient() ;
        Container.Bind<Enemy>().FromComponentInNewPrefab(_enemy).AsTransient();//.WithArguments(3, "Jojo");
    }
}