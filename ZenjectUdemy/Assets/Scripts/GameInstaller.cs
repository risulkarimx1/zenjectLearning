using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private GameObject _playerPrefab;

    public override void InstallBindings()
    {
        Container.Bind<Player>().
            FromComponentInNewPrefab(_playerPrefab).AsTransient();
    }
   
}
