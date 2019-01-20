using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameController : MonoBehaviour
{
    //[Inject]Enemy.EnemySettings enemy;
    //[Inject] Player player;
    // Start is called before the first frame update
    [Inject]
    IAudioController audioController;
    void Start()
    {
        //Debug.Log(enemy.Speed);
        //Debug.Log(player.GetLocation());
        audioController.playDead();
    }
        
}
