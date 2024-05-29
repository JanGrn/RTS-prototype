using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class Unit : MonoBehaviour
{
    // Every unit has an associated cost, HP value, attack damage, attack speed and attack range
    // TODO What should be the visibility of these fields? Remember we need to update them when techs are researched
    //      We could either make them visible to the outside (public) or include public functions to modify their values
    public float Cost = 10.0f;
    public float HealthPoints = 100.0f;
    public float AttackSpeed = 1.0f;
    public float AttackDamage = 20.0f;
    public float AttackRange = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
