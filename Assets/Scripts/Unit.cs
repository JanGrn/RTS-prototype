using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    // Every unit has an associated cost, HP value, attack damage, attack speed and attack range
    private float m_Cost;
    public float Cost { 
        get {  return m_Cost; }
        protected set { m_Cost = value; } 
    }

    private float m_HealthPoints;
    public float HealthPoints {
        get { return m_HealthPoints; }
        protected set { m_HealthPoints = value; }
    }

    private float m_AttackSpeed;
    public float AttackSpeed {
        get { return m_AttackSpeed; }
        protected set { m_AttackSpeed = value; }
    }

    private float m_AttackDamage;
    public float AttackDamage {
        get { return m_AttackDamage; }
        protected set { m_AttackDamage = value; }
    }

    private float m_AttackRange;
    public float AttackRange {
        get { return m_AttackRange; }
        protected set { m_AttackRange = value; }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
