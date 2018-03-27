using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("MyAssets/GunEntity"))]
public class GunEntity : ScriptableObject {
    public Color32 Appearance;
    public float Damage;
}
