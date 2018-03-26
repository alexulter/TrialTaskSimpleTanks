using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : UnitController {
    public PlayerEntity PlayerData;
    public int CurrentGunIndex;

    public GameObject GunGo;

    public override void Initialize()
    {
        base.Initialize();
        CurrentHealth = PlayerData.MaxHealthPoints;
        CurrentGunIndex = 0;
        var movCtr = GetComponent<TankMovementController>();
        if (movCtr)
        {
            movCtr.SetMovespeed(PlayerData.Movespeed);
        }
        SetUpGun();
    }

    private void SetUpGun()
    {
        var guns = PlayerData.GunsList;
        var mesh = GunGo.GetComponent<Renderer>();
        if (CurrentGunIndex >= guns.Length) { CurrentGunIndex = 0; }
        if (CurrentGunIndex < 0) { CurrentGunIndex = guns.Length - 1; }
        var currGun = guns[CurrentGunIndex];
        mesh.material.color = currGun.Appearance;
        var fireController = GetComponent<TankFireController>();
        if (!fireController) return;
        fireController.SetDamage(currGun.Damage);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) { CurrentGunIndex--; SetUpGun(); }
        if (Input.GetKeyDown(KeyCode.E)) { CurrentGunIndex++; SetUpGun(); }
    }
}
