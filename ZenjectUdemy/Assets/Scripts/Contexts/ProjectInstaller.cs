using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ProjectInstaller : MonoInstaller
{
    [SerializeField] private Player player;
    [SerializeField] private Enemy.EnemySettings _enemySettings;
    public override void InstallBindings()
    {
        Container.BindInstance(_enemySettings).AsSingle();
        Container.BindInstance(player).AsSingle();

    }
}
