using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoeUnit : UnitController {
    public FoeEntity FoeData;

    public override void Initialize()
    {
        base.Initialize();
        CurrentHealth = FoeData.MaxHealthPoints;
    }

    
}
