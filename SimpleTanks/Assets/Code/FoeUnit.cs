using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoeUnit : UnitController {
    private PlayerUnit player;
    public FoeEntity FoeData
    {
        get { return (FoeEntity)UnitData; }
    }

    public override void Initialize()
    {
        base.Initialize();
        CurrentHealth = FoeData.MaxHealthPoints;
        player = FindObjectOfType<PlayerUnit>();
        if (!player) { KillMe(); }
        var body = GetComponentInChildren<Renderer>();
        if (body)
        {
            body.material.color = FoeData.Appearance;
        }
    }

    private void Update()
    {
        var goal = player.transform.position;
        transform.position += (goal - transform.position).normalized * FoeData.Movespeed * Time.deltaTime;
    }


}
