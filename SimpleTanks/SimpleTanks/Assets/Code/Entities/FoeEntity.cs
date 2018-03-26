using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(menuName = ("MyAssets/FoeEntity"))]
public class FoeEntity : UnitEntity {
    public Color32 Appearance;
    public float Damage;
}
