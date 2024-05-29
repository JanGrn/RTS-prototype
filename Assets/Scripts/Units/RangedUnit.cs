using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedUnit : Unit {
    // Start is called before the first frame update
    void Start() {
        costModifier = 1.0f;
        attackSpeedModifier = 1.0f;
        attackDamageModifier = 1.0f;
        healthPointsModifier = 1.0f;
        attackRangeModifier = 3.0f;

        UpdateUnitStats();
    }

    // Update is called once per frame
    void Update() {

    }
}
