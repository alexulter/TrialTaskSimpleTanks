using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour {

    public float CurrentHealth;
    public UnitEntity UnitData;
    public bool IsAlive { get { return gameObject.activeSelf; } }

    private void Start()
    {
        Initialize();
    }

    public virtual void Initialize()
    {
        gameObject.SetActive(true);
    }

    public void RecieveDamage(float rawDamage)
    {
        if (UnitData.Defence < 0) return;
        var damage = rawDamage/(1+UnitData.Defence);
        if (damage > 0)
        {
            CurrentHealth += -damage;
            if (CurrentHealth < 0)
            {
                KillMe();
            }
        }
    }

    public virtual void KillMe()
    {
        gameObject.SetActive(false);
    }
}
