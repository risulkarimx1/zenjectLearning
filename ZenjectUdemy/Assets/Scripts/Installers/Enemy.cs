using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Enemy : MonoBehaviour
{
    [Inject] private Enemy.EnemySettings settings;
    [Serializable]
    public class EnemySettings
    {
        public float Speed, Health, ActionPoints, Stamina;
    }
}
