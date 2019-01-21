using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health
{
    public float Healthvalue { get; set; }
    public void ReduceHealth()
    {
        Debug.Log("Reducing health");
    }
}
