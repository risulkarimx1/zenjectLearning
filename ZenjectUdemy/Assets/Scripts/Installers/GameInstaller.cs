using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private GameObject _playerPrefab;

    public override void InstallBindings()
    {
        SimpleInstaller.Install(Container, _playerPrefab);
        
    }
   
}
