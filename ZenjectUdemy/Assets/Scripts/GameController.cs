using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameController : MonoBehaviour
{
    [Inject]
    AudioController audioController;
    [Inject] Enemy enemy;
    // Start is called before the first frame update
    void Start()
    {
        audioController.playDead();
        //enemy.PrintStatus();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
