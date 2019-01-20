using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SimpleInstaller : Installer<GameObject, SimpleInstaller>
{
    [Inject]GameObject _playerPrefab;
    public override void InstallBindings()
    {
        Container.Bind<Player>().FromComponentInNewPrefab(_playerPrefab).AsTransient();
    }
}
