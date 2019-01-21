using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Enemy: MonoBehaviour
{
    private int _aggression;
    private string _name;
    private Health _health;
    //[Inject]
    //public void Construct(int aggressionLevel,Health health,string EnemyName)
    //{
    //    _aggression = aggressionLevel;
    //    _name = EnemyName;
    //    _health = health;
    //}
    //public void PrintStatus()
    //{
    //    Debug.Log($"aggression is {_aggression}. Health is {_health.Healthvalue} and name is {_name}");
    //    _health.ReduceHealth();
    //}
}
