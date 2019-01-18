using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameController : MonoBehaviour
{
    [Inject] Player player;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(player.GetLocation());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
