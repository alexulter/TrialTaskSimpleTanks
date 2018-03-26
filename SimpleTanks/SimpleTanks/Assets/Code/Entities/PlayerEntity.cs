using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(menuName =("MyAssets/PlayerEntity"))]
public class PlayerEntity : UnitEntity {
    public GunEntity[] GunsList;
}
