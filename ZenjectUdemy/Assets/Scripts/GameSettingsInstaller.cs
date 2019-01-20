using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "GameSettingsInstaller", menuName = "Installers/GameSettingsInstaller")]
public class GameSettingsInstaller : ScriptableObjectInstaller<GameSettingsInstaller>
{
    [SerializeField] private Player player;
    [SerializeField]private Enemy.EnemySettings _enemySettings;
    public override void InstallBindings()
    {
        Container.BindInstance(_enemySettings).AsSingle();
        Container.BindInstance(player).AsSingle();

    }
}