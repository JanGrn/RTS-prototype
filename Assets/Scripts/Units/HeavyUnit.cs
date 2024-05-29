using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyUnit : MeleeUnit {
    // Start is called before the first frame update
    void Start() {
        costModifier = 1.2f;
        attackSpeedModifier = .8f;
        attackDamageModifier = 1.0f;
        healthPointsModifier = 1.4f;
        attackRangeModifier = 1.0f;

        UpdateUnitStats();
    }

    // Update is called once per frame
    void Update() {

    }
}
